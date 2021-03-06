﻿using System;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;

namespace PutridParrot.Presentation.Converters
{
    /// <summary>
    /// Takes multiple values and acts as an Xor
    /// </summary>
    [ValueConversion(typeof(bool), typeof(bool))]
    public class XorBooleanConverter : XorToValueConverter<bool>
    {
        public XorBooleanConverter() :
            this(true, false)
        {
            // should be overriden is subclass to be
            // specific to the supported type
        }

        public XorBooleanConverter(bool whenTrue, bool whenFalse)
        {
            WhenTrue = whenTrue;
            WhenFalse = whenFalse;
        }
    }
}
