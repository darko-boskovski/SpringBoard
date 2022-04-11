using Microsoft.AspNetCore.Mvc;
using MovieCatalog.Services.Interfaces;
using MovieCatalog.ViewModels;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.Controllers
{
    public class UserController : Controller
    {

        private IUserInterface _userService;

        public UserController(IUserInterface userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult LogIn()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult LogIn(LoginViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Log.Debug("Authenticating user with username {username}:", model.Username);
                    var user = _userService.Login(model);

                    if (user != "")
                    {
                        Log.Debug("User with username {username} succesfully logged in as Admin", model.Username);
                        return RedirectToAction("index", "home");
                    }
                    else
                    {
                        Log.Debug("User with username {username} succesfully logged in as Customer", model.Username);
                        return RedirectToAction("index", "movie");
                    }
                }

            }
            catch (Exception ex)
            {
                Log.Error("Message: {message}", ex.Message);
            }
            return View();
        }




        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Log.Information($"New user is registered with username: {model.Username}");
                    _userService.Register(model);
                    return RedirectToAction("index", "movie");
                }
            }
            catch (Exception ex)
            {

                Log.Error($"Message: {ex.Message}");
            }
            return View(model);
        }


    }
}
