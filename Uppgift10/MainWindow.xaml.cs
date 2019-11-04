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

namespace Uppgift10
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           // Knappen "gissa" kan inte trycka på i början
            btnSuggest.IsEnabled = false;
            
        }
        // För slumpa och gissa tal
        public int random, suggestNum;
        // För att räkna antalet försök
        public int i = 0;

        //Metod 1 för att gissa tal igen
        private void NumClear()
        {
            i = 0;
            random = 0;
            suggestNum = 0;
            boxNum.Clear();
        }

        // Metod 2 för att slumpa tal skapas
        public int GetRandom()
        {
            Random slump = new Random();
            random = slump.Next(1001);
            return random;
        }

        // När knappen "Slumpa tal" trycks på
        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            // Metod 2 kallas
            GetRandom();

            // Knappen "gissa" kan trycka på nu
            btnSuggest.IsEnabled = true;

            boxAnswer.Text = "Gissa tal!";
        }

        // När knappen "Gissa" trycks på
        private void btnSuggest_Click(object sender, RoutedEventArgs e)
        {
            suggestNum = int.Parse(boxNum.Text);
            int diffirence = random - suggestNum;

                // Om nummer är för låg
                if ((suggestNum < random) && (diffirence >= 100))
                {
                    boxAnswer.Text = "Oh, du är inte ens nära. Du gissade alldeles för lågt!";
                    i++;
                }

                // Om nummer är lite låg
                else if ((suggestNum < random) && (diffirence < 100))
                {
                    boxAnswer.Text = "Jättenära, men lite låg!";
                    i++;
                }

                // Det är lättare att räkna på diffirensen om talet är positivt
                if (diffirence < 0)
                {
                    diffirence = diffirence * -1;

                        // Om nummer är lite hög
                        if ((suggestNum > random) && (diffirence < 100))
                        {
                            boxAnswer.Text = "Jättenära, men lite hög!";
                            i++;
                        }
                        // Om nummer är för hög
                        else if ((suggestNum > random) && (diffirence >= 100))
                        {
                            boxAnswer.Text = "Oh, du är inte ens nära. Du gissade alldeles för högt!";
                            i++;
                        }
                }
                // Rätt nummer
                if (suggestNum == random)
                {
                    boxAnswer.Text = $"Tadaa! Du hittade rätt nummer, grattis! Du klarade detta på {i} försök.";

                    //Metod 1 kallas
                    NumClear();

                    // Knappen "gissa" kan inte trycka på igen
                    btnSuggest.IsEnabled = false;
                }
        }
    }
}
