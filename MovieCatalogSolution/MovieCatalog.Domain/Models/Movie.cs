using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Domain.Models
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<MovieGenre> Genre { get; set; }

        public List<MoviePerson> MoviePeople { get; set; }
    }
}
