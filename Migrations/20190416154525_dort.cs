using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonelProject.Migrations
{
    public partial class dort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SehirGaleri_Sehir_SehiId",
                table: "SehirGaleri");

            migrationBuilder.DropIndex(
                name: "IX_SehirGaleri_SehiId",
                table: "SehirGaleri");

            migrationBuilder.DropColumn(
                name: "SehiId",
                table: "SehirGaleri");

            migrationBuilder.CreateIndex(
                name: "IX_SehirGaleri_SehirId",
                table: "SehirGaleri",
                column: "SehirId");

            migrationBuilder.AddForeignKey(
                name: "FK_SehirGaleri_Sehir_SehirId",
                table: "SehirGaleri",
                column: "SehirId",
                principalTable: "Sehir",
                principalColumn: "SehirId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SehirGaleri_Sehir_SehirId",
                table: "SehirGaleri");

            migrationBuilder.DropIndex(
                name: "IX_SehirGaleri_SehirId",
                table: "SehirGaleri");

            migrationBuilder.AddColumn<int>(
                name: "SehiId",
                table: "SehirGaleri",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SehirGaleri_SehiId",
                table: "SehirGaleri",
                column: "SehiId");

            migrationBuilder.AddForeignKey(
                name: "FK_SehirGaleri_Sehir_SehiId",
                table: "SehirGaleri",
                column: "SehiId",
                principalTable: "Sehir",
                principalColumn: "SehirId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
