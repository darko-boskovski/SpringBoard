using MovieCatalog.Domain.Models;
using MovieCatalog.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public List<Movie> Movies { get; set; }
        public EnumGenre FavoriteGenre { get; set; }
    }
}
