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

namespace Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            var answer = double.Parse(FirstNumber.Text) + double.Parse(SecondNumber.Text);
            CalculationResult.Content = answer;
        }

        private void Subtract(object sender, RoutedEventArgs e)
        {
            var answer = double.Parse(FirstNumber.Text) - double.Parse(SecondNumber.Text);
            CalculationResult.Content = answer;
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            var answer = int.Parse(FirstNumber.Text) * double.Parse(SecondNumber.Text);
            CalculationResult.Content = answer;
        }

        private void Divide(object sender, RoutedEventArgs e)
        {
            var answer = double.Parse(FirstNumber.Text) / double.Parse(SecondNumber.Text);
            CalculationResult.Content = answer;
        }
    }
}
