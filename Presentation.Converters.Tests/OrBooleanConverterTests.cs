﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Presentation.Converters.Tests
{
    public class OrBooleanConverterTests
    {
        [Fact]
        public void OrBooleanConverter_IfContainNonBoolean_ReturnTrue()
        {
            var converter = new OrBooleanConverter();

            var values = new object[] { true, false, 3 };

            object result = converter.Convert(values, null, null, null);
            Assert.True((bool)result);
        }

        [Fact]
        public void OrBooleanConverter_IfTrueAndFalseBoolean_ReturnTrue()
        {
            var converter = new OrBooleanConverter();

            var values = new object[] { true, false, true };

            object result = converter.Convert(values, null, null, null);
            Assert.True((bool)result);
        }

        [Fact]
        public void OrBooleanConverter_IfAllFalseBoolean_ReturnFalse()
        {
            var converter = new OrBooleanConverter();

            var values = new object[] { false, false, false };

            object result = converter.Convert(values, null, null, null);
            Assert.False((bool)result);
        }

        [Fact]
        public void OrBooleanConverter_IfAllTrueBoolean_ReturnTrue()
        {
            var converter = new OrBooleanConverter();

            var values = new object[] { true, true, true };

            object result = converter.Convert(values, null, null, null);
            Assert.True((bool)result);
        }
    }


}
