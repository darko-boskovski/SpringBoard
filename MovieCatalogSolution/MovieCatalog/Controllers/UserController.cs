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
                    return RedirectToAction("products", "product");
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
