using System;
using AssigmentDemoApp.Models;
using System.Collections.ObjectModel;

namespace AssigmentDemoApp.ViewModels
{
	public class MovieDetailsViewModel : BaseINotifyViewModel
	{
		public MovieDetailsViewModel(Models.Movie value)
		{
            Title = value.Title;
            Overview = value.Overview;
            ReleaseDate = value.ReleaseDate;
            PosterPath = value.PosterPath;
            BackdropPath = value.BackdropPath;
            VoteAverage = value.VoteAverage;
            VoteCount = value.VoteCount;
		}

        private string title;
        public string Title {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        private string overview;
        public string Overview {
            get { return overview; }
            set
            {
                overview = value;
                OnPropertyChanged("Overview");
            }
        }

        private string releaseDate;
        public string ReleaseDate {
            get { return releaseDate; }
            set
            {
                releaseDate = value;
                OnPropertyChanged("ReleaseDate");
            }
        }

        private string posterPath;
        public string PosterPath {
            get { return posterPath; }
            set
            {
                posterPath = value;
                OnPropertyChanged("PosterPath");
            }
        }

        private string backdropPath;
        public string BackdropPath
        {
            get { return backdropPath; }
            set
            {
                backdropPath = value;
                OnPropertyChanged("BackdropPath");
            }
        }

        private double voteAverage;
        public double VoteAverage{
            get { return voteAverage; }
            set
            {
                voteAverage = value;
                OnPropertyChanged("VoteAverage");
            }
        }

        private double voteCount;
        public double VoteCount{
            get { return voteCount; }
            set
            {
                voteCount = value;
                OnPropertyChanged("VoteCount");
            }
        }
    }
}

