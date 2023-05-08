﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IHatKullanimService
    {
        void Kayit(HatKullanim hatKullanim);
        List<HatKullanim> KullanimDetayListe (int HatId);
    }
}
