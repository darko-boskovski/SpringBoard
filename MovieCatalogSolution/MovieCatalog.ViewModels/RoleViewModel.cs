using MovieCatalog.Domain.Models;
using MovieCatalog.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.ViewModels
{
    public class RoleViewModel
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public EnumRole RoleType { get; set; }
    }
}
