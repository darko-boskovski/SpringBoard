using Microsoft.EntityFrameworkCore;
using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalog.DataAccess.Implementations
{
    public class MovieRepository : IRepository<Movie>
    {

        private MovieCatalogDbContext _movieCatalogDbContext;

        public MovieRepository(MovieCatalogDbContext movieCatalogDbContext)
        {
            _movieCatalogDbContext = movieCatalogDbContext;
        }

        public Movie Add(Movie entity)
        {
            _movieCatalogDbContext.Movies.Add(entity);
            _movieCatalogDbContext.SaveChanges();
            return entity;
        }

        public void Delete(Movie entity)
        {
            _movieCatalogDbContext.Movies.Remove(entity);
            _movieCatalogDbContext.SaveChanges();
        }

        public List<Movie> GetAll()
        {
            return _movieCatalogDbContext.Movies
             .Include(x => x.Genre)
             .ThenInclude(x => x.Genre)
             .Include(x => x.MoviePeople)
             .ThenInclude(x => x.Person)
             .ToList();
        }

        public Movie GetById(int id)
        {
            return _movieCatalogDbContext.Movies
               .Include(x => x.Genre)
               .Include(x => x.MoviePeople)
               .FirstOrDefault(x => x.Id == id);
        }

        public void Update(Movie entity)
        {
            _movieCatalogDbContext.Movies.Update(entity);
            _movieCatalogDbContext.SaveChanges();
        }
    }
}
