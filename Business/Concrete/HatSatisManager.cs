using Business.Interface;
using DataAccess.Interfaces;
using Dto;
using Entity.Concrete;
using Hangfire;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HatSatisManager : IHatSatisService
    {
        private readonly IHatSatisDal _hatSatisDal;
        private readonly IHatDal _hatDal;
        private readonly IEmailService _emailService;
        public HatSatisManager(IHatSatisDal hatSatisDal, IHatDal hatDal)
        {
            _hatSatisDal = hatSatisDal;
            _hatDal = hatDal;
        }

        public HatSatis GetirIdile(int id)
        {
          return   _hatSatisDal.GetirIdile(id);
        }

        public void Guncelle(HatSatis HatSatis)
        {
            _hatSatisDal.Guncelle(HatSatis);
        }

        public  HatSatis HatSatisListesiIdGetir(int id)
        {
          return   _hatSatisDal.HatSatisListesiIdGetir(id);
        }

        public async void HatSatisOnayla(int HatSatisId)
        {
            var tarih = DateTime.Now;
            var hatSatis = _hatSatisDal.GetirIdile(HatSatisId);
            if (hatSatis != null)
            {
                _hatSatisDal.Guncelle(new HatSatis
                {
                    HatSatisId = hatSatis.HatSatisId,
                    Ad = hatSatis.Ad,
                    Soyad = hatSatis.Soyad,
                    Adres = hatSatis.Adres,
                    EPosta = hatSatis.EPosta,
                    HatAcilisTarihi = tarih,
                    HatId = hatSatis.HatId,
                    HatOnayDurumu = 1,
                    Il = hatSatis.Il,
                    Ilce = hatSatis.Ilce
                });
             //   BackgroundJob.Enqueue(() => _emailService.MailGonder(hatSatis.EPosta));
               await _emailService.MailGonder(hatSatis.EPosta);
            }
        }

        public List<Ilce> IlceListesi(int IlId)
        {
            return _hatSatisDal.IlceListesi(IlId);
        }

        public List<Il> IlListesi()
        {
            return _hatSatisDal.IlListesi();
        }

        public void Kayit(HatSatis hatSatis)
        {
            _hatSatisDal.Kaydet(hatSatis);
            var satilanHat = _hatDal.HatIdIleGetir(hatSatis.HatId);
            if (satilanHat != null)
            {
                _hatDal.Guncelle(new Hat
                {
                    HatId = satilanHat.HatId,
                    TelefonNo = satilanHat.TelefonNo,
                    SatisDurumu = 1
                });
            }

        }

        public void MailGonder(string Data, string filepath)
        {
           _hatSatisDal.MailGonder(Data,filepath);
        }

        public List<HatSatis> OnayBekleyenHatListesi()
        {
            return _hatSatisDal.OnayBekleyenHatListesi();
        }
    }
}
