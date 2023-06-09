﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFirstDemo.Api.Data;

#nullable disable

namespace MyFirstDemo.Api.Migrations
{
    [DbContext(typeof(NZWalksDbContext))]
    [Migration("20230419065344_Seeding data")]
    partial class Seedingdata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyFirstDemo.Api.Models.Domain.Difficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3e1d541b-a205-429e-bb56-f50cecb2c9df"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("17b5b9e7-cf76-49a3-9f62-eba81363082b"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("2ae1794c-360e-4365-bd1d-3509875e9c6e"),
                            Name = "Hard"
                        });
                });

            modelBuilder.Entity("MyFirstDemo.Api.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("78f28f34-abd5-4686-8a7b-fba4ce2fc8e4"),
                            Code = "AKL",
                            Name = "Auckland",
                            RegionImageUrl = "Auckland.jpg"
                        },
                        new
                        {
                            Id = new Guid("6457b92f-6269-48ed-88e6-8740ceccb5c2"),
                            Code = "BOP",
                            Name = "Bay of Plenty"
                        },
                        new
                        {
                            Id = new Guid("fea2520a-c78a-4b40-8b28-c6b1f11a2331"),
                            Code = "WGN",
                            Name = "Wellington"
                        },
                        new
                        {
                            Id = new Guid("2ea3adbf-201a-4019-8726-44e873309375"),
                            Code = "STL",
                            Name = "SouthLand",
                            RegionImageUrl = "SouthLand.png"
                        });
                });

            modelBuilder.Entity("MyFirstDemo.Api.Models.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalkImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("MyFirstDemo.Api.Models.Domain.Walk", b =>
                {
                    b.HasOne("MyFirstDemo.Api.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFirstDemo.Api.Models.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
