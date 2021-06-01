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
    /// Logika interakcji dla klasy EGZAMIN.xaml
    /// </summary>
    public partial class EGZAMIN : Window
    {
        public EGZAMIN()
        {
            InitializeComponent();
        }

        int punkty = 0;
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            punkty++;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            punkty++;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            punkty++;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            punkty++;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newW = new Pokoj();
            newW.Show();
            this.Close();
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {
            punkty++;
        }

        private void RadioButton_Checked_7(object sender, RoutedEventArgs e)
        {
            punkty++;
        }
    }
}
