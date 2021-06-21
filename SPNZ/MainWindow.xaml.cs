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
using System.Reflection;
using System.Resources;

namespace SPNZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer simplesound = new SoundPlayer(Properties.Resources.menu);
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

        

       

    }
}
