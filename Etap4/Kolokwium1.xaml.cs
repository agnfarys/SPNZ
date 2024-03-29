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
using System.Windows.Shapes;

namespace SPNZ
{
    /// <summary>
    /// Logika interakcji dla klasy Kolokwium1.xaml
    /// </summary>
    public partial class Kolokwium1 : Window
    {
        public Kolokwium1()
        {
            InitializeComponent();
        }
        int punkty = 0;
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            punkty++;
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            punkty ++;
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            punkty ++;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if((punkty==2)||(punkty==3))
            {
                MessageBox.Show("BRAWO!!! \n Udało ci się zaliczyć kolokwium!", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
                Event.Kolokwium();
                Student.ZmianaKolokwium();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ujebałeś kolokwium... \n Ucz się więcej!", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
                
                this.Close();
            }
           
        }
    }
}
