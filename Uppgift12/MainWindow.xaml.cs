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

namespace Uppgift12
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0; // int för array (räknare)
        List<int> arraylist = new List<int>(); // arraylist för array
        int[] values; // initerar array för siffrorna

        public MainWindow()
        {
            InitializeComponent();
            listbox.ItemsSource = null; // den ska ”börja om” när värdet knyts till kontrollen
        }

        // Metoden för att mata in tal igen och räkna medelvärde
        private void Avarage()
        {
            boxNum.Clear();
            boxNum.Focus();

            double average = arraylist.Average(); // medelvärde
            boxAverage.Text = average.ToString();
        }

        // Metoden för att starta om 
        private void Reset()
        {
            // Lådornas innehåll rensas
            boxNum.Clear();
            boxAverage.Clear();
            arraylist.Clear();

            listbox.ItemsSource = null; // den ska ”börja om” när värdet knyts till kontrollen
            boxNum.Focus(); // markören ställs i textrutan för "Mata in tal”
            i = 0; // för att array skapas igen
            btnOK.IsEnabled = true; // kan trycka på knappen "OK" igen
        }

        // När knappen "OK" trycks på
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int num;
            num = int.Parse(boxNum.Text); // för att visa tal som matas in

            // If-satser för att visa tal som matas in och medelvärde
            if (i < 4)  // fem tal kan matas in i arrayen
            {
                arraylist.Add(num); // talet som matas in läggs in i arraylisten
                values = arraylist.ToArray(); // arraylisten läggs in i arrayen
                listbox.ItemsSource = values; // talet visas i listbox 

                Avarage();  //Metoden kallas

                i++; // räknare för array
            }
            else if (i == 4) // inga mer tal kan matas in
            {
                arraylist.Add(num);
                values = arraylist.ToArray();
                listbox.ItemsSource = values;

                Avarage();  //Metoden kallas
                i++; // räknare för array

                btnOK.IsEnabled = false; // knappen "OK" kan inte tryckas på
            }
        }

        // När knappen "Nollställ" trycks på
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset(); // Metoden kallas
        }
    }
}
