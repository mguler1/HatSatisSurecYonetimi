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
    public class HatKullanimManager : IHatKullanimService
    {
        private readonly IHatKullanimDal _hatKullanimDal;

        public HatKullanimManager(IHatKullanimDal hatKullanimDal)
        {
            _hatKullanimDal = hatKullanimDal;
        }

        public void Kayit(HatKullanim hatKullanim)
        {
           _hatKullanimDal.Kaydet(hatKullanim);
        }
    }
}
