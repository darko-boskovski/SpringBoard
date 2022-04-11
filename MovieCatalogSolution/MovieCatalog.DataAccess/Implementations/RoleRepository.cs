using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieCatalog.DataAccess.Implementations
{
    public class RoleRepository : IRepository<Role>
    {

        private MovieCatalogDbContext _movieCatalogDbContext;

        public RoleRepository(MovieCatalogDbContext movieCatalogDbContext)
        {
            _movieCatalogDbContext = movieCatalogDbContext;
        }

        public Role Add(Role entity)
        {
            _movieCatalogDbContext.Roles.Add(entity);
            _movieCatalogDbContext.SaveChanges();
            return entity;
        }

        public void Delete(Role entity)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAll()
        {
            return _movieCatalogDbContext.Roles.ToList();
        }

        public Role GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
