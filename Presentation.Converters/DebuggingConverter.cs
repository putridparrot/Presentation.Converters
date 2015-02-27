using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows.Data;

namespace Presentation.Converters
{
    /// <summary>
    /// DebuggingConverter allows us to add debugging to a binding
    /// to spot those strange issues with a value not being as expected
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class DebuggingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
#if DEBUG
            Debugger.Break();
#endif
            return value;
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
#if DEBUG
            Debugger.Break();
#endif
            return value;
        }
    }
}
