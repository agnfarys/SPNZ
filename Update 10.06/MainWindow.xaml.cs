using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SPNZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer simplesound = new SoundPlayer(@"C:\Users\sklep\Desktop\SPNZ\menu.wav");
        public MainWindow()
        {
            InitializeComponent();
            simplesound.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student.InicjalizacjaGracza();
            var okna = App.Current.Windows;
            for (int i = okna.Count - 1; i > 0; i--)
            {
                okna[i].Close();
            }
            var newW = new Pokoj();
            newW.Show();
            okna[0].Close();
          
            simplesound.Stop();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            simplesound.Stop();
            Environment.Exit(0);
          
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var newW = new Instrukcja();
            newW.Show();
        }

        

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string nazwaPliku = "save.txt";

            if (File.Exists(nazwaPliku))
            {
                FileStream plik = new FileStream(nazwaPliku, FileMode.Open, FileAccess.Read);
                StreamReader strumienOdczytu = new StreamReader(nazwaPliku);
                string[] linijki = strumienOdczytu.ReadToEnd().ToString().Split('\n');
                string[] dane = new string[linijki.Length];
                for (int i = 0; i < linijki.Length - 1; i++)
                {
                    int znak = linijki[i].IndexOf('=');
                    dane[i] = linijki[i].Substring(znak + 1);
                    dane[i] = Regex.Replace(dane[i], "\r", string.Empty);
                }

                int energia = Student.Energia();
                int chec_do_zycia = Student.Checi();
                int trzezwosc_umyslu = Student.Trzezwosc();
                int wiedza = Student.Wiedza();
                int wspolpraca = Student.Wspolpraca();
                int kolos = Student.Kolos();
                int godzina = Student.Godzina();
                int minuta = Student.Minuta();
                int dzien = Student.Dzien();
                int liczba_odwiedzin = Student.Odwiedziny();
   
                energia = Convert.ToInt32(dane[0]);
                chec_do_zycia= Convert.ToInt32(dane[1]);
                trzezwosc_umyslu= Convert.ToInt32(dane[2]);
                wiedza = Convert.ToInt32(dane[3]);
                wspolpraca = Convert.ToInt32(dane[4]);
                kolos = Convert.ToInt32(dane[5]);
                godzina = Convert.ToInt32(dane[6]);
                minuta = Convert.ToInt32(dane[7]);
                dzien = Convert.ToInt32(dane[8]);
                liczba_odwiedzin = Convert.ToInt32(dane[9]);

              

                strumienOdczytu.Close();
                plik.Close();



                var okna = App.Current.Windows;
                for (int i = okna.Count - 1; i > 0; i--)
                {
                    okna[i].Close();
                }
                var newW = new Pokoj();
                newW.Show();
                okna[0].Close();
                simplesound.Stop();

            }
            else
            {
                MessageBox.Show("Brak pliku do wczytania", "Wczytywanie", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

    }
}
