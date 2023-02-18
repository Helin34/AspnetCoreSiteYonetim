﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230217192600_mig_relation")]
    partial class mig_relation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Aidat", b =>
                {
                    b.Property<int>("AidatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AidatAYLAR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DaireID")
                        .HasColumnType("int");

                    b.HasKey("AidatID");

                    b.HasIndex("DaireID");

                    b.ToTable("Aidats");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Bilgi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AidatID")
                        .HasColumnType("int");

                    b.Property<int?>("DaireID")
                        .HasColumnType("int");

                    b.Property<string>("EvSahibiMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EvSahibiName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EvSahibiPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GiderID")
                        .HasColumnType("int");

                    b.Property<string>("KiraciMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KiraciMalSahibiKiraciID")
                        .HasColumnType("int");

                    b.Property<string>("KiraciName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KiraciPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SiteID")
                        .HasColumnType("int");

                    b.Property<string>("YoneticiMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YoneticiName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YoneticiPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AidatID");

                    b.HasIndex("DaireID");

                    b.HasIndex("GiderID");

                    b.HasIndex("KiraciMalSahibiKiraciID");

                    b.HasIndex("SiteID");

                    b.ToTable("Bilgi");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("bit");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Daire", b =>
                {
                    b.Property<int>("DaireID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlokNUMARA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DaireACIKLAMA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DaireALAN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DaireImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DaireKAT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DaireNUMARA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SiteID")
                        .HasColumnType("int");

                    b.HasKey("DaireID");

                    b.HasIndex("SiteID");

                    b.ToTable("Daires");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Gider", b =>
                {
                    b.Property<int>("GiderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GiderFirma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GiderTUR")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GiderID");

                    b.ToTable("Giders");
                });

            modelBuilder.Entity("EntityLayer.Concrete.KiraciMalSahibi", b =>
                {
                    b.Property<int>("KiraciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DaireID")
                        .HasColumnType("int");

                    b.Property<string>("KiraciADSOYAD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KiraciMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KiraciTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SahibADSOYAD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SahibID")
                        .HasColumnType("int");

                    b.Property<string>("SahibMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SahipTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KiraciID");

                    b.HasIndex("DaireID");

                    b.ToTable("KiraciMalSahibis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Site", b =>
                {
                    b.Property<int>("SiteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("SiteAD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteADRES")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteISITUR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SiteID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Aidat", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Daire", "Daire")
                        .WithMany("Aidats")
                        .HasForeignKey("DaireID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Daire");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Bilgi", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Aidat", "Aidat")
                        .WithMany("Bilgis")
                        .HasForeignKey("AidatID");

                    b.HasOne("EntityLayer.Concrete.Daire", "Daire")
                        .WithMany("Bilgis")
                        .HasForeignKey("DaireID");

                    b.HasOne("EntityLayer.Concrete.Gider", "Gider")
                        .WithMany("Bilgis")
                        .HasForeignKey("GiderID");

                    b.HasOne("EntityLayer.Concrete.KiraciMalSahibi", "KiraciMalSahibi")
                        .WithMany("Bilgis")
                        .HasForeignKey("KiraciMalSahibiKiraciID");

                    b.HasOne("EntityLayer.Concrete.Site", "Site")
                        .WithMany("Bilgis")
                        .HasForeignKey("SiteID");

                    b.Navigation("Aidat");

                    b.Navigation("Daire");

                    b.Navigation("Gider");

                    b.Navigation("KiraciMalSahibi");

                    b.Navigation("Site");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Daire", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Site");
                });

            modelBuilder.Entity("EntityLayer.Concrete.KiraciMalSahibi", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Daire", "Daire")
                        .WithMany("KiraciMalSahibis")
                        .HasForeignKey("DaireID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Daire");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Site", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Sites")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Aidat", b =>
                {
                    b.Navigation("Bilgis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("Sites");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Daire", b =>
                {
                    b.Navigation("Aidats");

                    b.Navigation("Bilgis");

                    b.Navigation("KiraciMalSahibis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Gider", b =>
                {
                    b.Navigation("Bilgis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.KiraciMalSahibi", b =>
                {
                    b.Navigation("Bilgis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Site", b =>
                {
                    b.Navigation("Bilgis");
                });
#pragma warning restore 612, 618
        }
    }
}
