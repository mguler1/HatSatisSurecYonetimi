using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IHatService
    {
        List<Hat> HatListesi();
        List<Hat> SatisYapilanHat();

        Hat HatIdIleGetir(int id);

        void Guncelle(Hat Hat);

    }
}
