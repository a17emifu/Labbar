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

namespace Uppgift9
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            int age = int.Parse(boxAge.Text);
            string name = boxName.Text;
            
            if (age >= 15)
            {
                txt.Text = $"Hej {name}. Du är {age} år gammal och får se alla filmer.";
            }
            else if ((age <= 14) && (age >= 11))
            {
                if(rbtnWithoutA.IsChecked == true)
                {
                    txt.Text = $"Hej {name}. Du är {age} år gammal och då får du se filmer med åldersgräns upp till 11 år.";
                }
                else if (rbtnWithA.IsChecked == true)
                {
                    txt.Text = $"Hej {name}. Du är {age} år gammal. Då får du se filmer med åldersgräns upp till 11 år. Det spelar ingen roll att du går tillsammans med en vuxen.";
                }
            }
            else if ((age < 11) && (age >= 7))
            {
                if(rbtnWithoutA.IsChecked == true)
                {
                    txt.Text = $"Hej {name}. Du är {age} år gammal och då får du se filmer med åldersgräns upp till 7 år.";
                }
                if (rbtnWithA.IsChecked == true)
                {
                    txt.Text = $"Hej {name}. Du är {age} år gammal och får se filmer med åldersgräns upp till 11 år eftersom du har en vuxen med dig.";
                }
            }
            else if (age < 7)
            {
                txt.Text = $"Hej {name}. Du är {age} år gammal och då får du se filmer med barntillåten.";
            }
                   
        }
    }
}
