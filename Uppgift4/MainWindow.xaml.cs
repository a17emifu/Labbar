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

namespace Uppgift4
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

        string text = "Du klickade på knappen ";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text = text + btnM.Content;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TxtBox.Text = text + btnS.Content;
        }

        private void btnTi_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text = text + btnTi.Content;
        }

        private void btnO_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text = text + btnO.Content;
        }

        private void btnTo_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text = text + btnTo.Content;
        }

        private void btnF_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text = text + btnF.Content;
        }

        private void btnL_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text = text + btnL.Content;
        }
    }
}
