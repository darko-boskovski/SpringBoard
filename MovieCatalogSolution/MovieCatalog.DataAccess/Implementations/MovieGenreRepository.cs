using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieCatalog.DataAccess.Implementations
{
    public class MovieGenreRepository : IRepository<MovieGenre>
    {

        private MovieCatalogDbContext _movieCatalogDbContext;

        public MovieGenreRepository(MovieCatalogDbContext movieCatalogDbContext)
        {
            _movieCatalogDbContext = movieCatalogDbContext;
        }

        public MovieGenre Add(MovieGenre entity)
        {

            _movieCatalogDbContext.MovieGenre.Add(entity);
            _movieCatalogDbContext.SaveChanges();
            return entity;
        }

        public void Delete(MovieGenre entity)
        {
            throw new NotImplementedException();
        }

        public List<MovieGenre> GetAll()
        {
            return _movieCatalogDbContext.MovieGenre.ToList();
        }

        public MovieGenre GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(MovieGenre entity)
        {
            throw new NotImplementedException();
        }
    }
}
