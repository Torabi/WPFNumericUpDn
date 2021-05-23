using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFNumericUpDn
{
    class IncrementCommand<T> :ICommand where T : struct, IFormattable, IComparable<T>
    {
        public event EventHandler CanExecuteChanged;
        public IncrementCommand  (GenericNumber<T> modelView) 
        {
            gmv = modelView;
        }
        GenericNumber<T> gmv; 
        public bool CanExecute(object parameter)
        {
            return gmv.Value.CompareTo(gmv._max) < 0;
        }

        public void Execute(object parameter)
        {
            gmv.Increment();   
        }
    }
}
