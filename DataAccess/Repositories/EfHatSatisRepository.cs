using DataAccess.Concrete;
using DataAccess.Interfaces;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EfHatSatisRepository : IHatSatisDal
    {
        public HatSatis GetirIdile(int HatSatisId)
        {
            using var context = new Context();
            return context.Set<HatSatis>().Find(HatSatisId);
        }

        public void Guncelle(HatSatis HatSatis)
        {
            using var context = new Context();
            context.Set<HatSatis>().Update(HatSatis);
            context.SaveChanges();
        }

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

        public List<HatSatis> OnayBekleyenHatListesi()
        {
            using var context = new Context();
            return context.HatSatis.Include(x=>x.Hat).Where(x=>x.HatOnayDurumu==0 && x.HatAcilisTarihi==null).ToList();
        }
    }
}
