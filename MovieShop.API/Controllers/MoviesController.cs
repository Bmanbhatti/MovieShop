using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.ServiceInterfaces;

namespace MovieShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }


        [HttpGet]
        [Route("toprevenue")]
        public async Task<IActionResult> GetTopRevenueMovies()
        {
            var movies = await _movieService.GetTop30RevenueMovie();
            if (movies.Any())
            {
                return Ok(movies);
            }

            return NotFound("No movies found");
        }

        [HttpGet]
         [Route("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var movie = await _movieService.GetMovieByIdAsync(id);
            return Ok(movie);
        }
        //[HttpGet]
        //[Route("{id: int}", Name = "id")]
        //public async Task<IActionResult> Details(int id)
        //{
        //    var movie = await _movieService.GetMovieByIdAsync(1);
        //    return Ok(movie);
        //}



        [HttpGet]
        [Route("genre/{genreId:int}")]
        public async Task<IActionResult> GetMoviesByGenre(int genreId)
        {

            var movies = await _movieService.GetMoviesByGenreAsync(genreId);
            if (movies.Any())
            {
                return Ok(movies);
            }
            else
                return NotFound("No movies found");
        }

      
    }
}
