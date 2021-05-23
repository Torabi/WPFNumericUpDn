using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WPFNumericUpDn
{
    /// <summary>
    /// class represent generic number. any other type must be sub-class of the this class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericNumericControl<T> : NumbericControl where T : struct, IFormattable, IComparable<T>
    {

        /// <summary>
        /// return the regex pattern provided in data source
        /// </summary>
        internal override Regex _regexPattern {
            get{
                if (DATA!=null)
                {
                    return DATA._regex; // return the regex defined in subclass
                }
                else
                {
                    return new Regex("[0-9]+"); // by defualt get only number chars 
                }
            }
        }
        /// <summary>
        /// data source for the textbox 
        /// </summary>
        public GenericNumber<T> DATA
        {
            get { return (GenericNumber<T>)GetValue(DATAProperty); }
            set {
                
                SetValue(DATAProperty, value);
                dataBinding();
            }
        }

        // dependency property for binding
        public static readonly DependencyProperty DATAProperty =
            DependencyProperty.Register("DATA", typeof(GenericNumber<T>), typeof(GenericNumericControl<T>),null);



        /// <summary>
        /// binds the model to UI.
        /// </summary>
        internal void dataBinding()
        {
            // binding the text box 
            Binding text_binding = new Binding("StringValue");
            text_binding.Source = DATA;
            text_binding.Mode = BindingMode.TwoWay;
            text_binding.UpdateSourceTrigger = UpdateSourceTrigger.LostFocus; // value updtes as text being modified
            BindingOperations.SetBinding(textBox, TextBox.TextProperty, text_binding);

            // binding the increment button
            incBTN.Command = DATA.IncrementCommand;
            decBTN.Command = DATA.DecrementCommand;
        }
        /// <summary>
        /// empty constructor is require for XML code
        /// </summary>
        protected GenericNumericControl() 
        {
            
        }

        /// <summary>
        /// constructor can be used from code.
        /// </summary>
        /// <param name="data">data to be binded with text box</param>
        public GenericNumericControl(GenericNumber<T> data )
        {
            DATA = data;        
        }
    }
}
