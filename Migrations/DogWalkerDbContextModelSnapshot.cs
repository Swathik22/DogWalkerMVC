﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DogWalker.Migrations
{
    [DbContext(typeof(DogWalkerDbContext))]
    partial class DogWalkerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DogGo.Models.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Breed")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Breed = "Rottweiler",
                            Name = "Ninni",
                            OwnerId = 1
                        },
                        new
                        {
                            Id = 2,
                            Breed = "Rottweiler",
                            Name = "Kuma",
                            OwnerId = 1
                        },
                        new
                        {
                            Id = 3,
                            Breed = "Greyhound",
                            Name = "Remy",
                            OwnerId = 2
                        },
                        new
                        {
                            Id = 4,
                            Breed = "Dalmation",
                            Name = "Xyla",
                            OwnerId = 3
                        },
                        new
                        {
                            Id = 5,
                            Breed = "Beagle",
                            Name = "Chewy",
                            OwnerId = 3
                        },
                        new
                        {
                            Id = 6,
                            Breed = "Dalmation",
                            Name = "Groucho",
                            OwnerId = 4
                        },
                        new
                        {
                            Id = 7,
                            Breed = "Golden Retriever",
                            Name = "Finley",
                            OwnerId = 5
                        },
                        new
                        {
                            Id = 8,
                            Breed = "Golden Retriever",
                            Name = "Casper",
                            OwnerId = 6
                        },
                        new
                        {
                            Id = 9,
                            Breed = "English Bulldog",
                            Name = "Bubba",
                            OwnerId = 7
                        },
                        new
                        {
                            Id = 10,
                            Breed = "Schnauzer",
                            Name = "Zeus",
                            OwnerId = 7
                        });
                });

            modelBuilder.Entity("DogGo.Models.Neighborhood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Neighborhoods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "East Nashville"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Antioch"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Berry Hill"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Germantown"
                        },
                        new
                        {
                            Id = 5,
                            Name = "The Gulch"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Downtown"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Music Row"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Hermitage"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Madison"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Green Hills"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Midtown"
                        },
                        new
                        {
                            Id = 12,
                            Name = "West Nashville"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Donelson"
                        },
                        new
                        {
                            Id = 14,
                            Name = "North Nashville"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Belmont-Hillsboro"
                        });
                });

            modelBuilder.Entity("DogGo.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("NeighborhoodId")
                        .HasColumnType("integer");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "355 Main St",
                            Email = "john@gmail.com",
                            Name = "John Sanchez",
                            NeighborhoodId = 1,
                            Phone = "(615)-553-2456"
                        },
                        new
                        {
                            Id = 2,
                            Address = "355 Main St",
                            Email = "patty@gmail.com",
                            Name = "Patricia Young",
                            NeighborhoodId = 2,
                            Phone = "(615)-553-2456"
                        },
                        new
                        {
                            Id = 3,
                            Address = "355 Main St",
                            Email = "robert@gmail.com",
                            Name = "Robert Brown",
                            NeighborhoodId = 3,
                            Phone = "(615)-553-2456"
                        },
                        new
                        {
                            Id = 4,
                            Address = "355 Main St",
                            Email = "jennifer@gmail.com",
                            Name = "Jennifer Wilson",
                            NeighborhoodId = 1,
                            Phone = "(615)-553-2456"
                        },
                        new
                        {
                            Id = 5,
                            Address = "355 Main St",
                            Email = "michael@gmail.com",
                            Name = "Michael Moore",
                            NeighborhoodId = 2,
                            Phone = "(615)-553-2456"
                        },
                        new
                        {
                            Id = 6,
                            Address = "355 Main St",
                            Email = "linda@gmail.com",
                            Name = "Linda Green",
                            NeighborhoodId = 3,
                            Phone = "(615)-553-2456"
                        },
                        new
                        {
                            Id = 7,
                            Address = "355 Main St",
                            Email = "william@gmail.com",
                            Name = "William Anderson",
                            NeighborhoodId = 1,
                            Phone = "(615)-553-2456"
                        });
                });

            modelBuilder.Entity("DogGo.Models.Walk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DogId")
                        .HasColumnType("integer");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<int>("WalkerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DogId");

                    b.HasIndex("WalkerId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("DogGo.Models.Walker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("NeighborhoodId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("NeighborhoodId");

                    b.ToTable("Walkers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Claudelle",
                            NeighborhoodId = 15
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Roi",
                            NeighborhoodId = 9
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Shena",
                            NeighborhoodId = 10
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Gibb",
                            NeighborhoodId = 8
                        },
                        new
                        {
                            Id = 5,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Tammy",
                            NeighborhoodId = 6
                        },
                        new
                        {
                            Id = 6,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Rufe",
                            NeighborhoodId = 11
                        },
                        new
                        {
                            Id = 7,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Cassandry",
                            NeighborhoodId = 12
                        },
                        new
                        {
                            Id = 8,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Cully",
                            NeighborhoodId = 4
                        },
                        new
                        {
                            Id = 9,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Cully",
                            NeighborhoodId = 14
                        },
                        new
                        {
                            Id = 10,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Agnesse",
                            NeighborhoodId = 1
                        },
                        new
                        {
                            Id = 11,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Koo",
                            NeighborhoodId = 7
                        },
                        new
                        {
                            Id = 12,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Diana",
                            NeighborhoodId = 6
                        },
                        new
                        {
                            Id = 13,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Moreen",
                            NeighborhoodId = 7
                        },
                        new
                        {
                            Id = 14,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Sonni",
                            NeighborhoodId = 13
                        },
                        new
                        {
                            Id = 15,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Nadiya",
                            NeighborhoodId = 9
                        },
                        new
                        {
                            Id = 16,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Olag",
                            NeighborhoodId = 12
                        },
                        new
                        {
                            Id = 17,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Alasdair",
                            NeighborhoodId = 12
                        },
                        new
                        {
                            Id = 18,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Jo ann",
                            NeighborhoodId = 12
                        },
                        new
                        {
                            Id = 19,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Ewen",
                            NeighborhoodId = 6
                        },
                        new
                        {
                            Id = 20,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Andee",
                            NeighborhoodId = 5
                        },
                        new
                        {
                            Id = 21,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Sada",
                            NeighborhoodId = 12
                        },
                        new
                        {
                            Id = 22,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Tasia",
                            NeighborhoodId = 3
                        },
                        new
                        {
                            Id = 23,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Sherry",
                            NeighborhoodId = 5
                        },
                        new
                        {
                            Id = 24,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Witty",
                            NeighborhoodId = 6
                        },
                        new
                        {
                            Id = 25,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Ezekiel",
                            NeighborhoodId = 5
                        },
                        new
                        {
                            Id = 26,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Emmeline",
                            NeighborhoodId = 1
                        },
                        new
                        {
                            Id = 27,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Darrick",
                            NeighborhoodId = 9
                        },
                        new
                        {
                            Id = 28,
                            ImageUrl = "https://avatars.dicebear.com/v2/female/c117aa483c649ecbc46c6d65172bf6e6.svg",
                            Name = "Redford",
                            NeighborhoodId = 14
                        });
                });

            modelBuilder.Entity("DogGo.Models.Dog", b =>
                {
                    b.HasOne("DogGo.Models.Owner", "DogOwner")
                        .WithMany("Dogs")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DogOwner");
                });

            modelBuilder.Entity("DogGo.Models.Walk", b =>
                {
                    b.HasOne("DogGo.Models.Dog", "Dog")
                        .WithMany()
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogGo.Models.Walker", "Walker")
                        .WithMany()
                        .HasForeignKey("WalkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dog");

                    b.Navigation("Walker");
                });

            modelBuilder.Entity("DogGo.Models.Walker", b =>
                {
                    b.HasOne("DogGo.Models.Neighborhood", "Neighborhood")
                        .WithMany()
                        .HasForeignKey("NeighborhoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Neighborhood");
                });

            modelBuilder.Entity("DogGo.Models.Owner", b =>
                {
                    b.Navigation("Dogs");
                });
#pragma warning restore 612, 618
        }
    }
}
