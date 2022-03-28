﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace NguyenXuanSon2022537.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220328012841_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("NguyenXuanSon2022537.Models.NXS537", b =>
                {
                    b.Property<string>("NXSID")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("NXSGender")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("NXSName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("NXSID");

                    b.ToTable("NXS537");
                });
#pragma warning restore 612, 618
        }
    }
}
