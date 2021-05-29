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
        }

        private void Discord(object sender, RoutedEventArgs e)
        {
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
                    komunikat.Text = "Energia -10, Chêci do ¿ycia +10, Wspó³praca +5, Godzina +2, TrzeŸwoœæ +5";
                    Akademik.Discord();
                    AktualizujStatystyki();
                }
            }
            else
            {
                komunikat.Text = "Masz za ma³o energii, aby wykonaæ czynnoœæ";
            }
        }

        private void Gry(object sender, RoutedEventArgs e)
        {
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
                    komunikat.Text = "Energia -20, Chêci do ¿ycia +20, Godzina +2, TrzeŸwoœæ +5";
                    Akademik.Gry();
                    AktualizujStatystyki();
                }
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
                            komunikat.Text = "Energia -30, Chêci do ¿ycia -20, Godzina +3, Wiedza +40";
                            Akademik.Zajecia();
                            AktualizujStatystyki();
                        }
                    }
                    else
                    {
                        komunikat.Text = "Masz za ma³o energii, aby wykonaæ czynnoœæ";
                    }
                }
                else
                {
                    komunikat.Text = "Zajêcia odbywaj¹ siê w godzinach 7-16";
                }
            }
            else
            {
                komunikat.Text = "Zajêcia odbywaj¹ siê od poniedzia³ku do pi¹tku";
            }
        }

        private void Etrapez(object sender, RoutedEventArgs e)
        {
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
                    komunikat.Text = "Energia -20, Chêci do ¿ycia -15, Godzina +2, Wiedza +25, TrzeŸwoœæ +5";
                    Akademik.Etrapez();
                    AktualizujStatystyki();
                }
            }
            else
            {
                komunikat.Text = "Masz za ma³o energii, aby wykonaæ czynnoœæ";
            }
        }

        private void Lozko(object sender, RoutedEventArgs e)
        {
            komunikat.Text = "Energia +30, Godzina +7, Chêci do ¿ycia +20, TrzeŸwoœæ +20";
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

        private void Wyspa(object sender, RoutedEventArgs e)
        {
            //SoundPlayer simplesound = new SoundPlayer(@"C:\Users\Zielony\Desktop\STUDIA\Elektronika 2 semestr\Programowanie obiektowe\SPNZ\przechodzenie.wav");
            //simplesound.Play();
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

           
            Student.Psycha();

                if((k==1) && (d==8))
                {
                    if (w >= 15)
                    {
                        var newW = new Kolokwium1();
                        newW.Show();
                    }
                    else
                    {
                        Student.ZmianaKolokwium();
                        MessageBox.Show("Masz za ma³o wiedzy, aby napisaæ kolokwium. \n Ocena za kolokwium 2,0", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else if((k==2) && (d==15))
                {
                    if (w >= 35)
                    {
                     

                    }
                    else
                    {
                      Student.ZmianaKolokwium();
                      MessageBox.Show("Masz za ma³o wiedzy, aby napisaæ kolokwium. \n Ocena za kolokwium 2,0", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else if((k==3) && (d==22))
                {
                    if (w >= 70)
                    {
                       

                    }
                    else
                    {
                        Student.ZmianaKolokwium();
                        MessageBox.Show("Masz za ma³o wiedzy, aby napisaæ kolokwium. \n Ocena za kolokwium 2,0", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Kolokwium nie jest dostêpne. \n Kolokwia odbywaj¹ siê co poniedzia³ek, w dniach: 8, 15, 22", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            AktualizujStatystyki();
        }

    }
}