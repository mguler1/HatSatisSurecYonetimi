using Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class IlceMap : IEntityTypeConfiguration<Ilce>
    {
        public void Configure(EntityTypeBuilder<Ilce> builder)
        {
            builder.HasKey(I => I.IlceId);
            builder.Property(I => I.IlceId).UseIdentityColumn();
             builder.HasOne(ilce => ilce.Il)
            .WithMany(il => il.Ilceler)
            .HasForeignKey(ilce => ilce.IlId);
        }
    }
}