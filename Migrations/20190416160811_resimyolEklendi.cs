using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonelProject.Migrations
{
    public partial class resimyolEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PersonelResimYol",
                table: "Personel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonelResimYol",
                table: "Personel");
        }
    }
}
