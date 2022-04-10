using MovieCatalog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.ViewModels
{
    class MoviePersonViewModel
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}
