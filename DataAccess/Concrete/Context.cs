using Entity;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;initial catalog=HatSatisSurec;integrated security=true");
        }
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Hat> Hats { get; set; }
        public DbSet<HatSatis> HatSatis { get; set; }
        public DbSet<HatKullanim> HatKullanims { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AppUser>().HasData
                (
                new AppUser { Id = 1, UserName = "UserAdmin", NormalizedUserName = "USERADMIN", Email = "admin@gmail.com", PasswordHash = "AQAAAAIAAYagAAAAEG4pvXRq8U8SmyQwhZsg6kvpbry7/mN+nElptbtKjmr9WOQGF2H0q4/OUN4mIrc30A==", EmailConfirmed = false, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = false, AccessFailedCount = 0 },
                new AppUser { Id = 2, UserName = "UserEditor", NormalizedUserName = "USEREDITOR", Email = "editor@gmail.com", EmailConfirmed = false, PasswordHash = "AQAAAAIAAYagAAAAEG4pvXRq8U8SmyQwhZsg6kvpbry7/mN+nElptbtKjmr9WOQGF2H0q4/OUN4mIrc30A==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = false, AccessFailedCount = 0 }
                );

            builder.Entity<AppRole>().HasData
                  (
                new AppRole { Id = 1, Name = "Admin" },
                new AppRole { Id = 2, Name = "Editor" }
                );

            builder.Entity<UserRole>().HasData
                (
                new UserRole { RoleId = 1, UserId = 1 },
                new UserRole { RoleId = 2, UserId = 2 }
                );
            builder.Entity<Il>().HasData
             (
             new Il { IlId = 1, IlAdi = "ANKARA" },
             new Il { IlId = 2, IlAdi = "İSTANBUL" }
             );
            builder.Entity<Ilce>().HasData
            (
            new Ilce { IlceId = 1, IlceAdi = "AKYURT",IlId=1 },
            new Ilce { IlceId = 2, IlceAdi = "ALTINDAĞ", IlId = 1 },
            new Ilce { IlceId = 3, IlceAdi = "AYAŞ", IlId = 1 },
            new Ilce { IlceId = 4, IlceAdi = "BALA", IlId = 1 },
            new Ilce { IlceId = 5, IlceAdi = "BEYPAZARI", IlId = 1 },
            new Ilce { IlceId = 6, IlceAdi = "ÇAMLIDERE", IlId = 1 },
            new Ilce { IlceId = 7, IlceAdi = "ÇANKAYA", IlId = 1 },
            new Ilce { IlceId = 8, IlceAdi = "ÇUBUK" ,IlId = 1 },
            new Ilce { IlceId = 9, IlceAdi = "ELMADAĞ", IlId = 1 },
            new Ilce { IlceId = 10, IlceAdi = "ETİMESGUT", IlId = 1 },
            new Ilce { IlceId = 11, IlceAdi = "EVREN", IlId = 1 },
            new Ilce { IlceId = 12, IlceAdi = "GÖLBAŞI", IlId = 1 },
            new Ilce { IlceId = 13, IlceAdi = "GÜDÜL", IlId = 1 },
            new Ilce { IlceId = 14, IlceAdi = "HAYMANA", IlId = 1 },
            new Ilce { IlceId = 15, IlceAdi = "KAHRAMANKAZAN", IlId = 1 },
            new Ilce { IlceId = 16, IlceAdi = "KALECİK", IlId = 1 },
            new Ilce { IlceId = 17, IlceAdi = "KEÇİÖREN", IlId = 1 },
            new Ilce { IlceId = 18, IlceAdi = "KIZILCAHAMAM", IlId = 1 },
            new Ilce { IlceId = 19, IlceAdi = "MAMAK", IlId = 1 },
            new Ilce { IlceId = 20, IlceAdi = "NALLIHAN", IlId = 1 },
            new Ilce { IlceId = 21, IlceAdi = "POLATLI", IlId = 1 },
            new Ilce { IlceId = 22, IlceAdi = "PURSAKLAR", IlId = 1 },
            new Ilce { IlceId = 23, IlceAdi = "SİNCAN", IlId = 1 },
            new Ilce { IlceId = 24, IlceAdi = "ŞEREFLİKOÇHİSAR", IlId = 1 },
            new Ilce { IlceId = 25, IlceAdi = "YENİMAHALLE", IlId = 1 },
            new Ilce { IlceId = 26, IlceAdi = "ADALAR", IlId = 2 },
            new Ilce { IlceId = 27, IlceAdi = "ARNAVUTKÖY", IlId = 2 },
            new Ilce { IlceId = 28, IlceAdi = "ATAŞEHİR", IlId = 2 },
            new Ilce { IlceId = 29, IlceAdi = "AVCILAR", IlId = 2 },
            new Ilce { IlceId = 30, IlceAdi = "BAĞCILAR", IlId = 2 },
            new Ilce { IlceId = 31, IlceAdi = "BAHÇELİEVLER", IlId = 2 },
            new Ilce { IlceId = 32, IlceAdi = "BAKIRKÖY", IlId = 2 },
            new Ilce { IlceId = 33, IlceAdi = "BAŞAKŞEHİR", IlId = 2 },
            new Ilce { IlceId = 34, IlceAdi = "BAYRAMPAŞA", IlId = 2 },
            new Ilce { IlceId = 35, IlceAdi = "BEŞİKTAŞ", IlId = 2 },
            new Ilce { IlceId = 36, IlceAdi = "BEYKOZ", IlId = 2 },
            new Ilce { IlceId = 37, IlceAdi = "BEYOĞLU", IlId = 2 },
            new Ilce { IlceId = 38, IlceAdi = "BÜYÜKÇEKMECE", IlId = 2 },
            new Ilce { IlceId = 39, IlceAdi = "ÇATALCA", IlId = 2 },
            new Ilce { IlceId = 40, IlceAdi = "ÇEKMEKÖY", IlId = 2 },
            new Ilce { IlceId = 41, IlceAdi = "ESENLER", IlId = 2 },
            new Ilce { IlceId = 42, IlceAdi = "ESENYURT", IlId = 2 },
            new Ilce { IlceId = 43, IlceAdi = "EYÜPSULTAN", IlId = 2 },
            new Ilce { IlceId = 44, IlceAdi = "FATİH", IlId = 2 },
            new Ilce { IlceId = 45, IlceAdi = "GAZİOSMANPAŞA", IlId = 2 },
            new Ilce { IlceId = 46, IlceAdi = "GÜNGÖREN", IlId = 2 },
            new Ilce { IlceId = 47, IlceAdi = "KADIKÖY", IlId = 2 },
            new Ilce { IlceId = 48, IlceAdi = "KAĞITHANE", IlId = 2 },
            new Ilce { IlceId = 49, IlceAdi = "KARTAL", IlId = 2 },
            new Ilce { IlceId = 50, IlceAdi = "KÜÇÜKÇEKMECE", IlId = 2 },
            new Ilce { IlceId = 51, IlceAdi = "MALTEPE", IlId = 2 },
            new Ilce { IlceId = 52, IlceAdi = "PENDİK", IlId = 2 },
            new Ilce { IlceId = 53, IlceAdi = "SANCAKTEPE", IlId = 2 },
            new Ilce { IlceId = 54, IlceAdi = "SARIYER", IlId = 2 },
            new Ilce { IlceId = 55, IlceAdi = "SİLİVRİ", IlId = 2 },
            new Ilce { IlceId = 56, IlceAdi = "SULTANBEYLİ", IlId = 2 },
            new Ilce { IlceId = 57, IlceAdi = "SULTANGAZİ", IlId = 2 },
            new Ilce { IlceId = 58, IlceAdi = "ŞİLE", IlId = 2 },
            new Ilce { IlceId = 59, IlceAdi = "ŞİŞLİ", IlId = 2 },
            new Ilce { IlceId = 60, IlceAdi = "TUZLA", IlId = 2 },
            new Ilce { IlceId = 61, IlceAdi = "ÜMRANİYE", IlId = 2 },
            new Ilce { IlceId = 62, IlceAdi = "ÜSKÜDAR", IlId = 2 },
            new Ilce { IlceId = 63, IlceAdi = "ZEYTİNBURNU", IlId = 2 }
            );
            base.OnModelCreating(builder);
        }
    }
}