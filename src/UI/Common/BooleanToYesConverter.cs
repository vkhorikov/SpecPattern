using System;
using System.Globalization;
using System.Windows.Data;


namespace UI.Common
{
    [ValueConversion(typeof(bool), typeof(string))]
    public class BooleanToYesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool booleanValue = (bool) value;
            return booleanValue ? "Yes" : string.Empty;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }
    }
}
