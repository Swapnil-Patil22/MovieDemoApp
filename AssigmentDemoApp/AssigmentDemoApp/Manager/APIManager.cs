using System;
using System.Threading.Tasks;
using AssigmentDemoApp.Interface;
using AssigmentDemoApp.Models;
using Refit;

namespace AssigmentDemoApp.Manager
{
	public class APIManager
	{
        static APIManager _manager;
        private APIManager()
        {
        }
        public static APIManager Instance
        {
            get
            {
                if (_manager == null)
                    _manager = new APIManager();
                return _manager;
            }
        }

        public async Task<TmdbApiResponse> GetPopularAsync()
        {
            try
            {
                var data = await RestService.For<IMoviesService>(AppSettings.BaseUrl).GetPopularMovies(AppSettings.ApiKey);
                if (data.Results != null)
                {
                    return data;
                }
                return null;
            }
            catch (ApiException ex)
            {
                return null;
            }
        }
    }
}

