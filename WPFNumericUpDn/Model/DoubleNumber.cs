using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WPFNumericUpDn
{
    /// <summary>
    /// this class represent a formatted double number with constrains
    /// </summary>
    public class DoubleNumber : GenericNumber<double>
    {
        /// <summary>
        /// construct a constrained double number
        /// </summary>
        /// <param name="value"><inheritdoc/></param>
        /// <param name="min"><inheritdoc/> </param>
        /// <param name="max"><inheritdoc/></param>
        /// <param name="inc"><inheritdoc/></param>
        /// <param name="decimals"><inheritdoc/></param>
        public DoubleNumber(double value,double min,double max,double inc,int decimals) : base(value, min, max, inc,decimals) { }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        internal override Regex _regex => (_min < 0) ? signedDecimal : unSignedDecimal;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        internal override bool ConvertToValue(out double result)
        {
            return double.TryParse(_stringValue, out result);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        internal override double decrement()
        {
            return _value - _increment;
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        internal override double increment()
        {
            return _value + _increment;
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        internal override string FormatString => $"N{_decimals}";
    }
}
