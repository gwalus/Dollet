using System.Globalization;

namespace Dollet.Conventers
{
    internal class FirstCharacterConverter : IValueConverter
    {
        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || value is not string)
                return null;

            return ((string)value).Length > 0 ? ((string)value).ToUpperInvariant()[0] : string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }
    }
}
