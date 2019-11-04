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

namespace Uppgift7
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
            double num1, num2, modulo, result;
            int result2;

            num1 = double.Parse(boxNum1.Text);
            num2 = double.Parse(boxNum2.Text);

            result = num1 / num2;
            result2 = (int)result;
            boxInt.Text = result2.ToString();

            modulo = num1 % num2;
            boxRest.Text = modulo.ToString();


        }
    }
}
