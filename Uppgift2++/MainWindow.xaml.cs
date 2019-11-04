﻿using System;
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

namespace Uppgift2
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

        private void Namnbtn_Click(object sender, RoutedEventArgs e)
        {
            string name = TextName.Text;
            string msg;

            if ((name == "Skriv ditt namn") || (name == ""))
            {
                msg = "Jag vill veta ditt namn!";
            }
            else
            {
                msg = $"Hej {name} ! Hoppas du mår bra";
            }
            MessageBox.Show(msg);
        }
    }
}
