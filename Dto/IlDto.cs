using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class IlDto
    {
        public int IlId { get; set; }
        public string IlAdi { get; set; }
        public virtual ICollection<Ilce> Ilceler { get; set; }
    }
}
