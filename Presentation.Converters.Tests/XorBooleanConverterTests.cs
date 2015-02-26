using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Presentation.Converters.Tests
{
    public class XorBooleanConverterTests
    {
        [Fact]
        public void XorBooleanConverter_IfContainNonBoolean_ReturnTrue()
        {
            var converter = new XorBooleanConverter();

            var values = new object[] { true, false, 3 };

            object result = converter.Convert(values, null, null, null);
            Assert.True((bool)result);
        }

        [Fact]
        public void XorBooleanConverter_IfTrueAndFalseBoolean_ReturnTrue()
        {
            var converter = new XorBooleanConverter();

            var values = new object[] { true, false, true };

            object result = converter.Convert(values, null, null, null);
            Assert.True((bool)result);
        }

        [Fact]
        public void XorBooleanConverter_IfAllFalseBoolean_ReturnFalse()
        {
            var converter = new XorBooleanConverter();

            var values = new object[] { false, false, false };

            object result = converter.Convert(values, null, null, null);
            Assert.False((bool)result);
        }

        [Fact]
        public void XorBooleanConverter_IfAllTrueBoolean_ReturnFalse()
        {
            var converter = new XorBooleanConverter();

            var values = new object[] { true, true, true };

            object result = converter.Convert(values, null, null, null);
            Assert.False((bool)result);
        }
    }



}
