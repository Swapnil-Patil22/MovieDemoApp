using System;
using System.Threading.Tasks;
using AssigmentDemoApp.Models;
using Refit;

namespace AssigmentDemoApp.Interface
{
	public interface IMoviesService
	{
        [Get("/movie/popular")]
        [Headers("Content-Type: application/json; charset=UTF-8")]
        Task<TmdbApiResponse> GetPopularMovies([AliasAs("api_key")] string apiKey);
    }
}

