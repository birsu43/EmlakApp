﻿// <auto-generated />
using Emlak.App;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Emlak.App.Migrations
{
    [DbContext(typeof(EvContext))]
    [Migration("20230103071425_InıtDB")]
    partial class InıtDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Emlak.App.Ev", b =>
                {
                    b.Property<int>("EvId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Depozito")
                        .HasColumnType("real");

                    b.Property<float>("Fiyat")
                        .HasColumnType("real");

                    b.Property<float>("MetreKare")
                        .HasColumnType("real");

                    b.Property<int>("OdaSayi")
                        .HasColumnType("int");

                    b.Property<string>("Semt")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("EvId");

                    b.ToTable("tblEv");
                });
#pragma warning restore 612, 618
        }
    }
}
