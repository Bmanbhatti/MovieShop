using ApplicationCore.Entities;
using ApplicationCore.Models.Response;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class GenreService : IGenreService
    {
        private readonly IAsyncRepository<Genre> _genreRepository;
        public GenreService(IAsyncRepository<Genre> genreRepository)
        {
            _genreRepository = genreRepository;
        }

      

        public async Task<IEnumerable<GenreResponseModel>> GetAllGenres()
        {
            var genreList = new List<GenreResponseModel>();
            var genres = await _genreRepository.ListAllAsync();
            foreach (var genre in genres)
                {
                genreList.Add(new GenreResponseModel
                    {
                        Id = genre.Id,
                        Name = genre.Name,

                    });
                }

                return genreList;
        }
    }
}