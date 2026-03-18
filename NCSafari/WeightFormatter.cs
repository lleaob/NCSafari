using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    internal class WeightFormatter(Animal animal, CultureInfo region) : IFormattable
    {
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            string result = string.Empty;
            return result;
        }
    }
}
