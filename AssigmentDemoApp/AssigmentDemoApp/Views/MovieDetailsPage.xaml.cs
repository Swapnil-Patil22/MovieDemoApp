using System;
using System.Collections.Generic;
using AssigmentDemoApp.ViewModels;
using Xamarin.Forms;

namespace AssigmentDemoApp.Views
{	
	public partial class MovieDetailsPage : ContentPage
	{	
		public MovieDetailsPage (Models.Movie value)
		{
			InitializeComponent ();
			BindingContext = new MovieDetailsViewModel(value);
		}
	}
}

