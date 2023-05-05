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
    public class EfHatRepository : IHatDal
    {
        public List<Hat> HatListesi()
        {
            using var context = new Context();
            return context.Set<Hat>().Where(x => x.SatisDurumu == 0).ToList();
        }
    }
}
