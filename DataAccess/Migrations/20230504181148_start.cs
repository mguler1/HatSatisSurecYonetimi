using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hats",
                columns: table => new
                {
                    HatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelefonNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SatisDurumu = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hats", x => x.HatId);
                });

            migrationBuilder.CreateTable(
                name: "Il",
                columns: table => new
                {
                    IlId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Il", x => x.IlId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HatKullanims",
                columns: table => new
                {
                    HatKullanimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HatId = table.Column<int>(type: "int", nullable: false),
                    KonusmaSuresi = table.Column<int>(type: "int", nullable: false),
                    Tutar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HatKullanims", x => x.HatKullanimId);
                    table.ForeignKey(
                        name: "FK_HatKullanims_Hats_HatId",
                        column: x => x.HatId,
                        principalTable: "Hats",
                        principalColumn: "HatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HatSatis",
                columns: table => new
                {
                    HatSatisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EPosta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HatId = table.Column<int>(type: "int", nullable: false),
                    Il = table.Column<int>(type: "int", nullable: false),
                    Ilce = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "ntext", maxLength: 200, nullable: false),
                    HatAcilisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HatOnayDurumu = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HatSatis", x => x.HatSatisId);
                    table.ForeignKey(
                        name: "FK_HatSatis_Hats_HatId",
                        column: x => x.HatId,
                        principalTable: "Hats",
                        principalColumn: "HatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ilce",
                columns: table => new
                {
                    IlceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlceAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilce", x => x.IlceId);
                    table.ForeignKey(
                        name: "FK_Ilce_Il_IlId",
                        column: x => x.IlId,
                        principalTable: "Il",
                        principalColumn: "IlId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "74a8ab74-eed2-4b13-9fd5-e9e71d83b5a0", "Admin", null },
                    { 2, "5ad10d47-0df4-4a6d-b135-00b538690486", "Editor", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "230a9a84-6f1b-4eb4-8753-2e960f0b92ed", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "USERADMIN", "AQAAAAIAAYagAAAAEG4pvXRq8U8SmyQwhZsg6kvpbry7/mN+nElptbtKjmr9WOQGF2H0q4/OUN4mIrc30A==", null, false, null, false, "UserAdmin" },
                    { 2, 0, "fddb1dc0-6e2a-4e77-942e-ff685e8f6314", "editor@gmail.com", false, false, null, "EDITOR@GMAIL.COM", "USEREDITOR", "AQAAAAIAAYagAAAAEG4pvXRq8U8SmyQwhZsg6kvpbry7/mN+nElptbtKjmr9WOQGF2H0q4/OUN4mIrc30A==", null, false, null, false, "UserEditor" }
                });

            migrationBuilder.InsertData(
                table: "Hats",
                columns: new[] { "HatId", "SatisDurumu", "TelefonNo" },
                values: new object[,]
                {
                    { 1, (byte)0, "(507)678-07-01" },
                    { 2, (byte)0, "(507)297-56-20" },
                    { 3, (byte)0, "(507)330-73-08" },
                    { 4, (byte)0, "(507)275-09-17" },
                    { 5, (byte)0, "(507)955-66-75" },
                    { 6, (byte)0, "(507)734-35-55" },
                    { 7, (byte)0, "(507)867-16-55" },
                    { 8, (byte)0, "(507)319-23-78" },
                    { 9, (byte)0, "(507)349-91-58" },
                    { 10, (byte)0, "(507)831-48-74" },
                    { 11, (byte)0, "(507)319-97-49" },
                    { 12, (byte)0, "(507)692-96-12" },
                    { 13, (byte)0, "(507)519-66-85" },
                    { 14, (byte)0, "(507)170-94-46" },
                    { 15, (byte)0, "(507)557-30-73" },
                    { 16, (byte)0, "(507)666-37-83" },
                    { 17, (byte)0, "(507)030-61-51" },
                    { 18, (byte)0, "(507)322-76-95" },
                    { 19, (byte)0, "(507)535-50-92" },
                    { 20, (byte)0, "(507)591-38-47" }
                });

            migrationBuilder.InsertData(
                table: "Il",
                columns: new[] { "IlId", "IlAdi" },
                values: new object[,]
                {
                    { 1, "ANKARA" },
                    { 2, "İSTANBUL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { 1, 1, "UserRole" },
                    { 2, 2, "UserRole" }
                });

            migrationBuilder.InsertData(
                table: "Ilce",
                columns: new[] { "IlceId", "IlId", "IlceAdi" },
                values: new object[,]
                {
                    { 1, 1, "AKYURT" },
                    { 2, 1, "ALTINDAĞ" },
                    { 3, 1, "AYAŞ" },
                    { 4, 1, "BALA" },
                    { 5, 1, "BEYPAZARI" },
                    { 6, 1, "ÇAMLIDERE" },
                    { 7, 1, "ÇANKAYA" },
                    { 8, 1, "ÇUBUK" },
                    { 9, 1, "ELMADAĞ" },
                    { 10, 1, "ETİMESGUT" },
                    { 11, 1, "EVREN" },
                    { 12, 1, "GÖLBAŞI" },
                    { 13, 1, "GÜDÜL" },
                    { 14, 1, "HAYMANA" },
                    { 15, 1, "KAHRAMANKAZAN" },
                    { 16, 1, "KALECİK" },
                    { 17, 1, "KEÇİÖREN" },
                    { 18, 1, "KIZILCAHAMAM" },
                    { 19, 1, "MAMAK" },
                    { 20, 1, "NALLIHAN" },
                    { 21, 1, "POLATLI" },
                    { 22, 1, "PURSAKLAR" },
                    { 23, 1, "SİNCAN" },
                    { 24, 1, "ŞEREFLİKOÇHİSAR" },
                    { 25, 1, "YENİMAHALLE" },
                    { 26, 2, "ADALAR" },
                    { 27, 2, "ARNAVUTKÖY" },
                    { 28, 2, "ATAŞEHİR" },
                    { 29, 2, "AVCILAR" },
                    { 30, 2, "BAĞCILAR" },
                    { 31, 2, "BAHÇELİEVLER" },
                    { 32, 2, "BAKIRKÖY" },
                    { 33, 2, "BAŞAKŞEHİR" },
                    { 34, 2, "BAYRAMPAŞA" },
                    { 35, 2, "BEŞİKTAŞ" },
                    { 36, 2, "BEYKOZ" },
                    { 37, 2, "BEYOĞLU" },
                    { 38, 2, "BÜYÜKÇEKMECE" },
                    { 39, 2, "ÇATALCA" },
                    { 40, 2, "ÇEKMEKÖY" }
                });

            migrationBuilder.InsertData(
                table: "Ilce",
                columns: new[] { "IlceId", "IlId", "IlceAdi" },
                values: new object[,]
                {
                    { 41, 2, "ESENLER" },
                    { 42, 2, "ESENYURT" },
                    { 43, 2, "EYÜPSULTAN" },
                    { 44, 2, "FATİH" },
                    { 45, 2, "GAZİOSMANPAŞA" },
                    { 46, 2, "GÜNGÖREN" },
                    { 47, 2, "KADIKÖY" },
                    { 48, 2, "KAĞITHANE" },
                    { 49, 2, "KARTAL" },
                    { 50, 2, "KÜÇÜKÇEKMECE" },
                    { 51, 2, "MALTEPE" },
                    { 52, 2, "PENDİK" },
                    { 53, 2, "SANCAKTEPE" },
                    { 54, 2, "SARIYER" },
                    { 55, 2, "SİLİVRİ" },
                    { 56, 2, "SULTANBEYLİ" },
                    { 57, 2, "SULTANGAZİ" },
                    { 58, 2, "ŞİLE" },
                    { 59, 2, "ŞİŞLİ" },
                    { 60, 2, "TUZLA" },
                    { 61, 2, "ÜMRANİYE" },
                    { 62, 2, "ÜSKÜDAR" },
                    { 63, 2, "ZEYTİNBURNU" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HatKullanims_HatId",
                table: "HatKullanims",
                column: "HatId");

            migrationBuilder.CreateIndex(
                name: "IX_HatSatis_HatId",
                table: "HatSatis",
                column: "HatId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilce_IlId",
                table: "Ilce",
                column: "IlId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "HatKullanims");

            migrationBuilder.DropTable(
                name: "HatSatis");

            migrationBuilder.DropTable(
                name: "Ilce");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Hats");

            migrationBuilder.DropTable(
                name: "Il");
        }
    }
}
