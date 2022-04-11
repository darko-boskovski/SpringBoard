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
        public List<GenreViewModel> Movies { get; set; }
        public EnumGenre GenreType { get; set; }
    }
}
