﻿using DataAccess.Concrete;
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
        public void Guncelle(Hat Hat)
        {
            using var context = new Context();
            context.Set<Hat>().Update(Hat);
            context.SaveChanges();
        }

        public Hat HatIdIleGetir(int id)
        {
            using var context = new Context();
            return context.Set<Hat>().Find(id);
        }

        public List<Hat> HatListesi()
        {
            using var context = new Context();
            return context.Set<Hat>().Where(x => x.SatisDurumu == 0).ToList();
        }
    }
}
