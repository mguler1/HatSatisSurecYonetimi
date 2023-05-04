using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class IlceDto
    {
        public int IlceId { get; set; }
        public string IlceAdi { get; set; }
        public int IlId { get; set; }
        public virtual Il Il { get; set; }
    }
}
