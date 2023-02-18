using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class bil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Yonetici",
                table: "Bilgi",
                newName: "YoneticiPassword");

            migrationBuilder.RenameColumn(
                name: "Kiraci",
                table: "Bilgi",
                newName: "YoneticiName");

            migrationBuilder.RenameColumn(
                name: "EvSahibi",
                table: "Bilgi",
                newName: "YoneticiMail");

            migrationBuilder.AddColumn<string>(
                name: "EvSahibiMail",
                table: "Bilgi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvSahibiName",
                table: "Bilgi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvSahibiPassword",
                table: "Bilgi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KiraciMail",
                table: "Bilgi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KiraciName",
                table: "Bilgi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KiraciPassword",
                table: "Bilgi",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EvSahibiMail",
                table: "Bilgi");

            migrationBuilder.DropColumn(
                name: "EvSahibiName",
                table: "Bilgi");

            migrationBuilder.DropColumn(
                name: "EvSahibiPassword",
                table: "Bilgi");

            migrationBuilder.DropColumn(
                name: "KiraciMail",
                table: "Bilgi");

            migrationBuilder.DropColumn(
                name: "KiraciName",
                table: "Bilgi");

            migrationBuilder.DropColumn(
                name: "KiraciPassword",
                table: "Bilgi");

            migrationBuilder.RenameColumn(
                name: "YoneticiPassword",
                table: "Bilgi",
                newName: "Yonetici");

            migrationBuilder.RenameColumn(
                name: "YoneticiName",
                table: "Bilgi",
                newName: "Kiraci");

            migrationBuilder.RenameColumn(
                name: "YoneticiMail",
                table: "Bilgi",
                newName: "EvSahibi");
        }
    }
}
