﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieCatalog.DataAccess;

namespace MovieCatalog.DataAccess.Migrations
{
    [DbContext(typeof(MovieCatalogDbContext))]
    partial class MovieCatalogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MovieCatalog.Domain.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GenreType")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreType = 2
                        },
                        new
                        {
                            Id = 2,
                            GenreType = 6
                        },
                        new
                        {
                            Id = 3,
                            GenreType = 1
                        });
                });

            modelBuilder.Entity("MovieCatalog.Domain.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A man with short-term memory loss attempts to track down his wife's murderer.",
                            ReleaseDate = new DateTime(2001, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Memento"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                            ReleaseDate = new DateTime(1994, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pulp Fiction"
                        },
                        new
                        {
                            Id = 3,
                            Description = "After being kidnapped and imprisoned for fifteen years, Oh Dae-Su is released, only to find that he must find his captor in five days.",
                            ReleaseDate = new DateTime(2003, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Oldboy"
                        });
                });

            modelBuilder.Entity("MovieCatalog.Domain.Models.MovieGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieGenre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            Id = 2,
                            GenreId = 2,
                            MovieId = 2
                        },
                        new
                        {
                            Id = 3,
                            GenreId = 3,
                            MovieId = 3
                        });
                });

            modelBuilder.Entity("MovieCatalog.Domain.Models.MoviePerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("PersonId");

                    b.ToTable("MoviePeople");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieId = 1,
                            PersonId = 1
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 2,
                            PersonId = 2
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 3,
                            PersonId = 3
                        });
                });

            modelBuilder.Entity("MovieCatalog.Domain.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Biography")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 29,
                            Biography = "asdasdasda",
                            FirstName = "Jon",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            Age = 29,
                            Biography = "asdasdasda",
                            FirstName = "Jane",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 3,
                            Age = 29,
                            Biography = "asdasdasda",
                            FirstName = "Yo",
                            LastName = "What up"
                        });
                });

            modelBuilder.Entity("MovieCatalog.Domain.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("RoleType")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PersonId = 1,
                            RoleType = 1
                        },
                        new
                        {
                            Id = 2,
                            PersonId = 2,
                            RoleType = 2
                        },
                        new
                        {
                            Id = 3,
                            PersonId = 1,
                            RoleType = 1
                        },
                        new
                        {
                            Id = 4,
                            PersonId = 2,
                            RoleType = 3
                        });
                });

            modelBuilder.Entity("MovieCatalog.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FavoriteGenre")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Street 01",
                            FavoriteGenre = 2,
                            FirstName = "Pero",
                            LastName = "Blazevski",
                            Username = "Pero123"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Street 02",
                            FavoriteGenre = 2,
                            FirstName = "Blazo",
                            LastName = "Ristovski",
                            Username = "Blazo123"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Street 04",
                            FavoriteGenre = 1,
                            FirstName = "User4",
                            LastName = "4ski",
                            Username = "4-123"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Street 05",
                            FavoriteGenre = 4,
                            FirstName = "User5",
                            LastName = "5ski",
                            Username = "1235"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Street 03",
                            FavoriteGenre = 3,
                            FirstName = "Risto",
                            LastName = "Petkovski",
                            Username = "Risto123"
                        });
                });

            modelBuilder.Entity("MovieCatalog.Domain.Models.MovieGenre", b =>
                {
                    b.HasOne("MovieCatalog.Domain.Models.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieCatalog.Domain.Models.Movie", "Movie")
                        .WithMany("Genre")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieCatalog.Domain.Models.MoviePerson", b =>
                {
                    b.HasOne("MovieCatalog.Domain.Models.Movie", "Movie")
                        .WithMany("MoviePeople")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieCatalog.Domain.Models.Person", "Person")
                        .WithMany("Movies")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("MovieCatalog.Domain.Models.Role", b =>
                {
                    b.HasOne("MovieCatalog.Domain.Models.Person", "Person")
                        .WithMany("Roles")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("MovieCatalog.Domain.Models.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("MovieCatalog.Domain.Models.Movie", b =>
                {
                    b.Navigation("Genre");

                    b.Navigation("MoviePeople");
                });

            modelBuilder.Entity("MovieCatalog.Domain.Models.Person", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
