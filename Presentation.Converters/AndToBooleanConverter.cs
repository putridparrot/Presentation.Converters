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
    public class AndToBooleanConverter : AndToValueConverter<bool>
    {
        public AndToBooleanConverter() :
            this(true, false)
        {
            // should be overriden is subclass to be
            // specific to the supported type
        }

        public AndToBooleanConverter(bool whenTrue, bool whenFalse)
        {
            WhenTrue = whenTrue;
            WhenFalse = whenFalse;
        }
    }
}
