using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class HatListeDto
    {
        public int HatId { get; set; }
        public string TelefonNo { get; set; }
        public byte SatisDurumu { get; set; }

        public string Ad { get; set; }
        public string Soyad { get; set; }

        public DateTime? HatAcilisTarihi { get; set; }

    }
}
