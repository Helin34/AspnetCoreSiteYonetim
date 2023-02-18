using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aidats",
                columns: table => new
                {
                    AidatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AidatAYLAR = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aidats", x => x.AidatID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Daires",
                columns: table => new
                {
                    DaireID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlokNUMARA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaireNUMARA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaireKAT = table.Column<int>(type: "int", nullable: false),
                    DaireALAN = table.Column<int>(type: "int", nullable: false),
                    DaireACIKLAMA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daires", x => x.DaireID);
                });

            migrationBuilder.CreateTable(
                name: "Giders",
                columns: table => new
                {
                    GiderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiderTUR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiderFirma = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giders", x => x.GiderID);
                });

            migrationBuilder.CreateTable(
                name: "KiraciMalSahibis",
                columns: table => new
                {
                    KiraciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SahibID = table.Column<int>(type: "int", nullable: false),
                    KiraciADSOYAD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SahibADSOYAD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KiraciTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SahipTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SahibMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KiraciMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KiraciMalSahibis", x => x.KiraciID);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    SiteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteAD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteADRES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteISITUR = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.SiteID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aidats");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Daires");

            migrationBuilder.DropTable(
                name: "Giders");

            migrationBuilder.DropTable(
                name: "KiraciMalSahibis");

            migrationBuilder.DropTable(
                name: "Sites");
        }
    }
}
