using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class addtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hats",
                columns: table => new
                {
                    Hat_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelefonNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SatisDurumu = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hats", x => x.Hat_Id);
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
                        principalColumn: "Hat_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HatSatis",
                columns: table => new
                {
                    HatSatisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EPosta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HatId = table.Column<int>(type: "int", nullable: false),
                    Il = table.Column<int>(type: "int", nullable: false),
                    Ilce = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        principalColumn: "Hat_Id",
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f305e76e-2a4f-4045-ad7b-a4adeae0390a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fdefa004-133d-4f7c-95c1-489bca75b885");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d65cd3dc-3c99-47c8-9934-82cba07395f4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e9649986-2e18-4c3e-ab7b-e63767b941a2");

            migrationBuilder.InsertData(
                table: "Il",
                columns: new[] { "IlId", "IlAdi" },
                values: new object[,]
                {
                    { 1, "ANKARA" },
                    { 2, "İSTANBUL" }
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
                    { 40, 2, "ÇEKMEKÖY" },
                    { 41, 2, "ESENLER" },
                    { 42, 2, "ESENYURT" }
                });

            migrationBuilder.InsertData(
                table: "Ilce",
                columns: new[] { "IlceId", "IlId", "IlceAdi" },
                values: new object[,]
                {
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
                name: "HatKullanims");

            migrationBuilder.DropTable(
                name: "HatSatis");

            migrationBuilder.DropTable(
                name: "Ilce");

            migrationBuilder.DropTable(
                name: "Hats");

            migrationBuilder.DropTable(
                name: "Il");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "6078551d-fd7b-495c-82eb-0097339fad9b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e23863a9-f70c-4dec-a4aa-ae0506be5d68");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "afbc5076-9871-45eb-869b-43b358e8e065");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b3c17ea3-f149-4e7c-b977-825e27fc2016");
        }
    }
}
