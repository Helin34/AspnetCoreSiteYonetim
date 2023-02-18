using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Sites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sites_CategoryID",
                table: "Sites",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sites_Categories_CategoryID",
                table: "Sites",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sites_Categories_CategoryID",
                table: "Sites");

            migrationBuilder.DropIndex(
                name: "IX_Sites_CategoryID",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Sites");
        }
    }
}
