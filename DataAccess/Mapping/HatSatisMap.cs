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
    public class HatSatisMap : IEntityTypeConfiguration<HatSatis>
    {
        public void Configure(EntityTypeBuilder<HatSatis> builder)
        {
            builder.HasKey(I => I.HatSatisId);
            builder.Property(I => I.HatSatisId).UseIdentityColumn();

            builder.Property(I => I.Ad).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Soyad).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Adres).IsRequired().HasMaxLength(200);
            builder.Property(I => I.EPosta).IsRequired().HasMaxLength(200);
            builder.HasOne(I => I.Hat).WithMany(I => I.HatSatis).HasForeignKey(I => I.HatId);
        }
    }
}