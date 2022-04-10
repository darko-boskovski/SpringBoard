using MovieCatalog.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Services.Interfaces
{
    public interface IMovieInterface
    {
        List<MovieViewModel> GetAllMovies();
        MovieViewModel GetMovieById(int id);
        void AddMovie(MovieViewModel movieModel);
        void UpdateMovie(MovieViewModel movieModel);
        void DeleteMovie(int id);
    }
}
