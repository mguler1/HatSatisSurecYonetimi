using Business.Interface;
using DataAccess.Interfaces;
using Dto;
using Entity.Concrete;
using Microsoft.Extensions.Configuration;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ElasticsearchManager : IElasticsearchService
    {
        private readonly ElasticClient _elasticClient;
        private readonly IHatDal _hatdal;
        public ElasticsearchManager(IConfiguration configuration, IHatDal hatDal)
        {
            var connectionString = configuration.GetConnectionString("ElasticsearchConnection");
            var settings = new ConnectionSettings(new Uri(connectionString)).DefaultIndex("hat_index"); // Elasticsearch indeks adı
            _elasticClient = new ElasticClient(settings);
            _hatdal = hatDal;
           
               CreateHatIndex();
        }
        private void CreateHatIndex()
        {
            var indexSettings = new IndexSettings
            {
                NumberOfReplicas = 1,
                NumberOfShards = 5

            };
            _elasticClient.Indices.DeleteAsync("hat_index");
            var createIndexResponse = _elasticClient.Indices.Create("hat_index", c => c
                .InitializeUsing(new IndexState { Settings = indexSettings })
                .Map<HatListeDto>(m => m
                    .AutoMap()
                )
            );

            if (!createIndexResponse.IsValid)
            {
                throw new Exception("Hat_Index oluşturulurken hata oluştu: " + createIndexResponse.DebugInformation);
            }
        }
        
        public async Task<bool> IndexHatAsync(List<HatListeDto> hat)
        {
            var success = true;

            foreach (var item in hat)
            {
                var indexResponse = await _elasticClient.IndexDocumentAsync(item);

                if (!indexResponse.IsValid)
                {
                    throw new Exception("Elasticsearch veri gönderme hatası: " + indexResponse.DebugInformation);
                }
            }

            return success;
        }
       
        public async Task<List<HatListeDto>> GetAllHatsFromElasticsearchAsync()
        {
            var hatListesi = _hatdal.SatisYapilanHat();
            var a = new List<HatListeDto>();

            foreach (var item in hatListesi)
            {
                var hatListeDto = new HatListeDto
                {
                    HatId = item.HatId,
                    SatisDurumu = item.SatisDurumu,
                    Ad = item.HatSatis.FirstOrDefault()?.Ad,
                    HatAcilisTarihi = item.HatSatis.FirstOrDefault()?.HatAcilisTarihi,
                    Soyad = item.HatSatis.FirstOrDefault()?.Soyad,
                    TelefonNo = item.TelefonNo
                };

                 a.Add(hatListeDto);
            }

           
            await IndexHatAsync(a);

            var updatedResponse = await _elasticClient.SearchAsync<HatListeDto>(s => s
                .MatchAll()
                .Size(1000));

            return updatedResponse.Documents.ToList();
        }
    }
}

