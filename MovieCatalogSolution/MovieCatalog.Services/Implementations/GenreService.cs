using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using MovieCatalog.Services.Interfaces;
using MovieCatalog.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Services.Implementations
{
    public class GenreService : IGenreService
    {
        private IRepository<Genre> _genreRepository;

        public GenreService(IRepository<Genre> genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public Genre AddGenre(Genre genre)
        {
            return _genreRepository.Add(genre);
        }

        public List<GenreViewModel> GetAllGenres()
        {
            List<GenreViewModel> list = new List<GenreViewModel>();
            var allGenres = _genreRepository.GetAll();

            foreach(var genre in allGenres)
            {
                GenreViewModel genreViewModel = new GenreViewModel();
                genreViewModel.Id = genre.Id;
                genreViewModel.GenreType = genre.GenreType;

                list.Add(genreViewModel);
            }

            return list;
        }
    }
}
