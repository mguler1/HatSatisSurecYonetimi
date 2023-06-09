﻿// <auto-generated />
using System;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entity.Concrete.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "66d4ee4e-814c-4bd1-9b9c-4459c138e247",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "27d4df46-1efa-4d25-b15a-0f03a034246f",
                            Name = "Editor"
                        });
                });

            modelBuilder.Entity("Entity.Concrete.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "06ea4e01-98de-471f-aeb5-1f9093e8a3ac",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "USERADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEG4pvXRq8U8SmyQwhZsg6kvpbry7/mN+nElptbtKjmr9WOQGF2H0q4/OUN4mIrc30A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ABMVRMEQ3AFV3PSTDO2RXVIRY4I4TDUP",
                            TwoFactorEnabled = false,
                            UserName = "UserAdmin"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "780bff22-a28a-4f08-93bd-d86772c7f522",
                            Email = "editor@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "EDITOR@GMAIL.COM",
                            NormalizedUserName = "USEREDITOR",
                            PasswordHash = "AQAAAAIAAYagAAAAEG4pvXRq8U8SmyQwhZsg6kvpbry7/mN+nElptbtKjmr9WOQGF2H0q4/OUN4mIrc30A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "PI5KOF5DJXX3Z7ABGEA6VRGNWYJHLOLR",
                            TwoFactorEnabled = false,
                            UserName = "UserEditor"
                        });
                });

            modelBuilder.Entity("Entity.Concrete.Hat", b =>
                {
                    b.Property<int>("HatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HatId"), 1L, 1);

                    b.Property<byte>("SatisDurumu")
                        .HasColumnType("tinyint");

                    b.Property<string>("TelefonNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HatId");

                    b.ToTable("Hats");

                    b.HasData(
                        new
                        {
                            HatId = 1,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)678-07-01"
                        },
                        new
                        {
                            HatId = 2,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)297-56-20"
                        },
                        new
                        {
                            HatId = 3,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)330-73-08"
                        },
                        new
                        {
                            HatId = 4,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)275-09-17"
                        },
                        new
                        {
                            HatId = 5,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)955-66-75"
                        },
                        new
                        {
                            HatId = 6,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)734-35-55"
                        },
                        new
                        {
                            HatId = 7,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)867-16-55"
                        },
                        new
                        {
                            HatId = 8,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)319-23-78"
                        },
                        new
                        {
                            HatId = 9,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)349-91-58"
                        },
                        new
                        {
                            HatId = 10,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)831-48-74"
                        },
                        new
                        {
                            HatId = 12,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)692-96-12"
                        },
                        new
                        {
                            HatId = 11,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)319-97-49"
                        },
                        new
                        {
                            HatId = 13,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)519-66-85"
                        },
                        new
                        {
                            HatId = 14,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)170-94-46"
                        },
                        new
                        {
                            HatId = 15,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)557-30-73"
                        },
                        new
                        {
                            HatId = 16,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)666-37-83"
                        },
                        new
                        {
                            HatId = 17,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)030-61-51"
                        },
                        new
                        {
                            HatId = 18,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)322-76-95"
                        },
                        new
                        {
                            HatId = 19,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)535-50-92"
                        },
                        new
                        {
                            HatId = 20,
                            SatisDurumu = (byte)0,
                            TelefonNo = "(507)591-38-47"
                        });
                });

            modelBuilder.Entity("Entity.Concrete.HatKullanim", b =>
                {
                    b.Property<int>("HatKullanimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HatKullanimId"), 1L, 1);

                    b.Property<int>("HatId")
                        .HasColumnType("int");

                    b.Property<int>("KonusmaSuresi")
                        .HasColumnType("int");

                    b.Property<DateTime>("KonusmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Tutar")
                        .HasColumnType("int");

                    b.HasKey("HatKullanimId");

                    b.HasIndex("HatId");

                    b.ToTable("HatKullanims");
                });

            modelBuilder.Entity("Entity.Concrete.HatSatis", b =>
                {
                    b.Property<int>("HatSatisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HatSatisId"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("EPosta")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("HatAcilisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("HatId")
                        .HasColumnType("int");

                    b.Property<byte>("HatOnayDurumu")
                        .HasColumnType("tinyint");

                    b.Property<int>("IlId")
                        .HasColumnType("int");

                    b.Property<int>("Ilce")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("HatSatisId");

                    b.HasIndex("HatId");

                    b.HasIndex("IlId");

                    b.ToTable("HatSatis");
                });

            modelBuilder.Entity("Entity.Concrete.Il", b =>
                {
                    b.Property<int>("IlId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IlId"), 1L, 1);

                    b.Property<string>("IlAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IlId");

                    b.ToTable("Il");

                    b.HasData(
                        new
                        {
                            IlId = 1,
                            IlAdi = "ANKARA"
                        },
                        new
                        {
                            IlId = 2,
                            IlAdi = "İSTANBUL"
                        });
                });

            modelBuilder.Entity("Entity.Concrete.Ilce", b =>
                {
                    b.Property<int>("IlceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IlceId"), 1L, 1);

                    b.Property<int>("IlId")
                        .HasColumnType("int");

                    b.Property<string>("IlceAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IlceId");

                    b.HasIndex("IlId");

                    b.ToTable("Ilce");

                    b.HasData(
                        new
                        {
                            IlceId = 1,
                            IlId = 1,
                            IlceAdi = "AKYURT"
                        },
                        new
                        {
                            IlceId = 2,
                            IlId = 1,
                            IlceAdi = "ALTINDAĞ"
                        },
                        new
                        {
                            IlceId = 3,
                            IlId = 1,
                            IlceAdi = "AYAŞ"
                        },
                        new
                        {
                            IlceId = 4,
                            IlId = 1,
                            IlceAdi = "BALA"
                        },
                        new
                        {
                            IlceId = 5,
                            IlId = 1,
                            IlceAdi = "BEYPAZARI"
                        },
                        new
                        {
                            IlceId = 6,
                            IlId = 1,
                            IlceAdi = "ÇAMLIDERE"
                        },
                        new
                        {
                            IlceId = 7,
                            IlId = 1,
                            IlceAdi = "ÇANKAYA"
                        },
                        new
                        {
                            IlceId = 8,
                            IlId = 1,
                            IlceAdi = "ÇUBUK"
                        },
                        new
                        {
                            IlceId = 9,
                            IlId = 1,
                            IlceAdi = "ELMADAĞ"
                        },
                        new
                        {
                            IlceId = 10,
                            IlId = 1,
                            IlceAdi = "ETİMESGUT"
                        },
                        new
                        {
                            IlceId = 11,
                            IlId = 1,
                            IlceAdi = "EVREN"
                        },
                        new
                        {
                            IlceId = 12,
                            IlId = 1,
                            IlceAdi = "GÖLBAŞI"
                        },
                        new
                        {
                            IlceId = 13,
                            IlId = 1,
                            IlceAdi = "GÜDÜL"
                        },
                        new
                        {
                            IlceId = 14,
                            IlId = 1,
                            IlceAdi = "HAYMANA"
                        },
                        new
                        {
                            IlceId = 15,
                            IlId = 1,
                            IlceAdi = "KAHRAMANKAZAN"
                        },
                        new
                        {
                            IlceId = 16,
                            IlId = 1,
                            IlceAdi = "KALECİK"
                        },
                        new
                        {
                            IlceId = 17,
                            IlId = 1,
                            IlceAdi = "KEÇİÖREN"
                        },
                        new
                        {
                            IlceId = 18,
                            IlId = 1,
                            IlceAdi = "KIZILCAHAMAM"
                        },
                        new
                        {
                            IlceId = 19,
                            IlId = 1,
                            IlceAdi = "MAMAK"
                        },
                        new
                        {
                            IlceId = 20,
                            IlId = 1,
                            IlceAdi = "NALLIHAN"
                        },
                        new
                        {
                            IlceId = 21,
                            IlId = 1,
                            IlceAdi = "POLATLI"
                        },
                        new
                        {
                            IlceId = 22,
                            IlId = 1,
                            IlceAdi = "PURSAKLAR"
                        },
                        new
                        {
                            IlceId = 23,
                            IlId = 1,
                            IlceAdi = "SİNCAN"
                        },
                        new
                        {
                            IlceId = 24,
                            IlId = 1,
                            IlceAdi = "ŞEREFLİKOÇHİSAR"
                        },
                        new
                        {
                            IlceId = 25,
                            IlId = 1,
                            IlceAdi = "YENİMAHALLE"
                        },
                        new
                        {
                            IlceId = 26,
                            IlId = 2,
                            IlceAdi = "ADALAR"
                        },
                        new
                        {
                            IlceId = 27,
                            IlId = 2,
                            IlceAdi = "ARNAVUTKÖY"
                        },
                        new
                        {
                            IlceId = 28,
                            IlId = 2,
                            IlceAdi = "ATAŞEHİR"
                        },
                        new
                        {
                            IlceId = 29,
                            IlId = 2,
                            IlceAdi = "AVCILAR"
                        },
                        new
                        {
                            IlceId = 30,
                            IlId = 2,
                            IlceAdi = "BAĞCILAR"
                        },
                        new
                        {
                            IlceId = 31,
                            IlId = 2,
                            IlceAdi = "BAHÇELİEVLER"
                        },
                        new
                        {
                            IlceId = 32,
                            IlId = 2,
                            IlceAdi = "BAKIRKÖY"
                        },
                        new
                        {
                            IlceId = 33,
                            IlId = 2,
                            IlceAdi = "BAŞAKŞEHİR"
                        },
                        new
                        {
                            IlceId = 34,
                            IlId = 2,
                            IlceAdi = "BAYRAMPAŞA"
                        },
                        new
                        {
                            IlceId = 35,
                            IlId = 2,
                            IlceAdi = "BEŞİKTAŞ"
                        },
                        new
                        {
                            IlceId = 36,
                            IlId = 2,
                            IlceAdi = "BEYKOZ"
                        },
                        new
                        {
                            IlceId = 37,
                            IlId = 2,
                            IlceAdi = "BEYOĞLU"
                        },
                        new
                        {
                            IlceId = 38,
                            IlId = 2,
                            IlceAdi = "BÜYÜKÇEKMECE"
                        },
                        new
                        {
                            IlceId = 39,
                            IlId = 2,
                            IlceAdi = "ÇATALCA"
                        },
                        new
                        {
                            IlceId = 40,
                            IlId = 2,
                            IlceAdi = "ÇEKMEKÖY"
                        },
                        new
                        {
                            IlceId = 41,
                            IlId = 2,
                            IlceAdi = "ESENLER"
                        },
                        new
                        {
                            IlceId = 42,
                            IlId = 2,
                            IlceAdi = "ESENYURT"
                        },
                        new
                        {
                            IlceId = 43,
                            IlId = 2,
                            IlceAdi = "EYÜPSULTAN"
                        },
                        new
                        {
                            IlceId = 44,
                            IlId = 2,
                            IlceAdi = "FATİH"
                        },
                        new
                        {
                            IlceId = 45,
                            IlId = 2,
                            IlceAdi = "GAZİOSMANPAŞA"
                        },
                        new
                        {
                            IlceId = 46,
                            IlId = 2,
                            IlceAdi = "GÜNGÖREN"
                        },
                        new
                        {
                            IlceId = 47,
                            IlId = 2,
                            IlceAdi = "KADIKÖY"
                        },
                        new
                        {
                            IlceId = 48,
                            IlId = 2,
                            IlceAdi = "KAĞITHANE"
                        },
                        new
                        {
                            IlceId = 49,
                            IlId = 2,
                            IlceAdi = "KARTAL"
                        },
                        new
                        {
                            IlceId = 50,
                            IlId = 2,
                            IlceAdi = "KÜÇÜKÇEKMECE"
                        },
                        new
                        {
                            IlceId = 51,
                            IlId = 2,
                            IlceAdi = "MALTEPE"
                        },
                        new
                        {
                            IlceId = 52,
                            IlId = 2,
                            IlceAdi = "PENDİK"
                        },
                        new
                        {
                            IlceId = 53,
                            IlId = 2,
                            IlceAdi = "SANCAKTEPE"
                        },
                        new
                        {
                            IlceId = 54,
                            IlId = 2,
                            IlceAdi = "SARIYER"
                        },
                        new
                        {
                            IlceId = 55,
                            IlId = 2,
                            IlceAdi = "SİLİVRİ"
                        },
                        new
                        {
                            IlceId = 56,
                            IlId = 2,
                            IlceAdi = "SULTANBEYLİ"
                        },
                        new
                        {
                            IlceId = 57,
                            IlId = 2,
                            IlceAdi = "SULTANGAZİ"
                        },
                        new
                        {
                            IlceId = 58,
                            IlId = 2,
                            IlceAdi = "ŞİLE"
                        },
                        new
                        {
                            IlceId = 59,
                            IlId = 2,
                            IlceAdi = "ŞİŞLİ"
                        },
                        new
                        {
                            IlceId = 60,
                            IlId = 2,
                            IlceAdi = "TUZLA"
                        },
                        new
                        {
                            IlceId = 61,
                            IlId = 2,
                            IlceAdi = "ÜMRANİYE"
                        },
                        new
                        {
                            IlceId = 62,
                            IlId = 2,
                            IlceAdi = "ÜSKÜDAR"
                        },
                        new
                        {
                            IlceId = 63,
                            IlId = 2,
                            IlceAdi = "ZEYTİNBURNU"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<int>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Entity.Concrete.UserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<int>");

                    b.HasDiscriminator().HasValue("UserRole");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("Entity.Concrete.HatKullanim", b =>
                {
                    b.HasOne("Entity.Concrete.Hat", "Hat")
                        .WithMany("HatKullanims")
                        .HasForeignKey("HatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hat");
                });

            modelBuilder.Entity("Entity.Concrete.HatSatis", b =>
                {
                    b.HasOne("Entity.Concrete.Hat", "Hat")
                        .WithMany("HatSatis")
                        .HasForeignKey("HatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.Il", "Ils")
                        .WithMany("HatSatis")
                        .HasForeignKey("IlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hat");

                    b.Navigation("Ils");
                });

            modelBuilder.Entity("Entity.Concrete.Ilce", b =>
                {
                    b.HasOne("Entity.Concrete.Il", "Il")
                        .WithMany("Ilceler")
                        .HasForeignKey("IlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Il");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Entity.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Entity.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Entity.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Entity.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Entity.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Concrete.Hat", b =>
                {
                    b.Navigation("HatKullanims");

                    b.Navigation("HatSatis");
                });

            modelBuilder.Entity("Entity.Concrete.Il", b =>
                {
                    b.Navigation("HatSatis");

                    b.Navigation("Ilceler");
                });
#pragma warning restore 612, 618
        }
    }
}
