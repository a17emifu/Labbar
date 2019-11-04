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

namespace Uppgift13
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
            string texts = box.Text;
            string search = boxSearch.Text;
            int count = 0; // för räknare
            
            string[] textarray = new string[texts.Length]; // array för texter
            
            // for-loop för att placera varje bokstav i en array
            for (int i = 0; i < texts.Length; i++)
            {
                textarray[i] = texts.Substring(i, 1); 

                // if satsen för att räkna bokstäver
                if (textarray[i] == search)
                {
                    count++;
                }
            }
            boxResult.Text = $"Hitade bokstaven {search} {count} gånger.";
            count = 0;
        }
    }
}
