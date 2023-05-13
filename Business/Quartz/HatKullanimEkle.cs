using Business.Interface;
using Dto;
using Entity.Concrete;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Quartz
{
    public class HatKullanimEkle : IJob
    {
        private readonly IHatKullanimService _hatKullanimService;
        private readonly IHatService _hatService;
        private readonly IHatSatisService _hatSatisService;
        public HatKullanimEkle(IHatKullanimService hatKullanimService, IHatService hatService, IHatSatisService hatSatisService)
        {
            _hatKullanimService = hatKullanimService;
            _hatService = hatService;
            _hatSatisService = hatSatisService;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            var random = new Random();
            var konusmaSuresi = random.Next(1, 61);

            var satilanHatlarListesi = _hatService.SatisYapilanHat();

             int randomIndex = random.Next(0, satilanHatlarListesi.Count);
             var HatId = satilanHatlarListesi[randomIndex].HatId;


            
            var HatSatisListesi = _hatSatisService.HatSatisListesiIdGetir(HatId);

            DateTime startDate = HatSatisListesi.HatAcilisTarihi!.Value;
            DateTime endDate = DateTime.Now;
            int range = (endDate - startDate).Days;
            DateTime randomDate = startDate.AddDays(random.Next(range));
            TimeSpan randomTime = new TimeSpan(0, random.Next(0, 24), random.Next(0, 60), random.Next(0, 60));
            var tarihSaat= randomDate.Date + randomTime;

            _hatKullanimService.Kayit(new HatKullanim
            {
                HatId = HatId,
                KonusmaSuresi = konusmaSuresi,
                Tutar = konusmaSuresi * 1,
                KonusmaTarihi = tarihSaat
            }); 
        }
    }

}