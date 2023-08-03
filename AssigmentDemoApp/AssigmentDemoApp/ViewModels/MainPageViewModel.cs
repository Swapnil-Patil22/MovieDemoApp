using System;
using AssigmentDemoApp.Interface;
using AssigmentDemoApp.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AssigmentDemoApp.Manager;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using AssigmentDemoApp.Views;

namespace AssigmentDemoApp.ViewModels
{
	public class MainPageViewModel : BaseINotifyViewModel
    {
        private IMoviesService _moviesService;


        public MainPageViewModel()
		{
            MainThread.BeginInvokeOnMainThread(async () =>
            {
               await LoadPopularMoviesAync();

            });
        }

        /// <summary>
        /// API to get the popular movie list
        /// </summary>
        /// <returns></returns>
        private async Task LoadPopularMoviesAync()
        {
            var result = await APIManager.Instance.GetPopularAsync();

            PopularMovies = new ObservableCollection<Movie>(result.Results.Take(10));
        }


        private ObservableCollection<Movie> _popularMovies;
        public ObservableCollection<Movie> PopularMovies
        {
            get { return _popularMovies; }
            set
            {
                _popularMovies = value;
                OnPropertyChanged("PopularMovies");
            }
        }


        /// <summary>
        /// on item selected open details page
        /// </summary>
        private Movie _onItemSelected;
        public Movie OnItemSelected
        {
            get
            {
                return _onItemSelected;
            }
            set
            {
                _onItemSelected = value;
                if (value != null)
                {
                    MainThread.BeginInvokeOnMainThread(async () =>
                    {
                        await Application.Current.MainPage.Navigation.PushAsync(new MovieDetailsPage(value));
                    });
                }
                OnPropertyChanged("OnItemSelected");
            }
        }
    }
}

