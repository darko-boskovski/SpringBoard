using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieCatalog.DataAccess;
using MovieCatalog.DataAccess.Implementations;
using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using MovieCatalog.Services.Implementations;
using MovieCatalog.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static IServiceCollection RegisterModule(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MovieCatalogDbContext>
                (options => options.UseSqlServer(connectionString));





            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRepository<Movie>, MovieRepository>();
            services.AddTransient<IRepository<Genre>, GenreRepository>();
            services.AddTransient<IRepository<Person>, PersonRepository>();
            services.AddTransient<IRepository<Role>, RoleRepository>();
            services.AddTransient<IRepository<MoviePerson>, MoviePersonRepository>();



            services.AddTransient<IUserInterface, UserService>();
            services.AddTransient<IMovieInterface, MovieService>();
            services.AddTransient<IGenreService, GenreService>();
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IRoleInterface, RoleService>();
            services.AddTransient<IMoviePersonInterface, MoviePersonService>();

            return services;
        }
    }
}
