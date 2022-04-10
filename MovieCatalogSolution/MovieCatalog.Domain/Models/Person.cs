using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Domain.Models
{
    public class Person : BaseEntity 
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
        public List<Role> Roles { get; set; }

        public string Biography { get; set; }
        public List<MoviePerson> Movies { get; set; }
    }
}
