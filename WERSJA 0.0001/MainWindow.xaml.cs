using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SPNZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student.InicjalizacjaGracza();
            var newW = new Pokoj();
            newW.Show();
            this.Visibility = Visibility.Hidden; ;
            newW.Show();
         
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var newW = new Opcje();
            newW.Show();
        }

        private readonly string nazwaPliku = "save.txt";

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
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
                Gracz.UstawWartosciGracza(Convert.ToInt32(dane[27]), Convert.ToInt32(dane[28]), Convert.ToInt32(dane[0]), Convert.ToInt32(dane[29]), Convert.ToInt32(dane[30]), Convert.ToInt32(dane[31]));
                Ekwipunek.ekwipunek_ilosci[0] = Convert.ToInt32(dane[1]);
                Ekwipunek.ekwipunek_ilosci[1] = Convert.ToInt32(dane[2]);
                Ekwipunek.ekwipunek_ilosci[2] = Convert.ToInt32(dane[3]);
                Ekwipunek.ekwipunek_ilosci[3] = Convert.ToInt32(dane[4]);
                Ekwipunek.ekwipunek_ilosci[4] = Convert.ToInt32(dane[5]);

                Ekwipunek.Bron wczytanaBron = new Ekwipunek.Bron(Convert.ToString(dane[6]), Convert.ToInt32(dane[7]), Convert.ToInt32(dane[8]), Convert.ToInt32(dane[9]), Convert.ToInt32(dane[10]), Convert.ToInt32(dane[11]), Convert.ToInt32(dane[12]));
                Ekwipunek.posiadanaBron = wczytanaBron;

                Ekwipunek.Zbroja wczytanaZbroja = new Ekwipunek.Zbroja(Convert.ToString(dane[13]), Convert.ToInt32(dane[14]), Convert.ToInt32(dane[15]), Convert.ToInt32(dane[16]), Convert.ToInt32(dane[17]), Convert.ToInt32(dane[18]), Convert.ToInt32(dane[19]));
                Ekwipunek.posiadanaZbroja = wczytanaZbroja;

                Obozowisko.Dom wczytanyDom = new Obozowisko.Dom(Convert.ToString(dane[20]), Convert.ToInt32(dane[21]), Convert.ToInt32(dane[22]), Convert.ToInt32(dane[23]), Convert.ToInt32(dane[24]), Convert.ToInt32(dane[25]), Convert.ToInt32(dane[26]));
                Obozowisko.Dom.posiadany_dom = wczytanyDom;

                Gracz.czas = Convert.ToDateTime(dane[32]);

                strumienOdczytu.Close();
                plik.Close();
                AktualizujWartosci();

            }
        }

    }
}
