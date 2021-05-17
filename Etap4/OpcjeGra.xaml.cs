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
    }
}
