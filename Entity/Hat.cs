using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Hat
    {
        [Key]
        public int Hat_Id { get; set; }
        public string TelefonNo { get; set; }
        public byte SatisDurumu { get; set; }

        public virtual ICollection<HatSatis> HatSatis { get; set; }
        public virtual ICollection<HatKullanim> HatKullanims { get; set; }
    }
}
