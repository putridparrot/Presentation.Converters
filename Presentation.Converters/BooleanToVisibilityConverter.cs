using System.Windows;
using System.Windows.Data;

namespace PutridParrot.Presentation.Converters
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BooleanToVisibilityConverter : BooleanToValueConverter<Visibility>
    {
        public BooleanToVisibilityConverter() :
            base(Visibility.Visible, Visibility.Collapsed)
        {
        }

        public BooleanToVisibilityConverter(Visibility whenTrue, Visibility whenFalse) :
            base(whenTrue, whenFalse)
        {
        }
    }
}