using MovieCatalog.Domain.Models;
using MovieCatalog.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Services.Interfaces
{
    public interface IRoleInterface
    {
        List<RoleViewModel> GetAllRoles();
        Role AddRole(Role role);
    }
}
