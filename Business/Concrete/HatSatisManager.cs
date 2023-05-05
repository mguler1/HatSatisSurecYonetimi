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

        public HatSatisManager(IHatSatisDal hatSatisDal)
        {
            _hatSatisDal = hatSatisDal;
        }

        public List<Ilce> IlceListesi(int IlId)
        {
           return _hatSatisDal.IlceListesi(IlId);
        }

        public List<Il> IlListesi()
        {
           return _hatSatisDal.IlListesi();
        }
    }
}
