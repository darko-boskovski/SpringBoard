using MovieCatalog.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Domain.Models
{
    public class Role : BaseEntity
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public EnumRole RoleType { get; set; }
    }
}
