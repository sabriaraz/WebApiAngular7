﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonelProject.Migrations
{
    public partial class iki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sehir",
                columns: table => new
                {
                    SehirId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SehirAd = table.Column<string>(nullable: true),
                    SehirResim = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehir", x => x.SehirId);
                });

            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    PersonelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonelAd = table.Column<string>(nullable: true),
                    PersonelSoyad = table.Column<string>(nullable: true),
                    SehirId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_Personel_Sehir_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehir",
                        principalColumn: "SehirId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SehirGaleri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Yol = table.Column<string>(nullable: true),
                    SehirId = table.Column<int>(nullable: false),
                    SehiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SehirGaleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SehirGaleri_Sehir_SehiId",
                        column: x => x.SehiId,
                        principalTable: "Sehir",
                        principalColumn: "SehirId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerGaleri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Yol = table.Column<string>(nullable: true),
                    PersonelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerGaleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerGaleri_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PerGaleri_PersonelId",
                table: "PerGaleri",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_SehirId",
                table: "Personel",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_SehirGaleri_SehiId",
                table: "SehirGaleri",
                column: "SehiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerGaleri");

            migrationBuilder.DropTable(
                name: "SehirGaleri");

            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "Sehir");
        }
    }
}
