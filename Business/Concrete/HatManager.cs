using Business.Interface;
using DataAccess.Interfaces;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HatManager : IHatService
    {
        private readonly IHatDal _hatDal;

        public HatManager(IHatDal hatDal)
        {
            _hatDal = hatDal;
        }

        public void Guncelle(Hat Hat)
        {
           _hatDal.Guncelle(Hat);
        }

        public Hat HatIdIleGetir(int id)
        {
            return _hatDal.HatIdIleGetir(id);
        }

        public List<Hat> HatListesi()
        {
          return  _hatDal.HatListesi();    
        }

        public List<Hat> SatisYapilanHat()
        {
           return _hatDal.SatisYapilanHat();
        }
    }
}
