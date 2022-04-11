using MovieCatalog.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Domain.Models
{
    public class Genre : BaseEntity
    {
        public EnumGenre GenreType { get; set; }
        
        public List<MovieGenre> Movies { get; set; }
    }
}
