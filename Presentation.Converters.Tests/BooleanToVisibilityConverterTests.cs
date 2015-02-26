using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xunit;

namespace Presentation.Converters.Tests
{
    public class BooleanToVisibilityConverterTests
    {
        [Fact]
        public void BooleanToVisibilityConverter_EnsureDefaultForTrueIsVisible()
        {
            var converter = new BooleanToVisibilityConverter();

            Visibility visibility = (Visibility)converter.Convert(true, null, null, null);
            Assert.Equal(Visibility.Visible, visibility);
        }

        [Fact]
        public void BooleanToVisibilityConverter_EnsureDefaultForFalseIsCollapsed()
        {
            var converter = new BooleanToVisibilityConverter();

            Visibility visibility = (Visibility)converter.Convert(false, null, null, null);
            Assert.Equal(Visibility.Collapsed, visibility);
        }

        [Fact]
        public void BooleanToVisibilityConverter_WhenTrueIsNotVisible_EnsureTrueReturnsWhenTrueValue()
        {
            var converter = new BooleanToVisibilityConverter
            {
                WhenTrue = Visibility.Hidden,
                WhenFalse = Visibility.Visible
            };

            Visibility visibility = (Visibility)converter.Convert(true, null, null, null);
            Assert.Equal(Visibility.Hidden, visibility);
        }

        [Fact]
        public void BooleanToVisibilityConverter_WhenFalseIsNotCollapsed_EnsureFalseReturnsWhenFalseValue()
        {
            var converter = new BooleanToVisibilityConverter
            {
                WhenTrue = Visibility.Collapsed,
                WhenFalse = Visibility.Hidden
            };

            Visibility visibility = (Visibility)converter.Convert(false, null, null, null);
            Assert.Equal(Visibility.Hidden, visibility);
        }
    }
}
