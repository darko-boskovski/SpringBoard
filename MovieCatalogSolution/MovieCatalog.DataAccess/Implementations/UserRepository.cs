using Microsoft.EntityFrameworkCore;
using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieCatalog.DataAccess.Implementations
{
    public class UserRepository : IUserRepository
    {

        private MovieCatalogDbContext _movieCatalogDbContext;

        public UserRepository(MovieCatalogDbContext movieCatalogDbContext)
        {
            _movieCatalogDbContext = movieCatalogDbContext;
        }


        public User Add(User entity)
        {
            _movieCatalogDbContext.Users.Add(entity);
            _movieCatalogDbContext.SaveChanges();
            return entity;
        }

        public void Delete(User entity)
        {
            _movieCatalogDbContext.Users.Remove(entity);
            _movieCatalogDbContext.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _movieCatalogDbContext
               .Users
               .ToList();
        }

        public User GetById(int id)
        {
            return _movieCatalogDbContext
             .Users
             .FirstOrDefault(x => x.Id == id);
        }

        public User GetUserByUsername(string username)
        {
            return _movieCatalogDbContext.Users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower());
        }

        public User LoginUser(string username, string password)
        {
            return _movieCatalogDbContext.Users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower()
&& x.Password == password);
        }

        public void Update(User entity)
        {
            _movieCatalogDbContext.Users.Update(entity);
            _movieCatalogDbContext.SaveChanges();
        }
    }
}
