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
    public class EfHatKullanimRepository : IHatKullanimDal
    {
        public void Kaydet(HatKullanim hatKullanim)
        {
            using var context = new Context();
            context.Set<HatKullanim>().Add(hatKullanim);
            context.SaveChanges();
        }

        public List<HatKullanim> KullanimDetayListe(int HatId)
        {

            using var context = new Context();
            return context.HatKullanims.Include(x => x.Hat).Where(x => x.HatId== HatId).ToList();
        }
    }
}
