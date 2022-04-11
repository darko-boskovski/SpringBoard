using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using MovieCatalog.Mappers;
using MovieCatalog.Services.Interfaces;
using MovieCatalog.Shared.Enums;
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
        private IPersonService _personService;
        private IRoleInterface _roleService;
        private IMoviePersonInterface _moviePersonService;
        private IGenreService _genreService;
        private IMovieGenreInterface _movieGenreService;

        public MovieService(IRepository<Movie> movieRepository, IUserRepository userRepository, IPersonService personService,IRoleInterface roleService,
            IMoviePersonInterface moviePersonService, IGenreService genreService, IMovieGenreInterface movieGenreService)
        {
            _movieRepository = movieRepository;
            _userRepository = userRepository;
            _personService = personService;
            _roleService = roleService;
            _moviePersonService = moviePersonService;       
            _genreService = genreService;
            _movieGenreService = movieGenreService;
        }



        public void AddMovie(MovieViewModel movieModel)
        {
            try
            {

                _movieRepository.Add(movieModel.ToMovie());
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }

        public void CreateMovieStructure(MovieViewModel movieModel)
        {
            //create movie

            Movie movie = movieModel.ToMovie();

            movie = _movieRepository.Add(movie);



            //fetch genres and create MovieGenre

            Genre genre = new Genre();
            genre.GenreType = movieModel.Genre;

            if (genre.GenreType == 0) {
                genre.GenreType = (EnumGenre)new Random().Next(1, 7);                                  
            }

            _genreService.AddGenre(genre);


            MovieGenre movieGenre = new MovieGenre();
            movieGenre.GenreId = genre.Id;
            movieGenre.MovieId = movie.Id;
            _movieGenreService.Add(movieGenre);








            //create director
            Person person = new Person();
            person.FirstName = movieModel.Director.FirstName;
            person.LastName = movieModel.Director.LastName;
                person.Age = movieModel.Director.Age;
            person.Biography = movieModel.Director.Biography;
            person = _personService.AddPerson(person);

            //store the movie and the director in MoviePerson
            MoviePerson movieDirector = new MoviePerson();
            movieDirector.PersonId = person.Id;
            movieDirector.MovieId = movie.Id;
            _moviePersonService.Add(movieDirector);

            //store the role
            Role role = new Role();
            role.RoleType = Shared.Enums.EnumRole.Director;
            role.PersonId = person.Id;
            _roleService.AddRole(role);
 

            //create producer
            //store the movie and the producer in MoviePerson
            //create director
            Person producer = new Person();
            producer.FirstName = movieModel.Producer.FirstName;
            producer.LastName = movieModel.Producer.LastName;
            producer.Age = movieModel.Producer.Age;
            producer.Biography = movieModel.Producer.Biography;
             _personService.AddPerson(producer);

            //store the movie and the director in MoviePerson
            MoviePerson director = new MoviePerson();
            director.PersonId = person.Id;
            director.MovieId = movie.Id;
            _moviePersonService.Add(director);

            //store the role
            Role directorRole = new Role();
            directorRole.RoleType = Shared.Enums.EnumRole.Director;
            directorRole.PersonId = person.Id;
            _roleService.AddRole(directorRole);

            //create actor1
            //store the movie and the actor1 in MoviePerson

            Person actoreOne = new Person();
            actoreOne.FirstName = movieModel.Producer.FirstName;
            actoreOne.LastName = movieModel.Producer.LastName;
            actoreOne.Age = movieModel.Producer.Age;
            actoreOne.Biography = movieModel.Producer.Biography;
            _personService.AddPerson(actoreOne);

            //store the movie and the director in MoviePerson
            MoviePerson actor = new MoviePerson();
            actor.PersonId = person.Id;
            actor.MovieId = movie.Id;
            _moviePersonService.Add(actor);

            //store the role
            Role actoreRole = new Role();
            actoreRole.RoleType = Shared.Enums.EnumRole.Director;
            actoreRole.PersonId = person.Id;
            _roleService.AddRole(actoreRole);

            //create actor2
            //store the movie and the actor2 in MoviePerson
            Person actoreTwo = new Person();
            actoreTwo.FirstName = movieModel.Producer.FirstName;
            actoreTwo.LastName = movieModel.Producer.LastName;
            actoreTwo.Age = movieModel.Producer.Age;
            actoreTwo.Biography = movieModel.Producer.Biography;
            _personService.AddPerson(actoreTwo);

            //store the movie and the director in MoviePerson
            MoviePerson actorSecond = new MoviePerson();
            actorSecond.PersonId = person.Id;
            actorSecond.MovieId = movie.Id;
            _moviePersonService.Add(actorSecond);

            //store the role
            Role actoreTwoRole = new Role();
            actoreTwoRole.RoleType = Shared.Enums.EnumRole.Director;
            actoreTwoRole.PersonId = person.Id;
            _roleService.AddRole(actoreTwoRole);

    


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

                User userDb = _userRepository.GetById(movieModel.Id);


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
