using System;
using System.Media;
using System.Windows;

namespace SPNZ
{
    public class Event
    {
        protected static int kolokwium;
        protected static int liczba_odwiedzin;
        private static int zaliczenie;

        public static void ZmianaOdwiedzin()
        {
            liczba_odwiedzin++;
        }
        
        public static void Piwo()
        {
            SoundPlayer simplesound = new SoundPlayer(Properties.Resources.piwo1);
            simplesound.Play();
            Student.ZmianaEnergia(-15);
            Student.ZmianaCheci(5);
            Student.ZmianaTrzezwosc(-15);
            Student.ZmianaGodzina(1);
            

        }

        public static void Flany()
        {
            SoundPlayer simplesound = new SoundPlayer(Properties.Resources.flany1);
            simplesound.Play();
            Student.ZmianaEnergia(-20);
            Student.ZmianaCheci(8);
            Student.ZmianaGodzina(3);
            Student.ZmianaTrzezwosc(-20);
            Student.ZmianaWspolpraca(2);
        }

        public static void Integracja()
        {
            SoundPlayer simplesound = new SoundPlayer(Properties.Resources.integracja1);
            simplesound.Play();
            Student.ZmianaEnergia(-50);
            Student.ZmianaCheci(20);
            Student.ZmianaTrzezwosc(-50);
            Student.ZmianaWspolpraca(10);
            Student.ZmianaGodzina(12);
        }

        public static bool Interwencja()
        {
            Random rnd = new Random();
            int trzezwy = Student.Trzezwosc();
            //if (rnd.Next(0, 750) >= trzezwy)
            if (trzezwy < 50)
            {
                if (rnd.Next(0, 70) > trzezwy)
                {
                    Student.ZmianaGodzina(24);
                    Student.ZmianaTrzezwosc(100);
                    Student.ZmianaCheci(-70);
                    Student.ZmianaEnergia(-20);
                    SoundPlayer simplesound = new SoundPlayer(Properties.Resources.wasted);
                    simplesound.Play();
                    MessageBox.Show("Policja!!! \n Jedziesz z nami na wytrzeźwiałke", "Policja", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static int Zaliczenie()
        {
            return zaliczenie;
        }
        public static void Kolokwium()
        {
            zaliczenie++;
        }

        public static void Egzamin()
        {
            var d = Student.Dzien();
            var k = Student.Kolos();
            var w = Student.Wiedza();
            var z = Event.Zaliczenie();
            var g = Student.Godzina();

            if ((k == 4) && (d >= 29) && ((g >= 7) && (g <= 16)))
            {
                if (w >= 80)
                {
                    if (z >= 2)
                    {
                        var newW = new EGZAMIN();
                        newW.Show();
                    }
                    else
                    {
                        SoundPlayer simplesound = new SoundPlayer(Properties.Resources.miszynnotpassd);
                        simplesound.Play();
                        MessageBox.Show("Nie zaliczyłeś co najmniej 2 kolosów. Nie możesz przystąpić do egzaminu.\n OCENA: 2,0 \n Do zobaczenia na pierwszym semestrze!\n Koniec gry!", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
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
                else
                {
                    SoundPlayer simplesound = new SoundPlayer(Properties.Resources.miszynnotpassd);
                    simplesound.Play();
                    MessageBox.Show("Zbyt mała wiedza. Nie zdałeś egzaminu, OCENA: 2,0 \n Do zobaczenia na pierwszym semestrze!\n Koniec gry!", "Kolokwium", MessageBoxButton.OK, MessageBoxImage.Warning);
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
        }

    }
}
