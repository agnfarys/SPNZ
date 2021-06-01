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
            Student.ZmianaKolokwium();
        }

        private void Discord(object sender, RoutedEventArgs e)
        {
            Student.ZmianaKolokwium();
            var pozar = Akademik.Pozar();
            var energia = Student.Energia();
            if(energia >= 10)
            {
                if(pozar==true)
                {
                    AktualizujStatystyki();
                }
                else
                {
                    komunikat.Text = "Energia -10, Ch�ci do �ycia +10, Wsp�praca +5, Godzina +2, Trze�wo�� +5";
                    Akademik.Discord();
                    AktualizujStatystyki();
                }
            }
            else
            {
                komunikat.Text = "Masz za ma�o energii, aby wykona� czynno��";
            }
        }

        private void Gry(object sender, RoutedEventArgs e)
        {
            Student.ZmianaKolokwium();
            var pozar = Akademik.Pozar();
            var energia = Student.Energia();
            if (energia >= 20)
            {
                if (pozar == true)
                {
                    AktualizujStatystyki();
                }
                else
                {
                    komunikat.Text = "Energia -20, Ch�ci do �ycia +20, Godzina +2, Trze�wo�� +5";
                    Akademik.Gry();
                    AktualizujStatystyki();
                }
            }
            else
            {
                komunikat.Text = "Masz za ma�o energii, aby wykona� czynno��";
            }
        }

        private void Zajecia(object sender, RoutedEventArgs e)
        {
            Student.ZmianaKolokwium();
            var energia = Student.Energia();
            var godzina = Student.Godzina();
            var dzien = Student.Dzien();
            var pozar = Akademik.Pozar();

            if ((dzien % 7 != 0) || (dzien % 7 != 6))
            {
                if ((godzina >= 7) && (godzina <= 16))
                {
                    if (energia >= 30)
                    {
                        if (pozar == true)
                        {
                            AktualizujStatystyki();
                        }
                        else
                        {
                            komunikat.Text = "Energia -30, Ch�ci do �ycia -20, Godzina +3, Wiedza +40";
                            Akademik.Zajecia();
                            AktualizujStatystyki();
                        }
                    }
                    else
                    {
                        komunikat.Text = "Masz za ma�o energii, aby wykona� czynno��";
                    }
                }
                else
                {
                    komunikat.Text = "Zaj�cia odbywaj� si� w godzinach 7-16";
                }
            }
            else
            {
                komunikat.Text = "Zaj�cia odbywaj� si� od poniedzia�ku do pi�tku";
            }
        }

        private void Etrapez(object sender, RoutedEventArgs e)
        {
            Student.ZmianaKolokwium();
            var pozar = Akademik.Pozar();
            var energia = Student.Energia();
            if (energia >= 20)
            {
                if (pozar == true)
                {
                    AktualizujStatystyki();
                }
                else
                {
                    komunikat.Text = "Energia -20, Ch�ci do �ycia -15, Godzina +2, Wiedza +25, Trze�wo�� +5";
                    Akademik.Etrapez();
                    AktualizujStatystyki();
                }
            }
            else
            {
                komunikat.Text = "Masz za ma�o energii, aby wykona� czynno��";
            }
        }

        private void Lozko(object sender, RoutedEventArgs e)
        {
            Student.ZmianaKolokwium();
            komunikat.Text = "Energia +30, Godzina +7, Ch�ci do �ycia +20, Trze�wo�� +20";
            Akademik.Spij();
            AktualizujStatystyki();
        }

        private void AktualizujStatystyki()
        {
            energia.Text ="Energia: " +Convert.ToString(Student.Energia());
            checi.Text = "Ch�ci: "+Convert.ToString(Student.Checi());
            trzezwosc.Text = "Trze�wo��: "+Convert.ToString(Student.Trzezwosc());
            wiedza.Text = "Wiedza: "+Convert.ToString(Student.Wiedza());
            wspolpraca.Text = "Wsp�praca: "+Convert.ToString(Student.Wspolpraca());

            zegar.Text = Convert.ToString(Student.Godzina()) + ":00";
            //minuta.Text = Convert.ToString(Student.Minuta());
            dzien.Text = "Dzien numer: " + Convert.ToString(Student.Dzien());
            dzientygodnia.Text = Convert.ToString(Student.DzienTygodnia());
        }

        private void Wyspa(object sender, RoutedEventArgs e)
        {
            Student.ZmianaKolokwium();
            SoundPlayer simplesound = new SoundPlayer(@"C:\Users\Zielony\Desktop\STUDIA\Elektronika 2 semestr\Programowanie obiektowe\SPNZ\przechodzenie.wav");
            simplesound.Play();
            var okna = App.Current.Windows;
            for (int i = okna.Count - 1; i > 0; i--)
            {
                okna[i].Close();
            }
            var newW = new Wyspa();
            newW.Show();
            okna[0].Close();
        }



        private void Kolokwium(object sender, RoutedEventArgs e)
        {
            var d = Student.Dzien();
            var k = Student.Kolos();
            var w = Student.Wiedza();
            var z = Event.Zaliczenie();
           
           

                if((k==1) && (d==8))
                {
                    Student.Psycha();
                    if (w >= 15)
                    {
                         var newW = new Kolokwium1();
                         newW.Show();
                    }
                    else
                    {
                         MessageBox.Show("Masz za ma�o wiedzy, aby napisa� kolokwium. \n Ocena za kolokwium 2,0", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else if((k==2) && (d==15))
                {
                     Student.Psycha();
                     if (w >= 30)
                     {
                         var newW = new Kolokwium2();
                         newW.Show();
                     }
                     else
                     {
                         MessageBox.Show("Masz za ma�o wiedzy, aby napisa� kolokwium. \n Ocena za kolokwium 2,0", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
                     }
                }
                else if((k==3) && (d==22))
                {
                Student.Psycha();
                if (w >= 60)
                    {
                        var newW = new Kolokwium3();
                        newW.Show();
                    }
                    else
                    {
                        MessageBox.Show("Masz za ma�o wiedzy, aby napisa� kolokwium. \n Ocena za kolokwium 2,0", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else if((k==4) && (d==29))
                {
                Student.Psycha();
                if ((w>=90) &&(z>=2))
                    {
                    var newW = new EGZAMIN();
                    newW.Show();
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    MessageBox.Show("Kolokwium nie jest dost�pne. \n Kolokwia odbywaj� si� co poniedzia�ek, w dniach: 8, 15, 22", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            AktualizujStatystyki();
        }

    }
}