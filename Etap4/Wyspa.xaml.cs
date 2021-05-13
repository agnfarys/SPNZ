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
    /// Logika interakcji dla klasy Wyspa.xaml
    /// </summary>
    public partial class Wyspa : Window
    {
        public Wyspa()
        {
            InitializeComponent();
            AktualizujStatystyki();
        }

        private void Piwo(object sender, RoutedEventArgs e)
        {
            Event.Interwencja();
            var policja = Event.Interwencja();
            var energia = Student.Energia();
            if (Event.Interwencja() == true)
            {
                AktualizujStatystyki();
                var okna = App.Current.Windows;
                for (int i = okna.Count - 1; i > 0; i--)
                {
                    okna[i].Close();
                }
                var newW = new Pokoj();
                newW.Show();
                okna[0].Close();
            }
            else if (energia >= 10)
            {
                Event.Piwo();
                AktualizujStatystyki();
            }
            else
            {
                komunikat.Text = "Masz za mało energii, aby wykonać czynność";
            }
        }

        private void Flany(object sender, RoutedEventArgs e)
        {
            var energia = Student.Energia();
            var godzina = Student.Godzina();
            var dzien = Student.Dzien();
            var policja = Event.Interwencja();
            Event.Interwencja();

            if (Event.Interwencja() == true)
            {
                AktualizujStatystyki();
                var okna = App.Current.Windows;
                for (int i = okna.Count - 1; i > 0; i--)
                {
                    okna[i].Close();
                }
                var newW = new Pokoj();
                newW.Show();
                okna[0].Close();
            }
            else if ((godzina < 19) && (godzina > 5))
            {
                komunikat.Text = "Flany są dostępne w godzinach 19-5";
            }
            else if (energia >= 25)
            {
                Event.Flany();
                AktualizujStatystyki();
            }
            else
            {
                komunikat.Text = "Masz za mało energii, aby wykonać czynność";
            }
        }

        private void Integracja(object sender, RoutedEventArgs e)
        {
            
            var policja = Event.Interwencja();
            var energia = Student.Energia();
            var godzina = Student.Godzina();
            var dzien = Student.Dzien();
            Event.Interwencja();

            if (Event.Interwencja() == true)
            {
                AktualizujStatystyki();
                var okna = App.Current.Windows;
                for (int i = okna.Count - 1; i > 0; i--)
                {
                    okna[i].Close();
                }
                var newW = new Pokoj();
                newW.Show();
                okna[0].Close();
            }
            else if ((dzien % 7 != 5) || (dzien % 7 != 6))
            {
                komunikat.Text = "Integracja jest dostępna w piątki i soboty";
            }
            else if ((godzina < 19) || (godzina > 5))
            {
                komunikat.Text = "Integracja jest dostępna w godzinach 19-5";
            }
            else if (energia >= 60)
            {
                Event.Integracja();
                AktualizujStatystyki();
            }
            else
            {
                komunikat.Text = "Masz za mało energii, aby wykonać czynność";
            }
        }

        private void Opcje(object sender, RoutedEventArgs e)
        {
            var newW = new OpcjeGra();
            newW.Show();
        }

        private void Pokoj(object sender, RoutedEventArgs e)
        {
            var okna = App.Current.Windows;
            for (int i = okna.Count - 1; i > 0; i--)
            {
                okna[i].Close();
            }
            var newW = new Pokoj();
            newW.Show();
            okna[0].Close();
        }

        private void AktualizujStatystyki()
        {
            energia.Text = "Energia: " + Convert.ToString(Student.Energia());
            checi.Text = "Chęci: " + Convert.ToString(Student.Checi());
            trzezwosc.Text = "Trzeźwość: " + Convert.ToString(Student.Trzezwosc());
            wiedza.Text = "Wiedza: " + Convert.ToString(Student.Wiedza());
            wspolpraca.Text = "Współpraca: " + Convert.ToString(Student.Wspolpraca());

            zegar.Text = Convert.ToString(Student.Godzina()) + ":00";
            //minuta.Text = Convert.ToString(Student.Minuta());
            dzien.Text = "Dzien numer: " + Convert.ToString(Student.Dzien());
            dzientygodnia.Text = Convert.ToString(Student.DzienTygodnia());
        }
    }
}
