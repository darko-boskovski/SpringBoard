using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCatalog.Domain.Models;
using MovieCatalog.Mappers;
using MovieCatalog.Models;
using MovieCatalog.Services.Implementations;
using MovieCatalog.Services.Interfaces;
using MovieCatalog.ViewModels;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.Controllers
{
    public class MovieController : Controller
    {

        private IMovieInterface _movieService;
        private IGenreService _genreService;

        public MovieController(IMovieInterface movieService, IGenreService genreService)

        {
            _movieService = movieService;
            _genreService = genreService;
        }

        // GET: MovieController
        public ActionResult Index()
        {


            try
            {
                List<MovieViewModel> products = _movieService.GetAllMovies().ToList();

                return View(products);
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message}");
            }
            return PartialView("ErrorView");

        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                MovieViewModel movieModel = _movieService.GetMovieById(id);

                return View(movieModel);

            }
            catch (Exception ex)

            {
                Log.Error($"Message: {ex.Message}");
            }
            return PartialView("ErrorView");

        }

        // GET: MovieController/Create
        [HttpGet]
        public ActionResult AddMovie()
        {

            MovieViewModel model = new MovieViewModel();
            model.GenresViewModel = _genreService.GetAllGenres();
            return View(model);

        }


        // POST: MovieController/AddMovie
        [HttpPost]
        public ActionResult AddMovie(MovieViewModel movieModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Log.Information($"Movie is registered with the title: {movieModel.Title}");
                    _movieService.CreateMovieStructure(movieModel);
                    return RedirectToAction("Index", "Movie");
                }
            }
            catch (Exception ex)
            {

                Log.Error($"Message: {ex.Message}");
                return RedirectToAction("Index", "Home");
            }
            return View(movieModel);

        }



        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {

            try
            {
                 MovieViewModel movie = _movieService.GetMovieById(id);
                 return View(movie);
            }
            catch (Exception ex)
            {

                Log.Error($"Message: {ex.Message}");
            }
            return PartialView("ErrorView");

        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MovieViewModel movieModel)
        {
            try
            {

                _movieService.UpdateMovie(movieModel);
                return View("_ThankYou");
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
