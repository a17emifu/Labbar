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

namespace Uppgift15
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        string result, counter;
        int vowelsCount = 0;
        char[] charArray;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Metoden för att veta om ett tecken är en vokal eller inte
        public void IsVowel(string a)
        {
            charArray = a.ToArray();    // Tecken som matas in är i arrayen

            // Arrayen för alla vokaler skapas (facit)
            string vowelcheck = "aiueoöäåyAIUEOÖÄÅY";
            char[] vowel;
            vowel = vowelcheck.ToArray();

            char[] findall = Array.FindAll(charArray, vowel.Contains);  // alla gemensamma innehåll i charArray och vowel hittas och läggs in i arrayen
            counter = NumberOfVowels(findall); // metoden för att räkna antalet vokaler kallas och returnerar i variabler

            // For-loopar för att skriva om texten till "ö(Ö)"
            int i, j;
            for (i = 0; a.Length > i; i++)
            {
                for (j = 0; vowelcheck.Length > j; j++)
                {
                    if (charArray[i] == vowel[j])
                    {
                        Jibberish(i);   // metoden för att byta vokaler till "ö (Ö)" kallas
                    }
                 }
            }
            result = string.Join("", charArray);    // arrayens innehåll placeras till string
            txtResult.Text = result;
        }

        // Metoden för att räkna antalet vokaler 
        public string NumberOfVowels(char[] a)
        {
            for (int i = 0; a.Length > i; i++)
            {
                vowelsCount++;
            }
            
            return vowelsCount.ToString();
        }

        // Metoden för att vokaler översättas till "ö (Ö)"
        public void Jibberish(int a)
        {
            // Arrayen för stora bokstäver skapas
            char[] vowelsBig;
            string bigs = "AIUEOÖÄÅY";
            vowelsBig = bigs.ToArray();

            // Arrayen för små bokstäver skapas
            char[] vowelsSmall;
            string smalls = "aiueoöäåy";
            vowelsSmall = smalls.ToArray();
            
            // For-loop används för att placera arrayar 
            for (int i =0; i < bigs.Length; i++)
            {
                if(charArray[a] == vowelsBig[i]) // Om vokaler är stora
                {
                    charArray[a] = 'Ö';
                }
                else if (charArray[a]== vowelsSmall[i]) // om vokaler är små
                {
                    charArray[a] = 'ö';
                }
            }
        }

        // När knappen trycks på
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string input, result;
            input = boxInput.Text;
            result = txtResult.Text;

            IsVowel(input);  // Metoden kallas
            txtVowels.Text = counter;  // antalet vokaler

            vowelsCount = 0; // För att räkna antalet vokaler igen

        }
    }
}
