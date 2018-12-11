using System.Windows.Data;
using System.Windows.Media;

namespace PutridParrot.Presentation.Converters
{
    [ValueConversion(typeof(bool), typeof(Brush))]
    public class BooleanToBrushConverter : BooleanToValueConverter<Brush>
    {
        public BooleanToBrushConverter() :
            base(Brushes.Green, Brushes.Red)
        {
        }

        public BooleanToBrushConverter(Brush whenTrue, Brush whenFalse) :
            base(whenTrue, whenFalse)
        {
        }
    }
}