using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace PutridParrot.Presentation.Converters
{
    /// <summary>
    /// Abstract Base class for specializations of the BooleanToXXXConverter
    /// classes.
    ///
    /// If the object passed into Convert or ConvertBack is not of the
    /// expected type a DependencyProperty.UnsetValue is returned to
    /// allow the binding's fallback to work 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BooleanToValueConverter<T> : MarkupExtension,
        IValueConverter
    {
        public BooleanToValueConverter() :
            this(default(T), default(T))
        {
            // should be overriden is subclass to be
            // specific to the supported type
        }

        public BooleanToValueConverter(T whenTrue, T whenFalse)
        {
            WhenTrue = whenTrue;
            WhenFalse = whenFalse;
        }

        [ConstructorArgument("WhenTrue")]
        public T WhenTrue { get; set; }

        [ConstructorArgument("WhenFalse")]
        public T WhenFalse { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        private T Convert(bool b)
        {
            return b ? WhenTrue : WhenFalse;
        }

        private bool ConvertBack(T value)
        {
            return value.Equals(WhenTrue);
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool b ? Convert(b) : DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is T v ? ConvertBack(v) : DependencyProperty.UnsetValue;
        }
    }
}
