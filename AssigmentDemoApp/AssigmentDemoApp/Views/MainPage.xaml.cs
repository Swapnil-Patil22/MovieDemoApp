using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssigmentDemoApp.ViewModels;
using Xamarin.Forms;

namespace AssigmentDemoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            movieListView.SelectedItem = null;
        }
    }
}

