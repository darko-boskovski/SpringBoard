using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Domain.Models
{
    public class MoviePerson : BaseEntity
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
