using System.Windows.Data;

namespace PutridParrot.Presentation.Converters
{
    /// <summary>
    /// Takes multiple values and acts as an Or
    /// </summary>
    [ValueConversion(typeof(bool), typeof(bool))]
    public class OrToBooleanConverter : OrToValueConverter<bool>
    {
        public OrToBooleanConverter() :
            this(true, false)
        {
            // should be overriden is subclass to be
            // specific to the supported type
        }

        public OrToBooleanConverter(bool whenTrue, bool whenFalse)
        {
            WhenTrue = whenTrue;
            WhenFalse = whenFalse;
        }
    }
}
