using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Presentation.Converters
{
    /// <summary>
    /// Allows conversion of a boolean value to a string and back. By default
    /// "True" and "False" are mapped to boolean true and false, but these
    /// can be changed via WhenTrue and WhenFalse for locatalization or
    /// alternate preference
    /// </summary>
    public class BooleanToStringConverter : MarkupExtension,
        IValueConverter
    { 
        public BooleanToStringConverter() :
            this("True", "False")
        {
        }

        public BooleanToStringConverter(string whenTrue, string whenFalse)
        {
            WhenTrue = whenTrue;
            WhenFalse = whenFalse;
        }

        [ConstructorArgument("WhenTrue")]
        public string WhenTrue { get; set; }

        [ConstructorArgument("WhenFalse")]
        public string WhenFalse { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        private string ToString(bool b)
        {
            return b ? WhenTrue : WhenFalse;
        }

        private bool ToBoolean(string s)
        {
            return s == WhenTrue;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool b ? ToString(b) : null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is string s && ToBoolean(s);
        }
    }
}
