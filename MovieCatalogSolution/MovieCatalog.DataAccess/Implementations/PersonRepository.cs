using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.DataAccess.Implementations
{
    public class PersonRepository : IRepository<Person>
    {
        private MovieCatalogDbContext _movieCatalogDbContext;

        public PersonRepository(MovieCatalogDbContext movieCatalogDbContext)
        {
            _movieCatalogDbContext = movieCatalogDbContext;
        }
        public Person Add(Person entity)
        {
            _movieCatalogDbContext.Add(entity);
            _movieCatalogDbContext.SaveChanges();
            return entity;
        }

        public void Delete(Person entity)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
