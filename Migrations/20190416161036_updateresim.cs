using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonelProject.Migrations
{
    public partial class updateresim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SehirResim",
                table: "Sehir",
                newName: "ResimYol");

            migrationBuilder.RenameColumn(
                name: "PersonelResimYol",
                table: "Personel",
                newName: "ResimYol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResimYol",
                table: "Sehir",
                newName: "SehirResim");

            migrationBuilder.RenameColumn(
                name: "ResimYol",
                table: "Personel",
                newName: "PersonelResimYol");
        }
    }
}
