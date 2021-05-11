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
    public class GenresController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }


        [HttpGet]
        [Route("")]

        // api/genres/
        public async Task<IActionResult> GetAllGenres()
        {
            // 200, 201, 400, 401, 403, 404, 500 
            var genres = await _genreService.GetAllGenres();

            if (genres.Any())
            {
                return Ok(genres);
            }

            return NotFound("no genres found");
        }

    }
}
