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
using System.Windows.Shapes;

namespace SPNZ
{
    /// <summary>
    /// Logika interakcji dla klasy Kolokwium3.xaml
    /// </summary>
    public partial class Kolokwium3 : Window
    {
        public Kolokwium3()
        {
            InitializeComponent();
        }

        int punkty = 0;
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newW = new Pokoj();
            newW.Show();
            this.Close();
        }

        private void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {
            punkty++;
        }

        private void RadioButton_Checked_12(object sender, RoutedEventArgs e)
        {
            punkty++;
        }

        private void RadioButton_Checked_13(object sender, RoutedEventArgs e)
        {
            punkty++;
        }
    }
    
}
