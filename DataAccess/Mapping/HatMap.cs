using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class HatMap : IEntityTypeConfiguration<Hat>
    {
        public void Configure(EntityTypeBuilder<Hat> builder)
        {
            builder.HasKey(I => I.HatId);
            builder.Property(I => I.HatId).UseIdentityColumn();
        }
    }
}