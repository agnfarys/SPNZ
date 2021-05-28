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
using System.Windows.Shapes;

namespace SPNZ
{
    /// <summary>
    /// Logika interakcji dla klasy OpcjeGra.xaml
    /// </summary>
    public partial class OpcjeGra : Window
    {
        public OpcjeGra()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var okna = App.Current.Windows;
            for(int i=okna.Count-1;i>0;i--)
            {
                okna[i].Close();
            }
            var newW = new MainWindow();
            newW.Show();
            okna[0].Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private readonly string nazwaPliku = "save.txt";
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
				File.Delete(nazwaPliku);
				FileStream plik = new FileStream(nazwaPliku, FileMode.OpenOrCreate, FileAccess.ReadWrite);
				plik.Seek(0, SeekOrigin.End);
				StreamWriter strumienZapisu = new StreamWriter(plik);

            strumienZapisu.WriteLine("energia=" + Convert.ToString(Student.Energia()));
            strumienZapisu.WriteLine("checi=" + Convert.ToString(Student.Checi()));
            strumienZapisu.WriteLine("trzezwosc=" + Convert.ToString(Student.Trzezwosc()));
            strumienZapisu.WriteLine("wiedza=" + Convert.ToString(Student.Wiedza()));
            strumienZapisu.WriteLine("wspolpraca=" + Convert.ToString(Student.Wspolpraca()));
            strumienZapisu.WriteLine("kolos=" + Convert.ToString(Student.Kolos()));
            strumienZapisu.WriteLine("godzina=" + Convert.ToString(Student.Godzina()));
            strumienZapisu.WriteLine("minuta=" + Convert.ToString(Student.Minuta()));
            strumienZapisu.WriteLine("dzien=" + Convert.ToString(Student.Dzien()));
            strumienZapisu.WriteLine("liczba odwiedzin=" + Convert.ToString(Student.Odwiedziny()));

            strumienZapisu.Close();
			plik.Close();

            MessageBox.Show("Stan gry zapisany.", "Zapis gry", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
