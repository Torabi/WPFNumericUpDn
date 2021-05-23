using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFNumericUpDn
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public abstract partial class NumbericControl : UserControl
    {

        #region members
        ICommand command;
        Timer timer;

        internal abstract Regex _regexPattern { get; }
        #endregion
        /// <summary>
        /// main constructor
        /// </summary>
        public NumbericControl()
        {
            InitializeComponent();
            timer = new Timer()
            {
                Interval = 400
            };
            timer.Elapsed += Timer_Elapsed;
        }


        /// <summary>
        /// run the current command every 100 milliseconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (command.CanExecute(null))
                command.Execute(null);
            timer.Interval = 100;
        }
        /// <summary>
        /// sets the command and starts the timer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void incBTN_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            command = ((Button)sender).Command;
            timer.Start();
        }
        /// <summary>
        /// stops the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void incBTN_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            //command = ((Button)sender).Command;
            timer.Stop();
            timer.Interval = 400;


        }
        /// <summary>
        /// check if the content of the text box is valid. only if valid then it is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            e.Handled = !_regexPattern.IsMatch(e.Text);
        }

    }
}