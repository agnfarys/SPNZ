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
            if ((punkty == 5) || (punkty == 6))
            {
                this.Close();
                SoundPlayer simplesound = new SoundPlayer(@"C:\Users\Zielony\Desktop\STUDIA\Elektronika 2 semestr\Programowanie obiektowe\SPNZ\miszynpassd.wav");
                simplesound.Play();
                MessageBox.Show("BRAWO!!! \n Udało ci się zdać semestr!\n Koniec gry.", "Egzamin", MessageBoxButton.OK, MessageBoxImage.Warning);
                var okna = App.Current.Windows;
                for (int i = okna.Count - 1; i > 0; i--)
                {
                    okna[i].Close();
                }
                var newW = new MainWindow();
                newW.Show();
                okna[0].Close();

            }
            else
            {
                this.Close();
                SoundPlayer simplesound = new SoundPlayer(@"C:\Users\Zielony\Desktop\STUDIA\Elektronika 2 semestr\Programowanie obiektowe\SPNZ\miszynnotpassd.wav");
                simplesound.Play();
                MessageBox.Show("Nie zdałeś egzaminu, OCENA: 2,0 \n Do zobaczenia na pierwszym semestrze!\n Koniec gry!", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
                var okna = App.Current.Windows;
                for (int i = okna.Count - 1; i > 0; i--)
                {
                    okna[i].Close();
                }
                var newW = new MainWindow();
                newW.Show();
                okna[0].Close();
            }


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
