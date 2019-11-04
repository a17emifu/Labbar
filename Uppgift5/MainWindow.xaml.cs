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

namespace Uppgift5
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
            int num1, num2, total =0;
            num1 = int.Parse(boxTal1.Text);
            num2 = int.Parse(boxTal2.Text);
            total = num1 + num2;
            boxSumma.Text = total.ToString();

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            boxTal1.Clear();
            boxTal2.Clear();
            boxSumma.Clear();

        }
    }
}
