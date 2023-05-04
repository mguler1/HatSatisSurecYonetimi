using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class HatKullanimDto
    {
        public int HatKullanimId { get; set; }
        public int HatId { get; set; }
        public virtual Hat Hat { get; set; }
        public int KonusmaSuresi { get; set; }
        public int Tutar { get; set; }
    }
}
