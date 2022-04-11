using MovieCatalog.Domain.Models;
using MovieCatalog.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.ViewModels
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public EnumGenre Genre { get; set; }
        public PersonViewModel ActorOne { get; set; }
        public PersonViewModel ActorTwo { get; set; }
        public PersonViewModel Director { get; set; }
        public PersonViewModel Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<MoviePersonViewModel> MoviePeople { get; set; }
        public List<GenreViewModel> GenresViewModel { get; set; }
        public List<string> Cast { get; set; }
        public List<MovieGenreViewModel> Genres { get; set; }
    }
}
