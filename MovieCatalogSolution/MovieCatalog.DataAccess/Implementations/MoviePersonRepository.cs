using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieCatalog.DataAccess.Implementations
{
    public class MoviePersonRepository : IRepository<MoviePerson>
    {

        private MovieCatalogDbContext _movieCatalogDbContext;

        public MoviePersonRepository(MovieCatalogDbContext movieCatalogDbContext)
        {
            _movieCatalogDbContext = movieCatalogDbContext;
        }


        public MoviePerson Add(MoviePerson entity)
        {
            _movieCatalogDbContext.MoviePeople.Add(entity);
            _movieCatalogDbContext.SaveChanges();
            return entity;
        }

        public void Delete(MoviePerson entity)
        {
            throw new NotImplementedException();
        }

        public List<MoviePerson> GetAll()
        {
            return _movieCatalogDbContext.MoviePeople.ToList();
        }

        public MoviePerson GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(MoviePerson entity)
        {
            throw new NotImplementedException();
        }
    }
}
