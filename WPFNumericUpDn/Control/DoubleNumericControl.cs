using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNumericUpDn
{
    public class DoubleNumericControl : GenericNumericControl<double>
    {
        /// <summary>
        /// default constructor for double numbder with 4 decimals (default value 0)
        /// </summary>
        public DoubleNumericControl()
        {
            // assign a default value 
            DATA = new DoubleNumber(0, double.NegativeInfinity, double.PositiveInfinity, 1,4);
            
        }
    }
}
