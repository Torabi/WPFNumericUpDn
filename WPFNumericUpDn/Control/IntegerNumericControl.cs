using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNumericUpDn
{
    public class IntegerNumericControl : GenericNumericControl<int>
    {
        /// <summary>
        /// represnet the integer number without constrain (default value 0)
        /// </summary>
        public IntegerNumericControl()
        {
            DATA = new IntegerNumber(0, int.MinValue, int.MaxValue);
            
        }
    }
}
