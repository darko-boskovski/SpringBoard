using MovieCatalog.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Domain.Models
{
    public class Genre : BaseEntity
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public EnumGenre GenreType { get; set; }
    }
}
