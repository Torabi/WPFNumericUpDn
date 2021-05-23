using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFNumericUpDown;

namespace WPFNumericUpDnDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            integerControl.DATA = new IntegerNumber(3, -50, 50);

            floatControl.DATA = new FloatNumber(-4.5f, -25, 34.5f,0.5f,2);

            doubleControl.DATA = new DoubleNumber(10, -23.5, 100.00083, 2.5,4);
            
        }
    }
}
