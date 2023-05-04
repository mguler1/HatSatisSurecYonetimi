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
                new AppUser { Id = 1, UserName = "UserAdmin", NormalizedUserName = "USERADMIN", Email = "admin@gmail.com", NormalizedEmail= "ADMIN@GMAIL.COM", PasswordHash = "AQAAAAIAAYagAAAAEG4pvXRq8U8SmyQwhZsg6kvpbry7/mN+nElptbtKjmr9WOQGF2H0q4/OUN4mIrc30A==", EmailConfirmed = false, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = false, AccessFailedCount = 0 },
                new AppUser { Id = 2, UserName = "UserEditor", NormalizedUserName = "USEREDITOR", Email = "editor@gmail.com",NormalizedEmail= "EDITOR@GMAIL.COM" ,EmailConfirmed = false, PasswordHash = "AQAAAAIAAYagAAAAEG4pvXRq8U8SmyQwhZsg6kvpbry7/mN+nElptbtKjmr9WOQGF2H0q4/OUN4mIrc30A==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = false, AccessFailedCount = 0 }
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

            builder.Entity<Hat>().HasData
            (
            new Hat { Hat_Id = 1, TelefonNo = "(507)678-07-01", SatisDurumu=0 },
            new Hat { Hat_Id = 2, TelefonNo = "(507)297-56-20", SatisDurumu=0 },
            new Hat { Hat_Id = 3, TelefonNo = "(507)330-73-08", SatisDurumu=0 },
            new Hat { Hat_Id = 4, TelefonNo = "(507)275-09-17", SatisDurumu=0 },
            new Hat { Hat_Id = 5, TelefonNo = "(507)955-66-75", SatisDurumu=0 },
            new Hat { Hat_Id = 6, TelefonNo = "(507)734-35-55", SatisDurumu=0 },
            new Hat { Hat_Id = 7, TelefonNo = "(507)867-16-55", SatisDurumu=0 },
            new Hat { Hat_Id = 8, TelefonNo = "(507)319-23-78", SatisDurumu=0 },
            new Hat { Hat_Id = 9, TelefonNo = "(507)349-91-58", SatisDurumu=0 },
            new Hat { Hat_Id = 10, TelefonNo ="(507)831-48-74", SatisDurumu=0 },

            new Hat { Hat_Id = 12, TelefonNo = "(507)692-96-12", SatisDurumu=0 },
            new Hat { Hat_Id = 11, TelefonNo = "(507)319-97-49", SatisDurumu=0 },
            new Hat { Hat_Id = 13, TelefonNo = "(507)519-66-85", SatisDurumu=0 },
            new Hat { Hat_Id = 14, TelefonNo = "(507)170-94-46", SatisDurumu=0 },
            new Hat { Hat_Id = 15, TelefonNo = "(507)557-30-73", SatisDurumu=0 },
            new Hat { Hat_Id = 16, TelefonNo = "(507)666-37-83", SatisDurumu=0 },
            new Hat { Hat_Id = 17, TelefonNo = "(507)030-61-51", SatisDurumu=0 },
            new Hat { Hat_Id = 18, TelefonNo = "(507)322-76-95", SatisDurumu=0 },
            new Hat { Hat_Id = 19, TelefonNo = "(507)535-50-92", SatisDurumu=0 },
            new Hat { Hat_Id = 20, TelefonNo = "(507)591-38-47", SatisDurumu=0 }
            );
            base.OnModelCreating(builder);
        }
    }
}