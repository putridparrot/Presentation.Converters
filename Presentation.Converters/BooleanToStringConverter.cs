using System.Windows;
using System.Windows.Data;

namespace PutridParrot.Presentation.Converters
{
    /// <summary>
    /// Can be used for localization of True and False
    /// </summary>
    [ValueConversion(typeof(bool), typeof(string))]
    public class BooleanToStringConverter : BooleanToValueConverter<string>
    {
        public BooleanToStringConverter() :
            base("True", "False")
        {
        }

        public BooleanToStringConverter(string whenTrue, string whenFalse) :
            base(whenTrue, whenFalse)
        {
        }
    }
}