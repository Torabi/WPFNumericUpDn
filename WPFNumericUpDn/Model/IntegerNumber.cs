using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFNumericUpDn
{
    public class IntegerNumber : GenericNumber<int>
    {
        /// <summary>
        /// construct an contrsianed integer
        /// </summary>
        /// <param name="value"><inheritdoc/></param>
        /// <param name="min"><inheritdoc/></param>
        /// <param name="max"><inheritdoc/></param>
        /// <param name="inc"><inheritdoc/></param>
        public IntegerNumber(int value,int min,int max, int inc = 1) : base(value, min, max, inc,0) { }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        internal override int increment()
        {
            return _value + _increment;

        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        internal override int decrement()
        {
            return _value - _increment;
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        internal override bool ConvertToValue(out int result)
        {
            return int.TryParse(_stringValue, out result);
                
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        internal override Regex _regex => (_min < 0) ? signedInteger : unSignedInteger;
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        internal override string FormatString => "";
    }
}
