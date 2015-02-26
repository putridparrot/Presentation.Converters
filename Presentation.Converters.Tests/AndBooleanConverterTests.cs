using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Presentation.Converters.Tests
{
    public class AndBooleanConverterTests
    {
        [Fact]
        public void AndBooleanConverter_IfContainNonBoolean_ReturnFalse()
        {
            var converter = new AndBooleanConverter();

            var values = new object[] { true, false, 3 };

            object result = converter.Convert(values, null, null, null);
            Assert.False((bool)result);
        }

        [Fact]
        public void AndBooleanConverter_IfTrueAndFalseBoolean_ReturnFalse()
        {
            var converter = new AndBooleanConverter();

            var values = new object[] { true, false, true };

            object result = converter.Convert(values, null, null, null);
            Assert.False((bool)result);
        }

        [Fact]
        public void AndBooleanConverter_IfAllFalseBoolean_ReturnFalse()
        {
            var converter = new AndBooleanConverter();

            var values = new object[] { false, false, false };

            object result = converter.Convert(values, null, null, null);
            Assert.False((bool)result);
        }

        [Fact]
        public void AndBooleanConverter_IfAllTrueBoolean_ReturnTrue()
        {
            var converter = new AndBooleanConverter();

            var values = new object[] { true, true, true };

            object result = converter.Convert(values, null, null, null);
            Assert.True((bool)result);
        }
    }

}
