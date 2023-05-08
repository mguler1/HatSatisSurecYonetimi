using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Il
    {
        [Key]
        public int IlId { get; set; }
        public string IlAdi { get; set; }
        public virtual ICollection<Ilce> Ilceler { get; set; }
        public virtual ICollection<HatSatis> HatSatis { get; set; }
    }
}
