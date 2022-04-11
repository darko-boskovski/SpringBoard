using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using MovieCatalog.Services.Interfaces;
using MovieCatalog.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Services.Implementations
{
    public class MovieGenreService : IMovieGenreInterface
    {
        private IRepository<MovieGenre> _movieGenreRepository;

        public MovieGenreService(IRepository<MovieGenre> movieGenreRepository)
        {
            _movieGenreRepository = movieGenreRepository;
        }


        public MovieGenre Add(MovieGenre moviePerson)
        {
            return _movieGenreRepository.Add(moviePerson);
        }

        public List<MovieGenreViewModel> GetAll()
        {
            List<MovieGenreViewModel> list = new List<MovieGenreViewModel>();
            var allGenre = _movieGenreRepository.GetAll();

            foreach (var genre in allGenre)
            {
                MovieGenreViewModel movieGenreViewModel = new MovieGenreViewModel();
                movieGenreViewModel.Id = genre.Id;
                movieGenreViewModel.MovieId = genre.MovieId;
                movieGenreViewModel.GenreId = genre.Id;
        
                list.Add(movieGenreViewModel);
            }

            return list;
        }
    }
}
