using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace Presentation.Converters
{
    public class BooleanToVisibilityConverter : MarkupExtension, 
        IValueConverter
    {
        public BooleanToVisibilityConverter()
        {
            WhenTrue = Visibility.Visible;
            WhenFalse = Visibility.Collapsed;
        }

        public BooleanToVisibilityConverter(Visibility whenTrue, Visibility whenFalse)
        {
            WhenTrue = whenTrue;
            WhenFalse = whenFalse;
        }

        [ConstructorArgument("WhenTrue")]
        public Visibility WhenTrue { get; set; }

        [ConstructorArgument("WhenFalse")]
        public Visibility WhenFalse { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter,
                              CultureInfo culture)
        {
            bool result = (value is bool?) && ((bool?)value).GetValueOrDefault(false);
            if (value is bool)
            {
                result = (bool)value;
            }
            return result ? WhenTrue : WhenFalse;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
                                  CultureInfo culture)
        {
            return (value is Visibility) && (Visibility)value == WhenTrue;
        }
    }
}
