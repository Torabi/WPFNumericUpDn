using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WPFNumericUpDn
{
    public class FloatNumber : GenericNumber<float>
    {
        
        /// <summary>
        /// construc a constrain Float number
        /// </summary>
        /// <param name="value"><inheritdoc/></param>
        /// <param name="min"><inheritdoc/></param>
        /// <param name="max"><inheritdoc/></param>
        /// <param name="inc"><inheritdoc/></param>
        /// <param name="decimals"><inheritdoc/></param>
        public FloatNumber(float value,float min,float max, float inc, int decimals):base(value,min,max,inc,decimals) { }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        internal override Regex _regex => (_min < 0) ? signedDecimal : unSignedDecimal;
        
            
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        internal override bool ConvertToValue(out float result)
        {
            return float.TryParse(_stringValue, out result);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        internal override float decrement()
        {
            return _value - _increment;
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        internal override float increment()
        {
            return _value + _increment;
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>

        internal override string FormatString => $"F{_decimals}";
    }
}
