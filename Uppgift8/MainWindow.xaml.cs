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

namespace Uppgift8
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

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            double num1, num2, result;
            num1 = double.Parse(box1.Text);
            num2 = double.Parse(box2.Text);

            // För addition
            if(rbtnPlus.IsChecked == true)
            {
                result = num1 + num2;
                boxResult.Text = Math.Round(result, 2).ToString();
            }
            // För subtraktion
            else if(rbtnMinus.IsChecked == true)
            {
                result = num1 - num2;
                boxResult.Text = Math.Round(result, 2).ToString();
            }
            // För multikation
            else if (rbtnMulti.IsChecked == true)
            {
                result = num1 * num2;
                boxResult.Text = Math.Round(result, 2).ToString();
            }
            // För division
            else if (rbtnDiv.IsChecked == true)
            {
                result = num1 / num2;
                boxResult.Text = Math.Round(result, 2).ToString();
            }

        }
    }
}
