﻿// <auto-generated />
using DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DATA.Migrations
{
    [DbContext(typeof(KitapSatisDBContext))]
    [Migration("20241107221054_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriID"));

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("Entities.Kitap", b =>
                {
                    b.Property<int>("KitapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KitapID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BasimYili")
                        .HasColumnType("int");

                    b.Property<float>("Fiyat")
                        .HasColumnType("real");

                    b.Property<string>("KapakResmi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int>("YayinEviID")
                        .HasColumnType("int");

                    b.Property<string>("Yazar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KitapID");

                    b.HasIndex("KategoriID");

                    b.HasIndex("YayinEviID");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("Entities.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KullaniciID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolID")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KullaniciID");

                    b.HasIndex("RolID");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("Entities.Rol", b =>
                {
                    b.Property<int>("RolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RolID"));

                    b.Property<string>("RolAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RolID");

                    b.ToTable("Roller");
                });

            modelBuilder.Entity("Entities.YayinEvi", b =>
                {
                    b.Property<int>("YayinEviID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YayinEviID"));

                    b.Property<string>("YayinEviAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YayinEviID");

                    b.ToTable("YayinEvleri");
                });

            modelBuilder.Entity("Entities.Kitap", b =>
                {
                    b.HasOne("Entities.Kategori", "Kategori")
                        .WithMany("Kitaplar")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.YayinEvi", "YayinEvi")
                        .WithMany("Kitaplar")
                        .HasForeignKey("YayinEviID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("YayinEvi");
                });

            modelBuilder.Entity("Entities.Kullanici", b =>
                {
                    b.HasOne("Entities.Rol", "Rol")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Entities.Kategori", b =>
                {
                    b.Navigation("Kitaplar");
                });

            modelBuilder.Entity("Entities.Rol", b =>
                {
                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("Entities.YayinEvi", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
