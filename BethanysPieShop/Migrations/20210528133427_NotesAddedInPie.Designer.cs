﻿// <auto-generated />
using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BethanysPieShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210528133427_NotesAddedInPie")]
    partial class NotesAddedInPie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BethanysPieShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Fruit Pies"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Cheesse Cakes"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Seasonal Pies"
                        });
                });

            modelBuilder.Entity("BethanysPieShop.Models.Pie", b =>
                {
                    b.Property<int>("PieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllergyInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPieOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Pies");

                    b.HasData(
                        new
                        {
                            PieId = 1,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth",
                            Name = "Apple Pie",
                            Price = 12.95m,
                            ShortDescription = "Our Famous Apple Pies"
                        },
                        new
                        {
                            PieId = 2,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth",
                            Name = "Blue Berry Cheesse cakes",
                            Price = 12.95m,
                            ShortDescription = "Cheesseyest Cheesse cake"
                        },
                        new
                        {
                            PieId = 3,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth",
                            Name = "Cheesse cakes",
                            Price = 12.95m,
                            ShortDescription = "Cheesseyest Cheesse cake"
                        },
                        new
                        {
                            PieId = 4,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth",
                            Name = "Winter cakes",
                            Price = 12.95m,
                            ShortDescription = "Seasons Pie"
                        },
                        new
                        {
                            PieId = 5,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth",
                            Name = "4 Season Pie cakes",
                            Price = 12.95m,
                            ShortDescription = "Seasons Pie"
                        });
                });

            modelBuilder.Entity("BethanysPieShop.Models.Pie", b =>
                {
                    b.HasOne("BethanysPieShop.Models.Category", "Category")
                        .WithMany("Pies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
