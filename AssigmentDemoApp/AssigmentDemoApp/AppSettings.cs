using System;
using System.IO;
using System.Linq;
using System.Runtime;
using Xamarin.Essentials;

namespace AssigmentDemoApp
{
	public class AppSettings
	{
        public static string ApiKey = "1e01bec596ba252a25dbb806a9792279";
        public static string BaseUrl = "https://api.themoviedb.org/3/";
        public static string MainImageUrl = "http://image.tmdb.org/t/p/w185/";
        public static string BackdropImageUrl = "http://image.tmdb.org/t/p/w500/";
        public static string AppLanguage = "en";


        static AppSettings _setting;
        public static AppSettings Instance
        {
            get
            {
                if (_setting == null)
                    _setting = new AppSettings();
                return _setting;
            }
        }

        public bool IsInternetAvailable()
        {
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
                return true;
            else
                return false;
        }

        public bool IsPopupStackContains()
        {
            if (Rg.Plugins.Popup.Services.PopupNavigation.Instance.PopupStack.Any())
            {
                return true;
            }
            else
                return false;
        }
    }
}

