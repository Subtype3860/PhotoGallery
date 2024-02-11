

using System;
using System.Globalization;
using Xamarin.Forms;

namespace PhotoGallery.Converters
{
    class PinEntry4Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var s = (String)value;
            if (!string.IsNullOrEmpty(s))
            {
                return s.Substring(3, 1);
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
