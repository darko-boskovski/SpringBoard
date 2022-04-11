using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieCatalog.DataAccess.Implementations
{
    public class GenreRepository : IRepository<Genre>
    {
         private MovieCatalogDbContext _movieCatalogDbContext;

        public GenreRepository(MovieCatalogDbContext movieCatalogDbContext)
        {
            _movieCatalogDbContext = movieCatalogDbContext;
        }
        public Genre Add(Genre entity)
        {
            _movieCatalogDbContext.Genres.Add(entity);
            _movieCatalogDbContext.SaveChanges();
            return entity;
        }

        public void Delete(Genre entity)
        {
            throw new NotImplementedException();
        }

        public List<Genre> GetAll()
        {        
            return  _movieCatalogDbContext.Genres.ToList();
        }
        public Genre GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Genre entity)
        {
            throw new NotImplementedException();
        }
    }
}
