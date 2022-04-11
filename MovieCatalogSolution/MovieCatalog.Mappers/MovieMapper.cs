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

            };
        }


        public static Movie MapMovie(Movie movie, MovieViewModel movieModel, User user)
        {


            movieModel.Cast = new List<string>();

            movie.Title = movieModel.Title;
            movie.Description = movieModel.Description;
            movie.ReleaseDate = movieModel.ReleaseDate.Date;

           

            return movie;

        }

    }
}
