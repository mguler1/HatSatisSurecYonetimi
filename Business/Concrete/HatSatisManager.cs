using Business.Interface;
using DataAccess.Interfaces;
using Dto;
using Entity.Concrete;
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

        public HatSatisManager(IHatSatisDal hatSatisDal, IHatDal hatDal)
        {
            _hatSatisDal = hatSatisDal;
            _hatDal = hatDal;
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
            if (satilanHat!=null)
            {
                _hatDal.Guncelle(new Hat
                {   HatId = satilanHat.HatId,
                TelefonNo = satilanHat.TelefonNo,
                    SatisDurumu = 1
                });
            }
          
        }
    }
}
