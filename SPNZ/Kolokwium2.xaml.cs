using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Logika interakcji dla klasy Kolokwium2.xaml
    /// </summary>
    public partial class Kolokwium2 : Window
    {
        public Kolokwium2()
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((punkty == 2) || (punkty == 3))
            {
                SoundPlayer simplesound = new SoundPlayer(Properties.Resources.miszynpassd);
                simplesound.Play();
                MessageBox.Show("BRAWO!!! \n Udało ci się zaliczyć kolokwium!", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
                Event.Kolokwium();
                Student.ZmianaKolokwium();
                this.Close();
                Student.Psycha();
            }
            else
            {
                SoundPlayer simplesound = new SoundPlayer(Properties.Resources.miszynnotpassd);
                simplesound.Play();
                MessageBox.Show("Nie zaliczyłeś kolokwium, OCENA: 2,0 \n Ucz się więcej!", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
                Student.ZmianaKolokwium();
                this.Close();
                Student.Psycha();
            }
        }
    }
    
}
