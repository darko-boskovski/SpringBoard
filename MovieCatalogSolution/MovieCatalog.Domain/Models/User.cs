using MovieCatalog.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Domain.Models
{
    public class User : BaseEntity 
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public EnumGenre FavoriteGenre { get; set; }
        public int Age { get; set; }
    }
}
