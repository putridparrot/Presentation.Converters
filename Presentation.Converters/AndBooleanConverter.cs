using System;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;

namespace PutridParrot.Presentation.Converters
{
    /// <summary>
    /// Takes multiple values and acts as an And
    /// </summary>
    [ValueConversion(typeof(bool), typeof(bool))]
    public class AndBooleanConverter : MarkupExtension, 
        IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values == null)
                return false;

            var booleans = values.Where(_ => _ is bool).ToArray();
            return booleans.All(_ => (bool)_);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
