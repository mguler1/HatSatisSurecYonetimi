using Business.Interface;
using DataAccess.Interfaces;
using Entity.Concrete;
using Microsoft.Extensions.Configuration;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ElasticsearchManager : IElasticsearchService
    {
        private readonly ElasticClient _elasticClient;
        private readonly IHatDal _hatdal;
        public ElasticsearchManager(IConfiguration configuration,IHatDal hatDal)
        {
            var connectionString = configuration.GetConnectionString("ElasticsearchConnection");
            var settings = new ConnectionSettings(new Uri(connectionString)).DefaultIndex("hat_index"); // Elasticsearch indeks adı
            _elasticClient = new ElasticClient(settings);
            _hatdal = hatDal;

           // CreateHatIndex();
        }
        private void CreateHatIndex()
        {
            // İndeks ayarlarını tanımlayın
            var indexSettings = new IndexSettings
            {
                NumberOfReplicas = 1,
                NumberOfShards = 5

            };
            var createIndexResponse = _elasticClient.Indices.Create("hat_index", c => c
                .InitializeUsing(new IndexState { Settings = indexSettings })
                .Map<Hat>(m => m
                    .AutoMap()
                )
            );

            if (!createIndexResponse.IsValid)
            {
                throw new Exception("Hat_Index oluşturulurken hata oluştu: " + createIndexResponse.DebugInformation);
            }
        }
        public async Task<bool> IndexHatAsync(Hat hat)
        {
            var indexResponse = await _elasticClient.IndexDocumentAsync(hat);

            if (indexResponse.IsValid)
            {
                return true;
            }
            else
            {
                // Elasticsearch veri gönderme hatası, hata durumunu ele alın
                throw new Exception("Elasticsearch veri gönderme hatası: " + indexResponse.DebugInformation);
            }
        }

        public async Task<List<Hat>> GetAllHatsFromElasticsearchAsync()
        {

            //var yenihat= _hatdal.HatListesi();
            // await IndexHatAsync(yenihat);
            var hatListesi = _hatdal.HatListesi();

            foreach (var hat in hatListesi)
            {
                await IndexHatAsync(hat);
            }


            var searchResponse = await _elasticClient.SearchAsync<Hat>(s => s
            .MatchAll()
            .Size(1000));

            return searchResponse.Documents.ToList();
        }
    }
}
