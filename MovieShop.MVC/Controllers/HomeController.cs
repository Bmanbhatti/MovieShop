using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieShop.MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       private readonly IMovieService _movieService;
       // private readonly IGenreService _genreService;

        public HomeController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        //public HomeController(IGenreService genreService)
        //{
        //    _genreService = genreService;
        //}




        public async Task<IActionResult> Index()
        {
         
           var movies = await _movieService.GetTop30RevenueMovie();
            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
