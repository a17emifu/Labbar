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

namespace Uppgift6
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double num1, num2, result =0;

        // För addition
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(boxTal1.Text);
            num2 = double.Parse(boxTal2.Text);
            result = num1 + num2;
            boxKvot.Text = result.ToString();
        }
        // För subtraktion
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(boxTal1.Text);
            num2 = double.Parse(boxTal2.Text);
            result = num1 - num2;
            boxKvot.Text = result.ToString();
        }
        // För multiplikation
        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(boxTal1.Text);
            num2 = double.Parse(boxTal2.Text);
            result = num1 * num2;
            boxKvot.Text = result.ToString();
        }
        // För Division
        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(boxTal1.Text);
            num2 = double.Parse(boxTal2.Text);
            result = num1 / num2;
            boxKvot.Text = result.ToString();
        }

        // För att rensa
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            boxTal1.Clear();
            boxTal2.Clear();
            boxKvot.Clear();
        }
    }
}
