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



namespace Uppgift11
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        // int för rätt, fel håll
        int front;
        int back;

        public MainWindow()
        {
            InitializeComponent();
            
        }
        // Metoden för att räkna gånger (rätt eller fel håll)
        public int GetFrontAndBack(int a, int b)
        {
            // int a = procent för hur mycket otur
            // int b = slumpa tal mellan 0-100
            if (b > a)
            {
                back++; // + 1 gång för fel håll
                return back;
            }
            else
            {
                front++; // + 1 gång för rätt håll
                return front;
            }
        }

        // För sliderns knappar 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            slider.Value = slider.Value - 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            slider.Value = slider.Value + 1;
        }
    
        // För att starta kalkylatorn
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int perNum = int.Parse(txtPer.Text); // procent för hur mycket otur
            int tries = int.Parse(boxTries.Text); // antalet försök
            int randam;
            Random slump = new Random(); // klassen Random skapas

            for (int i = 0; i <tries; i++) // loopen för att räkna gånger (rätt/fel håll)
            {
                 randam = slump.Next(101); // slumpa tal mellan 0-100
                 GetFrontAndBack(perNum, randam); // Metoden kallas med variabler som parametrar
            }

            txtsuccess.Text = front.ToString();
            txtfail.Text = back.ToString();
            back = 0;
            front = 0;
        }
    }
}
