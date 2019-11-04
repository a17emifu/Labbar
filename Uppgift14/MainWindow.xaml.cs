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

namespace Uppgift14
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

            public void CharCalc(string a) // Metoden för att veta om att tecken är siffror eller inte
            {
                int birthYear, nowYear, nowAge, countNum;
                //countChar = 0;
                countNum = 0;

                char[] charArray; // Array av typen char skapas 
                charArray = a.ToCharArray(); // Verje tecke placeras i arrayen

                for(int i = 0; a.Length > i; i++) // Undersöker om allt innehåll i arrayen är bokstäver eller siffror 
                {
                    Char.IsLetter(charArray[i]);
                    if (char.IsLetter(charArray[i]) == true)  // När bokstav innehålls i arrayen
                    {}

                    else if (char.IsLetter(charArray[i]) == false) // När innehåll i arrayen inte är bokstäver
                    {
                        countNum++;
                    }
                }

                if (countNum == 4) // För innehållet som är fyra siffror
                {
                    birthYear = int.Parse(a);
                    nowYear = DateTime.Now.Year; // visar nuvarande år
                    nowAge = nowYear - birthYear; // visar nuvarande ålder

                    if (birthYear > nowYear) // När större siffror än nuvarande år matas in
                    {
                        MessageBox.Show("Du måste mata in ditt födelseår!");
                    }
                    else
                    {
                        MessageBox.Show($"Du är {nowAge} år gammal.");
                    }
                }
                else     // när tecken innehåller bokstav
                {
                    MessageBox.Show("Du måste mata in enbart fyra siffror, ange ditt födelseår!");
                }
            }
        
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string input;
            input = boxNum.Text;
            if (input.Length >= 5) // när över fem stycken matas in
            {
                MessageBox.Show("Mata in 4 siffror!");
            }
            else
            {
                CharCalc(input); // metoden kallas
                
            }
        }
    }
}
