using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using MovieCatalog.Mappers;
using MovieCatalog.Services.Interfaces;
using MovieCatalog.ViewModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MovieCatalog.Services.Implementations
{
    public class MovieService : IMovieInterface
    {
        private IRepository<Movie> _movieRepository;
        private IUserRepository _userRepository;

        public MovieService(IRepository<Movie> movieRepository, IUserRepository userRepository)
        {
            _movieRepository = movieRepository;
            _userRepository = userRepository;
        }



        public void AddMovie(MovieViewModel movieModel)
        {
            try
            {

                //Movie movie = new Movie()

                //{
                //    Id = movieModel.Id,
                //    Title = movieModel.Title,
                //    Description = movieModel.Description,
                //    ReleaseDate = movieModel.ReleaseDate.Date,
                //    UserId = movieModel.UserId,


                //};



                _movieRepository.Add(movieModel.ToMovie());
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }
        public void DeleteMovie(int id)
        {
            try
            {
                Movie movieDb = _movieRepository.GetById(id);

                _movieRepository.Delete(movieDb);


            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }

        }


        public List<MovieViewModel> GetAllMovies()
        {
            try
            {

                List<Movie> moviesDb = _movieRepository.GetAll();

                List<MovieViewModel> movieModels = new List<MovieViewModel>();


                foreach (Movie movie in moviesDb)
                {
                    movieModels.Add(movie.ToMovieModel());
                }


                return movieModels;

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }

        }

        public MovieViewModel GetMovieById(int id)
        {

            try
            {

                Movie movieDb = _movieRepository.GetById(id);

                var data = _movieRepository.GetAll();

                MovieViewModel viewMovie = movieDb.ToMovieModel();

                viewMovie.Genre = movieDb.Genres.Select(x => x.GenreType.ToString()).ToList();

                viewMovie.Cast = movieDb.MoviePeople.Select(x => x.Person.FirstName).ToList();

                return viewMovie;

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }

        }

        public void UpdateMovie(MovieViewModel movieModel)
        {
            try
            {
                Movie movieDb = _movieRepository.GetById(movieModel.Id);

                User userDb = _userRepository.GetById(movieModel.UserId);


                _movieRepository.Update(MovieMapper.MapMovie(movieDb, movieModel, userDb));
            }
            catch (Exception ex)

            {
                string message = ex.Message;
                throw new Exception(message);
            }

        }
    }
}
