using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IHatDal
    {
        List<Hat> HatListesi();
        List<Hat> SatisYapilanHat();
        Hat HatIdIleGetir(int id);
        void Guncelle(Hat Hat);
        void Sil(Hat tablo);
    }
}
