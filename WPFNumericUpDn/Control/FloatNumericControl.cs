using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNumericUpDn
{
    public class FloatNumericControl : GenericNumericControl<float>
    {
        /// <summary>
        /// construct a non-constrain float numbder with 2 decimals (default value 0)
        /// </summary>
        public FloatNumericControl()
        {
            DATA = new FloatNumber(0, -float.NegativeInfinity, float.PositiveInfinity, 1,2);
            //dataBinding();
        }
    }
}
