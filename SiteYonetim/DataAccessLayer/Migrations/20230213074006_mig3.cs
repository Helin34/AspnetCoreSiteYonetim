using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DaireID",
                table: "KiraciMalSahibis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteID",
                table: "Daires",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DaireID",
                table: "Aidats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_KiraciMalSahibis_DaireID",
                table: "KiraciMalSahibis",
                column: "DaireID");

            migrationBuilder.CreateIndex(
                name: "IX_Daires_SiteID",
                table: "Daires",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Aidats_DaireID",
                table: "Aidats",
                column: "DaireID");

            migrationBuilder.AddForeignKey(
                name: "FK_Aidats_Daires_DaireID",
                table: "Aidats",
                column: "DaireID",
                principalTable: "Daires",
                principalColumn: "DaireID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Daires_Sites_SiteID",
                table: "Daires",
                column: "SiteID",
                principalTable: "Sites",
                principalColumn: "SiteID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KiraciMalSahibis_Daires_DaireID",
                table: "KiraciMalSahibis",
                column: "DaireID",
                principalTable: "Daires",
                principalColumn: "DaireID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aidats_Daires_DaireID",
                table: "Aidats");

            migrationBuilder.DropForeignKey(
                name: "FK_Daires_Sites_SiteID",
                table: "Daires");

            migrationBuilder.DropForeignKey(
                name: "FK_KiraciMalSahibis_Daires_DaireID",
                table: "KiraciMalSahibis");

            migrationBuilder.DropIndex(
                name: "IX_KiraciMalSahibis_DaireID",
                table: "KiraciMalSahibis");

            migrationBuilder.DropIndex(
                name: "IX_Daires_SiteID",
                table: "Daires");

            migrationBuilder.DropIndex(
                name: "IX_Aidats_DaireID",
                table: "Aidats");

            migrationBuilder.DropColumn(
                name: "DaireID",
                table: "KiraciMalSahibis");

            migrationBuilder.DropColumn(
                name: "SiteID",
                table: "Daires");

            migrationBuilder.DropColumn(
                name: "DaireID",
                table: "Aidats");
        }
    }
}
