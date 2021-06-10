using System;
using System.Media;
using System.Windows;
using System.Windows.Media;

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
            MediaPlayer mplayer = new MediaPlayer();
            mplayer.Open(new Uri("piwo.wav", UriKind.Relative));
            mplayer.Play();
            Student.ZmianaEnergia(-10);
            Student.ZmianaCheci(3);
            Student.ZmianaTrzezwosc(-10);
            Student.ZmianaGodzina(1);
            

        }

        public static void Flany()
        {
            MediaPlayer mplayer = new MediaPlayer();
            mplayer.Open(new Uri("flany.wav", UriKind.Relative));
            mplayer.Play();
            Student.ZmianaEnergia(-15);
            Student.ZmianaCheci(7);
            Student.ZmianaGodzina(2);
            Student.ZmianaTrzezwosc(-20);
            Student.ZmianaWspolpraca(3);
        }

        public static void Integracja()
        {
            MediaPlayer mplayer = new MediaPlayer();
            mplayer.Open(new Uri("integracja.wav", UriKind.Relative));
            mplayer.Play();
            Student.ZmianaEnergia(-50);
            Student.ZmianaCheci(15);
            Student.ZmianaTrzezwosc(-40);
            Student.ZmianaWspolpraca(6);
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
                    MediaPlayer mplayer = new MediaPlayer();
                    mplayer.Open(new Uri("wasted.wav", UriKind.Relative));
                    mplayer.Play();
                    MessageBox.Show("Policja!!! Jedziesz z nami na wytrzeźwiałke", "Policja", MessageBoxButton.OK, MessageBoxImage.Warning);
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

        }
    }
}
