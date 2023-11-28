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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace konyvtar_foprogram
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void KonyvtarButtonClick(object sender, RoutedEventArgs e)
        {
            jobbOldal.Children.Clear();
            // Könyvtár menüpont logika
        }

        // Hasonló függvények a Felhasználók és Információ menüpontokhoz
        private void FelhasznalokButtonClick(object sender, RoutedEventArgs e)
        {
            jobbOldal.Children.Clear();
            // Felhasználók menüpont logika
        }

        private void InformacioButtonClick(object sender, RoutedEventArgs e)
        {
            jobbOldal.Children.Clear();
            // Információ menüpont logika
        }
    }

    internal class KonyvKartya : UIElement
    {
        private string v;

        public KonyvKartya(string v)
        {
            this.v = v;
        }
    }
}