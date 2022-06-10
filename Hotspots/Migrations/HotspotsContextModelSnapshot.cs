﻿// <auto-generated />
using Hotspots.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hotspots.Migrations
{
    [DbContext(typeof(HotspotsContext))]
    partial class HotspotsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Hotspots.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Cuisine")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Blackburn",
                            Cuisine = "Brunch",
                            Name = "Battle Cafe"
                        },
                        new
                        {
                            Id = 2,
                            City = "Melbourne",
                            Cuisine = "Brunch",
                            Name = "Higher Ground"
                        },
                        new
                        {
                            Id = 3,
                            City = "Fitzroy",
                            Cuisine = "Modern Fine",
                            Name = "Marion"
                        },
                        new
                        {
                            Id = 4,
                            City = "Collingwood",
                            Cuisine = "Brunch",
                            Name = "Terror Twilight"
                        },
                        new
                        {
                            Id = 5,
                            City = "Melbourne",
                            Cuisine = "Modern Fine",
                            Name = "Embla"
                        },
                        new
                        {
                            Id = 6,
                            City = "Collingwood",
                            Cuisine = "Modern Fine",
                            Name = "Bar Liberty"
                        },
                        new
                        {
                            Id = 7,
                            City = "Melbourne",
                            Cuisine = "Bar/Tapas",
                            Name = "Peaches"
                        },
                        new
                        {
                            Id = 8,
                            City = "Melbourne",
                            Cuisine = "Bar/Thai",
                            Name = "Cookie"
                        },
                        new
                        {
                            Id = 9,
                            City = "Sydney",
                            Cuisine = "Thai",
                            Name = "Holy Basil"
                        },
                        new
                        {
                            Id = 10,
                            City = "Sydney",
                            Cuisine = "Chicken Shop",
                            Name = "El Jannah"
                        },
                        new
                        {
                            Id = 11,
                            City = "Richmond",
                            Cuisine = "Sandwiches",
                            Name = "Hectors Deli"
                        },
                        new
                        {
                            Id = 12,
                            City = "Collingwood",
                            Cuisine = "Vegan/Pizza",
                            Name = "Red Sparrow Pizza"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
