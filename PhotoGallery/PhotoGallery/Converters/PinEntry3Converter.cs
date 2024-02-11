using System;
using System.Globalization;
using Xamarin.Forms;

namespace PhotoGallery.Converters
{
    class PinEntry3Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var s = (String)value;
            if (!string.IsNullOrEmpty(s) && s.Length > 1)
            {
                return s.Substring(2, 1);
            }
            else
            {
                return "";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
