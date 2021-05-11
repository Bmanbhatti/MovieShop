using ApplicationCore.Models.Response;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
       

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<MovieDetailResponseModel> GetMovieByIdAsync(int id)
        {
            var movie = await _movieRepository.GetByIdAsync(id);
            var genres = new List<GenreResponseModel>();
           
            var castofmovie = new List<CastResponseModel>();



            foreach (var cast in movie.MovieCasts)
            {
                
                castofmovie.Add(new CastResponseModel
                {
                    Id = cast.CastId,
                    Name = cast.Cast.Name,
                    Character= cast.Character,
                    ProfilePath=cast.Cast.ProfilePath

                });

            }

            foreach (var genre in movie.Genres)
            {
                genres.Add(new GenreResponseModel
                {
                    Id = genre.Id,
                    Name = genre.Name,

                });
            }
            var result = new MovieDetailResponseModel
            {
                Id = movie.Id,
                Budget = movie.Budget,
                Title = movie.Title,
                Tagline = movie.Tagline,
                Overview = movie.Overview,
                RunTime = movie.RunTime,
                ReleaseDate = movie.ReleaseDate,
                BackdropUrl = movie.BackdropUrl,
                PosterUrl = movie.PosterUrl,
                Price = movie.Price,
                Rating = movie.Rating,
                Genres = genres,
                Casts = castofmovie
            };
            return result;
        }

     

        public async Task<List<MovieCardResponseModel>> GetMoviesByGenreAsync(int id)
        {
            var movies = await _movieRepository.GetMoviesByGenreAsync(id);

            var moviebygenre = new List<MovieCardResponseModel>();
            foreach (var movie in movies)
            {
                moviebygenre.Add(new MovieCardResponseModel
                {
                    Id = movie.Id,
                    Budget = movie.Budget,
                    Title = movie.Title,
                    PosterUrl = movie.PosterUrl
                });
            }
            return moviebygenre;
        }


        public async Task<List<MovieCardResponseModel>> GetTop30RevenueMovie()
        {
            var movies = await _movieRepository.GetTop30HighestRevenueMovies();

            var topMovies = new List<MovieCardResponseModel>();
            foreach (var movie in movies)
            {
                topMovies.Add(new MovieCardResponseModel
                {
                    Id = movie.Id,
                    Budget = movie.Budget,
                    Title = movie.Title,
                     PosterUrl = movie.PosterUrl
                });
            }

            return topMovies;
        }
        public async Task<List<MovieCardResponseModel>> ListAllAsync()
        {
            var movies = await _movieRepository.ListAllAsync();
            var allMovies = new List<MovieCardResponseModel>();
            foreach (var movie in movies)
            {
                allMovies.Add(new MovieCardResponseModel
                {
                    Id = movie.Id,
                    Budget = movie.Budget,
                    Title = movie.Title,
                    PosterUrl = movie.PosterUrl
                });
            }

            return allMovies;
        }
    }
}
