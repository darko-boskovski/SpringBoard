using Microsoft.EntityFrameworkCore;
using MovieCatalog.Domain.Models;
using MovieCatalog.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.DataAccess
{
    public class MovieCatalogDbContext : DbContext
    {
        public MovieCatalogDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<User>()
               .Property(x => x.FirstName)
               .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(x => x.LastName)
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
               .Property(x => x.Username)
               .HasMaxLength(50)
               .IsRequired();
            modelBuilder.Entity<User>()
               .Property(x => x.Address)
                .HasMaxLength(150);
            modelBuilder.Entity<User>()
                .Property(x => x.FavoriteGenre);
            modelBuilder.Entity<User>()
               .Ignore(x => x.Age);



            modelBuilder.Entity<Person>()
    .Property(x => x.FirstName)
     .HasMaxLength(50);
            modelBuilder.Entity<Person>()
                .Property(x => x.LastName)
                .HasMaxLength(50);
            modelBuilder.Entity<Person>()
               .Property(x => x.Age)
               .HasMaxLength(10);
            modelBuilder.Entity<Person>()
               .Property(x => x.Biography)
               .HasMaxLength(100);


            modelBuilder.Entity<MoviePerson>()
               .HasOne(x => x.Person)
               .WithMany(x => x.Movies)
               .HasForeignKey(x => x.PersonId);
            modelBuilder.Entity<MoviePerson>()
              .HasOne(x => x.Movie)
              .WithMany(x => x.MoviePeople)
              .HasForeignKey(x => x.MovieId);


            modelBuilder.Entity<Movie>()
              .Property(x => x.Id)
              .HasMaxLength(10);
            modelBuilder.Entity<Movie>()
                .Property(x => x.Title)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .Property(x => x.Description)
                .HasMaxLength(300);
            modelBuilder.Entity<Movie>()
                .Property(x => x.ReleaseDate)
                .HasMaxLength(10);
            modelBuilder.Entity<Movie>()
                .HasOne(x => x.User)
                .WithMany(x => x.Movies)
                .HasForeignKey(x => x.UserId);




            modelBuilder.Entity<Role>()
                .Property(x => x.RoleType)
                .HasMaxLength(10);
            modelBuilder.Entity<Role>()
              .HasOne(x => x.Person)
              .WithMany(x => x.Roles)
              .HasForeignKey(x => x.PersonId);


            modelBuilder.Entity<Genre>()
                .Property(x => x.GenreType)
                .HasMaxLength(10);
            modelBuilder.Entity<Genre>()
                .HasOne(x => x.Movie)
                .WithMany(x => x.Genres)
                .HasForeignKey(x => x.MovieId);


            modelBuilder.Entity<User>()
            .HasData(
            new User()
            {
                Id = 1,
                FirstName = "Pero",
                LastName = "Blazevski",
                Username = "Pero123",
                Address = "Street 01",
                Age = 28,
                FavoriteGenre = EnumGenre.Action,



            },
            new User()
            {
                Id = 2,
                FirstName = "Blazo",
                LastName = "Ristovski",
                Username = "Blazo123",
                Address = "Street 02",
                Age = 35,
                FavoriteGenre = EnumGenre.Action,


            },
             new User()
             {
                 Id = 4,
                 FirstName = "User4",
                 LastName = "4ski",
                 Username = "4-123",
                 Address = "Street 04",
                 Age = 30,
                 FavoriteGenre = EnumGenre.Comedy,


             },
             new User()
             {
                 Id = 5,
                 FirstName = "User5",
                 LastName = "5ski",
                 Username = "1235",
                 Address = "Street 05",
                 Age = 25,
                 FavoriteGenre = EnumGenre.Drama,

             },
             new User()
             {
                 Id = 3,
                 FirstName = "Risto",
                 LastName = "Petkovski",
                 Username = "Risto123",
                 Address = "Street 03",
                 Age = 25,
                 FavoriteGenre = EnumGenre.Sci_fi,

             });


            modelBuilder.Entity<Person>()
                .HasData(
                new Person()
                {
                    Id = 1,
                    Age = 29,
                    Biography = "asdasdasda",
                    FirstName = "Jon",
                    LastName = "Doe",

                }, new Person()
                {
                    Id = 2,
                    Age = 29,
                    Biography = "asdasdasda",
                    FirstName = "Jane",
                    LastName = "Doe",

                }, new Person()
                {
                    Id = 3,
                    Age = 29,
                    Biography = "asdasdasda",
                    FirstName = "Yo",
                    LastName = "What up",

                });

            modelBuilder.Entity<MoviePerson>()
                .HasData(
                   new MoviePerson()
                   {
                       Id = 1,
                       PersonId = 1,
                       MovieId = 1,

                   }, new MoviePerson()
                   {
                       Id = 2,
                       PersonId = 2,
                       MovieId = 2,

                   }, new MoviePerson()
                   {
                       Id = 3,
                       PersonId = 3,
                       MovieId = 3,

                   });


            modelBuilder.Entity<Genre>()
             .HasData(
                     new Genre()
                     {
                         Id = 1,
                         GenreType = EnumGenre.Action,
                         MovieId = 1,



                     },
                     new Genre()
                     {
                         Id = 2,
                         GenreType = EnumGenre.Mystery,
                         MovieId = 2,


                     },
                      new Genre()
                      {
                          Id = 3,
                          GenreType = EnumGenre.Comedy,
                          MovieId = 1,


                      });

            modelBuilder.Entity<Role>()
                        .HasData(
                     new Role()
                     {
                         Id = 1,
                         RoleType = EnumRole.Actor,
                         PersonId = 1,

                     },
                      new Role()
                      {
                          Id = 2,
                          RoleType = EnumRole.Director,
                          PersonId = 2,

                      },
                       new Role()
                       {
                           Id = 3,
                           RoleType = EnumRole.Actor,
                           PersonId = 1,

                       },
                      new Role()
                      {
                          Id = 4,
                          RoleType = EnumRole.Producer,
                          PersonId = 2,

                      });







            modelBuilder.Entity<Movie>()
          .HasData(
                new Movie()
                {
                    Id = 1,
                    Title = "Memento",
                    Description = "A man with short-term memory loss attempts to track down his wife's murderer.",
                    ReleaseDate = DateTime.Parse("May 25, 2001"),
                    Genres = new List<Genre>(),
                    MoviePeople = new List<MoviePerson>(),
                    UserId = 1,


                },
               new Movie()
               {
                   Id = 2,
                   Title = "Pulp Fiction",
                   Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                   ReleaseDate = DateTime.Parse("apr 25, 1994"),
                   Genres = new List<Genre>(),
                   MoviePeople = new List<MoviePerson>(),
                   UserId = 2,
               },
                new Movie()
                {
                    Id = 3,
                    Title = "Oldboy",
                    Description = "After being kidnapped and imprisoned for fifteen years, Oh Dae-Su is released, only to find that he must find his captor in five days.",
                    ReleaseDate = DateTime.Parse("Jan 25, 2003"),
                    Genres = new List<Genre>(),
                    MoviePeople = new List<MoviePerson>(),
                    UserId = 3,

                });





        }
    }
}
