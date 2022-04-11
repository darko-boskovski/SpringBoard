using MovieCatalog.Domain.Models;
using MovieCatalog.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Services.Interfaces
{
    public interface IMoviePersonInterface
    {
        List<MoviePersonViewModel> GetAll();

        MoviePerson Add(MoviePerson moviePerson);
    }
}
