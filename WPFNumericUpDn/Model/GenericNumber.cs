using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFNumericUpDn
{
    /// <summary>
    /// class provide basic functionality for different number classes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class GenericNumber<T> : INotifyPropertyChanged where T : struct, IFormattable, IComparable<T>
    {
        /// <summary>
        /// construct a GenericNumber class based on the Type (T)
        /// </summary>
        /// <param name="value">current value</param>
        /// <param name="min">minimum value</param>
        /// <param name="max">maximum value</param>
        /// <param name="inc">increment value used to increment or decrement the current value</param>
        /// <param name="decimals">number of deciams shown on the text box</param>
        protected GenericNumber (T value,T min, T max,T inc, int decimals)
        {
            
            _min = min;
            _max = max;
            _increment = inc;
            _decimals = decimals;
            Value = value;

        }
        /// <summary>
        /// number of decimals shown in the textbox
        /// </summary>
        internal int _decimals = 0;
        /// <summary>
        /// the current value 
        /// </summary>
        internal T _value;
        /// <summary>
        /// minimum value
        /// </summary>
        internal T _min;
        /// <summary>
        /// maximum value
        /// </summary>
        internal T _max;
        /// <summary>
        /// value used to increment or decrement the current value
        /// </summary>
        internal T _increment;
        /// <summary>
        /// the string value corressponding to the current value 
        /// </summary>
        internal string _stringValue;
        /// <summary>
        /// returns <c>_value + _increment</c>
        /// </summary>
        /// <returns></returns>
        internal abstract T increment();
        /// <summary>
        /// returns <c>_value - _increment</c>
        /// </summary>
        /// <returns></returns>
        internal abstract T decrement();
        /// <summary>
        /// provides the regex pattern for filtering numerical value based on the type (T) and lower bound (_min)
        /// </summary>
        internal abstract Regex _regex { get; }
        /// <summary>
        /// increment the current value by adding the <c>_increment</c> value to the current value
        /// </summary>
        public void Increment()
        {
            T temp = increment();
            if (temp.CompareTo(_max) > 0)
            {
                Value = _max;
            }
            else
            {
                Value = temp;
            }
        }
        /// <summary>
        /// decrement the current value by subtracting the <c>_increment</c> value from the current value
        /// </summary>
        public void Decrement()
        {
            T temp = decrement();
            if (temp.CompareTo(_min) < 0)
            {
                Value = _min;
            }
            else
            {
                Value = temp;
            }
        }
        /// <summary>
        /// get and sets the current value
        /// </summary>
        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                StringValue = ConvertToString();
            }
        }
        /// <summary>
        /// The string value shown in the text box .
        /// this property fires the <c>NotifyPropertyChanged</c>
        /// </summary>
        public string StringValue
        {
            get
            {
                return _stringValue;
            }
            set
            {
               
                _stringValue = value;
                if (_stringValue == string.Empty)
                    return;
                if (!ConvertToValue(out T temp))
                    return;
                
                if (temp.CompareTo(_min) < 0 )
                {
                    _value = _min;
                    _stringValue = ConvertToString();
                }else if ( temp.CompareTo(_max) > 0)
                {
                    _value = _max;
                    _stringValue = ConvertToString();
                }
                else
                {
                    _value = temp;
                    _stringValue = ConvertToString();
                }
                NotifyPropertyChanged();
            }
        }
        /// <summary>
        /// convert the current value to the string
        /// </summary>
        /// <returns></returns>
        string ConvertToString()
        {
            return _value.ToString(FormatString, CultureInfo.CurrentCulture);
        }
        /// <summary>
        /// override this method to parse the current string to type (T)
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        internal abstract bool ConvertToValue(out T result);
        /// <summary>
        /// override to provide the format string used to format the string in the text box
        /// </summary>
        internal abstract string FormatString { get; }
        /// <summary>
        /// Property changed event
        /// </summary>

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        /// <summary>
        /// create an instance of the <c>IncrementCommand</c> for the increment button in UI 
        /// </summary>
        internal IncrementCommand<T> IncrementCommand => new IncrementCommand<T>(this);
        /// <summary>
        /// create an instance of the <c>DecrementCommand</c> for the increment button in UI 
        /// </summary>
        internal DecrementCommmand<T> DecrementCommand => new DecrementCommmand<T>(this);

        /// <summary>
        /// filters the signed decimals
        /// </summary>
        internal Regex signedDecimal = new Regex(@"^-?[0-9]*(\.?)[0-9]*$");
        /// <summary>
        /// filters the unsigned decimals
        /// </summary>
        internal Regex unSignedDecimal = new Regex(@"^[0-9]*(\.?)[0-9]*$");
        /// <summary>
        /// filters the signed integers
        /// </summary>
        internal Regex signedInteger = new Regex(@"^-?[0-9]+$");
        /// <summary>
        /// filters the unsigned integers
        /// </summary>
        internal Regex unSignedInteger = new Regex(@"^[0-9]+$");


    }
}
