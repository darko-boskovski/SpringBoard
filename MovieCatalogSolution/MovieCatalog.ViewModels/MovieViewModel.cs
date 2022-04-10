using MovieCatalog.Domain.Models;
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
        public DateTime ReleaseDate { get; set; }
        public List<Genre> Genres { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string UserFullName { get; set; }
        public List<MoviePerson> MoviePeople { get; set; }

        public List<string> Genre { get; set; }

        public List<string> Cast { get; set; }
    }
}
