using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using MovieCatalog.Services.Interfaces;
using MovieCatalog.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Services.Implementations
{
    public class RoleService : IRoleInterface
    {

        private IRepository<Role> _roleRepository;

        public RoleService(IRepository<Role> genreRepository)
        {
            _roleRepository = genreRepository;
        }

        public Role AddRole(Role role)
        {
            return _roleRepository.Add(role);
        }


        public List<RoleViewModel> GetAllRoles()
        {
            List<RoleViewModel> list = new List<RoleViewModel>();
            var allRoles = _roleRepository.GetAll();

            foreach (var role in allRoles)
            {
                RoleViewModel roleViewModel = new RoleViewModel();
                roleViewModel.Id = role.Id;
                roleViewModel.RoleType = role.RoleType;

                list.Add(roleViewModel);
            }

            return list;
        }
    }

}
