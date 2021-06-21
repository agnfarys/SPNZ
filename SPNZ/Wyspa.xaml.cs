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
            var policja = Event.Interwencja();
            var energia = Student.Energia();
            Event.Egzamin();
            if (energia >= 10)
            {
                if (policja == true)
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
                else
                {
                    komunikat.Text = "Energia -15, Chęci do życia +5, Trzeźwość -15, Godzina +1";
                    Event.ZmianaOdwiedzin();
                    Event.Piwo();
                    AktualizujStatystyki();
                }
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
            var policja = Event.Interwencja();
            if ((godzina >= 19) || (godzina <= 5))
            {
                if (energia >= 25)
                {
                    if (policja == true)
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
                    else
                    {
                        komunikat.Text = "Energia -20, Chęci do życia +8, Godzina +3, Trzeźwość -20, Współpraca +2";
                        Event.ZmianaOdwiedzin();
                        Event.Flany();
                        AktualizujStatystyki();
                    }
                }
                else
                {
                    komunikat.Text = "Masz za mało energii, aby wykonać czynność";
                }
            }
            else
            {
                komunikat.Text = "Flany są dostępne w godzinach 19-5";
            }
            Event.Egzamin();
        }

        private void Integracja(object sender, RoutedEventArgs e)
        {
         
            var policja = Event.Interwencja();
            var energia = Student.Energia();
            var godzina = Student.Godzina();
            int dzien = Student.Dzien();
            if ((dzien == 5 ) || (dzien == 6 ) || (dzien == 12 ) || (dzien == 13) || (dzien == 19 ) || (dzien == 20 ) || (dzien == 26 ) || (dzien == 27))
            {
                if ((godzina >= 19) || (godzina <= 1))
                {
                    if (energia >= 60)
                    {
                        if (policja == true)
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
                        else
                        {
                            komunikat.Text = "Energia -50, Chęci do życia +20, Trzeźwość -50, Współpraca +10, Godzina +12";
                            Event.ZmianaOdwiedzin();
                            Event.Integracja();
                            AktualizujStatystyki();
                        }
                    }
                    else
                    {
                        komunikat.Text = "Masz za mało energii, aby wykonać czynność";
                    }
                }
                else
                {
                    komunikat.Text = "Integracja jest dostępna w godzinach 19-5";
                }
            }
            else
            {
                komunikat.Text = "Integracja jest dostępna w piątki i soboty";
            }
            Event.Egzamin();
        }

        private void Opcje(object sender, RoutedEventArgs e)
        {
           
            var newW = new OpcjeGra();
            newW.Show();
        }

        private void Pokoj(object sender, RoutedEventArgs e)
        {
           
            
            SoundPlayer simplesound = new SoundPlayer(Properties.Resources.swoosh);
            simplesound.Play();
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
            dzien.Text = "Dzien numer: " + Convert.ToString(Student.Dzien());
            dzientygodnia.Text = Convert.ToString(Student.DzienTygodnia());
        }
    }
}
