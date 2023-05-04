using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class HatKullanim
    {
        public int HatKullanimId { get; set; }
        public int HatId { get; set; }
        public virtual Hat Hat { get; set; }
        public int KonusmaSuresi { get; set; }
        public int Tutar { get; set; }
    }
}
