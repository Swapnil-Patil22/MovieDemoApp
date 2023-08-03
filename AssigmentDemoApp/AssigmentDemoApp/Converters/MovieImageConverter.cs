using System;
using System.Globalization;
using Xamarin.Forms;

namespace AssigmentDemoApp.Converters
{
	public class MovieImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter != null && parameter.Equals("BackdropPath"))
                return string.Format("{0}{1}", AppSettings.BackdropImageUrl, value);
            else
                return string.Format("{0}{1}", AppSettings.MainImageUrl, value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}