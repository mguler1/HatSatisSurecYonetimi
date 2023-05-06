using Business.Interface;
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
        public HatKullanimEkle(IHatKullanimService hatKullanimService)
        {
            _hatKullanimService = hatKullanimService;   
        }

        public async Task Execute(IJobExecutionContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            var random= new Random();
           var konusmaSuresi=random.Next(1, 61);


            _hatKullanimService .Kayit(new HatKullanim 
            {
                HatId=1,
                KonusmaSuresi= konusmaSuresi,
                Tutar=1
                
            });

        }
    }
}
