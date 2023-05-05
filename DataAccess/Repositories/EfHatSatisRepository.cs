using DataAccess.Concrete;
using DataAccess.Interfaces;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EfHatSatisRepository : IHatSatisDal
    {
        public List<Ilce> IlceListesi(int IlId)
        {
            using var context = new Context();
            return context.Set<Ilce>().Where(x => x.IlId == IlId).ToList();
        }

        public List<Il> IlListesi()
        {
            using var context = new Context();
            return context.Set<Il>().ToList();
        }

        public void Kaydet(HatSatis hatSatis)
        {
            using var context = new Context();
            context.Set<HatSatis>().Add(hatSatis);
            context.SaveChanges();
        }
    }
}
