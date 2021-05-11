using ApplicationCore.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieService
    {
        Task<List<MovieCardResponseModel>> GetTop30RevenueMovie();
        Task<MovieDetailResponseModel> GetMovieByIdAsync(int id);
        Task<List<MovieCardResponseModel>> GetMoviesByGenreAsync(int id);

    }
}
