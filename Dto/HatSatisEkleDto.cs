﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class HatSatisEkleDto
    {
        public int HatSatisId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string EPosta { get; set; }
        public int HatId { get; set; }
        public int Il { get; set; }
        public int Ilce { get; set; }
        public string Adres { get; set; }
        public DateTime? HatAcilisTarihi { get; set; } = null;
        public byte HatOnayDurumu { get; set; }
    }
}
