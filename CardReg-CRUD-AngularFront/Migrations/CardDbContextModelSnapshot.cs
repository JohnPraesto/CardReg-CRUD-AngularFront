﻿// <auto-generated />
using System;
using CardReg_CRUD_AngularFront.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CardReg_CRUD_AngularFront.Migrations
{
    [DbContext(typeof(CardDbContext))]
    partial class CardDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CardReg_CRUD_AngularFront.Models.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CVC")
                        .HasColumnType("int");

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpireMonth")
                        .HasColumnType("int");

                    b.Property<int>("ExpireYear")
                        .HasColumnType("int");

                    b.Property<string>("HolderName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = new Guid("808b4920-c29b-48c1-b8a9-a13e85d23c7e"),
                            CVC = 123,
                            CardNumber = "12345678910111213",
                            ExpireMonth = 1,
                            ExpireYear = 2025,
                            HolderName = "Card Holder One"
                        },
                        new
                        {
                            Id = new Guid("f6178836-eb0c-49fb-ad6b-304a6f6145c1"),
                            CVC = 456,
                            CardNumber = "42345678910111214",
                            ExpireMonth = 2,
                            ExpireYear = 2022,
                            HolderName = "Card Holder Two"
                        },
                        new
                        {
                            Id = new Guid("86a58489-5bb3-4720-beb1-a1a9694c4bec"),
                            CVC = 789,
                            CardNumber = "52345678910111215",
                            ExpireMonth = 3,
                            ExpireYear = 2027,
                            HolderName = "Card Holder Three"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
