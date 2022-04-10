using MovieCatalog.Domain.Models;
using MovieCatalog.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Mappers
{
    public static class MovieMapper
    {
        public static Movie ToMovie(this MovieViewModel movieModel)
        {
            return new Movie
            {
                Id = movieModel.Id,
                Title = movieModel.Title,
                Description = movieModel.Description,
                ReleaseDate = movieModel.ReleaseDate.Date,
                UserId = movieModel.UserId,

            };
        }

        public static MovieViewModel ToMovieModel(this Movie movie)
        {

            return new MovieViewModel
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                ReleaseDate = movie.ReleaseDate.Date,
                UserId = movie.UserId,
                User = movie.User

            };
        }


        public static Movie MapMovie(Movie movie, MovieViewModel movieModel, User user)
        {


            movieModel.Cast = new List<string>();
            foreach (var item in movieModel.MoviePeople)
            {
                movieModel.Cast.Add(item.Person.FirstName + " " + item.Person.LastName);
            }

            movie.Title = movieModel.Title;
            movie.Description = movieModel.Description;
            movie.ReleaseDate = movieModel.ReleaseDate.Date;
            foreach (var item in movieModel.Genres)
            {
                movie.Genres.Add(item);
            }
            movie.UserId = movieModel.UserId;
            movie.User = user;
            foreach (var item in movieModel.MoviePeople)
            {
                movie.MoviePeople.Add(item);
            }


            return movie;

        }

    }
}
