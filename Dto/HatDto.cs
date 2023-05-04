using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class HatDto
    {
        public int HatId { get; set; }
        public string TelefonNo { get; set; }
        public byte SatisDurumu { get; set; }

        public virtual ICollection<HatSatis> HatSatis { get; set; }
        public virtual ICollection<HatKullanim> HatKullanims { get; set; }
    }
}
