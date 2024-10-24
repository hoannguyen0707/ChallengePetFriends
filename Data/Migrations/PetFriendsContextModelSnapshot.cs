﻿// <auto-generated />
using System;
using ChallengePetFriends.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChallengePetFriends.API.Data.Migrations
{
    [DbContext(typeof(PetFriendsContext))]
    partial class PetFriendsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1");

            modelBuilder.Entity("ChallengePetFriends.API.Entities.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("JoinedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonalityDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhysicalDescription")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Species")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 3,
                            JoinedDate = new DateOnly(2024, 1, 15),
                            Name = "Buddy",
                            PersonalityDescription = "Friendly and energetic",
                            PhysicalDescription = "Small, brown with white spots",
                            Price = 250.00m,
                            Species = "Dog"
                        },
                        new
                        {
                            Id = 2,
                            Age = 2,
                            JoinedDate = new DateOnly(2024, 2, 20),
                            Name = "Mittens",
                            PersonalityDescription = "Playful and curious",
                            PhysicalDescription = "Black with green eyes",
                            Price = 150.00m,
                            Species = "Cat"
                        },
                        new
                        {
                            Id = 3,
                            Age = 5,
                            JoinedDate = new DateOnly(2024, 3, 13),
                            Name = "Charlie",
                            PersonalityDescription = "Talkative and social",
                            PhysicalDescription = "Green feathers with red tail",
                            Price = 300.55m,
                            Species = "Parrot"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}