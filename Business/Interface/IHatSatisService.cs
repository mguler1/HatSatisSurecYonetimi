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
        void Kayit(HatSatis hatSatis);
    }
}
