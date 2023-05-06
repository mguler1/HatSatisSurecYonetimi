using Dto;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IHatSatisDal
    {
        List<Il> IlListesi();
        List<Ilce> IlceListesi(int IlId);
        List<HatSatis> OnayBekleyenHatListesi();
        void MailGonder(string Data, string filepath);
        HatSatis GetirIdile(int id);
        void Guncelle(HatSatis Hat);
        void Kaydet(HatSatis hatSatis);
    }
}
