using System;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace PutridParrot.Presentation.Converters
{
    public abstract class OrToValueConverter<T> : MarkupExtension,
        IMultiValueConverter
    {
        public OrToValueConverter() :
            this(default(T), default(T))
        {
            // should be overriden is subclass to be
            // specific to the supported type
        }

        public OrToValueConverter(T whenTrue, T whenFalse)
        {
            WhenTrue = whenTrue;
            WhenFalse = whenFalse;
        }

        [ConstructorArgument("WhenTrue")]
        public T WhenTrue { get; set; }

        [ConstructorArgument("WhenFalse")]
        public T WhenFalse { get; set; }

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values == null)
                return DependencyProperty.UnsetValue;

            var booleans = values.Where(_ => _ is bool).ToArray();
            return booleans.Any(_ => (bool) _) ? WhenTrue : WhenFalse;
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