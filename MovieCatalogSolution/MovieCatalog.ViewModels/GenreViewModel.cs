using MovieCatalog.Domain.Models;
using MovieCatalog.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.ViewModels
{
    public class GenreViewModel
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public EnumGenre GenreType { get; set; }
    }
}
