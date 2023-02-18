using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilgi_Sites_SiteID",
                table: "Bilgi");

            migrationBuilder.DropIndex(
                name: "IX_Bilgi_SiteID",
                table: "Bilgi");

            migrationBuilder.DropColumn(
                name: "SiteID",
                table: "Bilgi");

            migrationBuilder.AddColumn<int>(
                name: "BilgiID",
                table: "Sites",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Sites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sites_BilgiID",
                table: "Sites",
                column: "BilgiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sites_Bilgi_BilgiID",
                table: "Sites",
                column: "BilgiID",
                principalTable: "Bilgi",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sites_Bilgi_BilgiID",
                table: "Sites");

            migrationBuilder.DropIndex(
                name: "IX_Sites_BilgiID",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "BilgiID",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Sites");

            migrationBuilder.AddColumn<int>(
                name: "SiteID",
                table: "Bilgi",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bilgi_SiteID",
                table: "Bilgi",
                column: "SiteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bilgi_Sites_SiteID",
                table: "Bilgi",
                column: "SiteID",
                principalTable: "Sites",
                principalColumn: "SiteID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
