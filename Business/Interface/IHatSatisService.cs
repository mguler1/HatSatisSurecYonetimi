using Dto;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IHatSatisService
    {
        List<Il> IlListesi();
        List<Ilce> IlceListesi(int IlId);
        List<HatSatis> OnayBekleyenHatListesi();

        void HatSatisOnayla(int HatSatisId);
        HatSatis GetirIdile(int id);
        void Guncelle(HatSatis Hat);

        void Kayit(HatSatis hatSatis);
    }
}
