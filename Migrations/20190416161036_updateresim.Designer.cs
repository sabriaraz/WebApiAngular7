﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonelProject.Data;

namespace PersonelProject.Migrations
{
    [DbContext(typeof(PersonelContext))]
    [Migration("20190416161036_updateresim")]
    partial class updateresim
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PersonelProject.Entities.PerGaleri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonelId");

                    b.Property<string>("Yol");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.ToTable("PerGaleri");
                });

            modelBuilder.Entity("PersonelProject.Entities.Personel", b =>
                {
                    b.Property<int>("PersonelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PersonelAd");

                    b.Property<string>("PersonelSoyad");

                    b.Property<string>("ResimYol");

                    b.Property<int>("SehirId");

                    b.HasKey("PersonelId");

                    b.HasIndex("SehirId");

                    b.ToTable("Personel");
                });

            modelBuilder.Entity("PersonelProject.Entities.Sehir", b =>
                {
                    b.Property<int>("SehirId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ResimYol");

                    b.Property<string>("SehirAd");

                    b.HasKey("SehirId");

                    b.ToTable("Sehir");
                });

            modelBuilder.Entity("PersonelProject.Entities.SehirGaleri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SehirId");

                    b.Property<string>("Yol");

                    b.HasKey("Id");

                    b.HasIndex("SehirId");

                    b.ToTable("SehirGaleri");
                });

            modelBuilder.Entity("PersonelProject.Entities.PerGaleri", b =>
                {
                    b.HasOne("PersonelProject.Entities.Personel", "Personel")
                        .WithMany("PersGaleri")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PersonelProject.Entities.Personel", b =>
                {
                    b.HasOne("PersonelProject.Entities.Sehir", "Sehir")
                        .WithMany("Personel")
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PersonelProject.Entities.SehirGaleri", b =>
                {
                    b.HasOne("PersonelProject.Entities.Sehir", "Sehir")
                        .WithMany("SehirGaleri")
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
