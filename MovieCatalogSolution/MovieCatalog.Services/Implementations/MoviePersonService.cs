using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using MovieCatalog.Services.Interfaces;
using MovieCatalog.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Services.Implementations
{
    public class MoviePersonService : IMoviePersonInterface
    {

        private IRepository<MoviePerson> _moviePersonRepository;

        public MoviePersonService(IRepository<MoviePerson> moviePersonRepository)
        {
            _moviePersonRepository = moviePersonRepository;
        }

        public MoviePerson Add(MoviePerson moviePerson)
        {
            return _moviePersonRepository.Add(moviePerson);
        }

        public List<MoviePersonViewModel> GetAll()
        {
            List<MoviePersonViewModel> list = new List<MoviePersonViewModel>();
            var allPerson = _moviePersonRepository.GetAll();

            foreach (var person in allPerson)
            {
                MoviePersonViewModel moveiPersonViewModel = new MoviePersonViewModel();
                moveiPersonViewModel.Id = person.Id;
                moveiPersonViewModel.MovieId = person.MovieId;
                moveiPersonViewModel.PersonId = person.Id;

                list.Add(moveiPersonViewModel);
            }

            return list;
        }
    }
}
