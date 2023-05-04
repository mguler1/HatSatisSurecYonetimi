﻿using Dto;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Interfaces
{
    public interface IHatSatisDal
    {
         List<Il> IlListesi();
         List<Ilce> IlceListesi(int IlId);
    }
}
