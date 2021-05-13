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
    /// Logika interakcji dla klasy Gra.xaml
    /// </summary>
    public partial class Pokoj : Window
    {
        public Pokoj()
        {
            InitializeComponent();
            AktualizujStatystyki();
        }

        private void OpcjaGra(object sender, RoutedEventArgs e)
        {
            var newW = new OpcjeGra();
            newW.Show();
        }

        private void Discord(object sender, RoutedEventArgs e)
        {
            var pozar = Akademik.Pozar();
            var energia = Student.Energia();
            if(pozar==true)
            {
                AktualizujStatystyki();
            }
            else if (energia >= 10)
            {
                Akademik.Discord();
                AktualizujStatystyki();
            }
            else
            {
                komunikat.Text = "Masz za ma³o energii, aby wykonaæ czynnoœæ";
            } 
        }

        private void Gry(object sender, RoutedEventArgs e)
        {
            var pozar = Akademik.Pozar();
            Akademik.Pozar();
            var energia = Student.Energia();
            if (pozar == true)
            {
                AktualizujStatystyki();
            }
            else if(energia >= 20)
            {
                Akademik.Gry();
                AktualizujStatystyki();  
            }
            else
            {
                komunikat.Text = "Masz za ma³o energii, aby wykonaæ czynnoœæ";
            }
           
        }

        private void Zajecia(object sender, RoutedEventArgs e)
        {
            var energia = Student.Energia();
            var godzina = Student.Godzina();
            var dzien = Student.Dzien();
            var pozar = Akademik.Pozar();
            Akademik.Pozar();

            if (Akademik.Pozar() == true)
            {
                AktualizujStatystyki();
            }
            else if ((dzien % 7 == 0) || (dzien % 7 == 6))
            {
                komunikat.Text = "Zajêcia odbywaj¹ siê od poniedzia³ku do pi¹tku";
            }
            else if ((godzina < 7) || (godzina > 16))
            {
                komunikat.Text = "Zajêcia odbywaj¹ siê w godzinach 7-16";
            }
            else if (energia < 30)
            {
                komunikat.Text = "Masz za ma³o energii, aby wykonaæ czynnoœæ";
            }
            else
            {
                Akademik.Zajecia();
                AktualizujStatystyki();
            } 
        }

        private void Etrapez(object sender, RoutedEventArgs e)
        {
            Akademik.Pozar();
            var pozar = Akademik.Pozar();
            var energia = Student.Energia();
            if (Akademik.Pozar() == true)
            {
                AktualizujStatystyki();
            }
            else if (energia >= 20)
            {
                Akademik.Etrapez();
                AktualizujStatystyki(); 
            }
            else
            {
                komunikat.Text = "Masz za ma³o energii, aby wykonaæ czynnoœæ";
            }
           
        }

        private void Lozko(object sender, RoutedEventArgs e)
        {
            Akademik.Spij();
            AktualizujStatystyki();
        }


        private void AktualizujStatystyki()
        {
            energia.Text ="Energia: " +Convert.ToString(Student.Energia());
            checi.Text = "Chêci: "+Convert.ToString(Student.Checi());
            trzezwosc.Text = "TrzeŸwoœæ: "+Convert.ToString(Student.Trzezwosc());
            wiedza.Text = "Wiedza: "+Convert.ToString(Student.Wiedza());
            wspolpraca.Text = "Wspó³praca: "+Convert.ToString(Student.Wspolpraca());

            zegar.Text = Convert.ToString(Student.Godzina()) + ":00";
            //minuta.Text = Convert.ToString(Student.Minuta());
            dzien.Text = "Dzien numer: " + Convert.ToString(Student.Dzien());
            dzientygodnia.Text = Convert.ToString(Student.DzienTygodnia());
        }
    }
}