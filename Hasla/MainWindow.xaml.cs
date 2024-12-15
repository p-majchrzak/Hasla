using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hasla
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Haslo = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Dane pracownika: {Imie.Text} {Nazwisko.Text} {Stanowsko.Text} Tester Hasło: {Haslo}");
        }

        private void Generuj_Click(object sender, RoutedEventArgs e)
        {
            Haslo = "";
            string znakiSpecjalne = "!@#$%^&*()_+-=";
            string maleZnaki = "abcdefghijklmnopqrstuvwxyz";
            string duzeLitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string liczby = "0123456789";
            //1 znak z specjalne jesli zaznaczono, jedem zmal z cyfr jesli zaznaczono, jeden znak z wieklkich liter -||-\
            Random random = new Random();
            for (int i = 0; i < int.Parse(IloscZnakow.Text); i++)
            {
                if (MaleLitery.IsChecked == true && i == 0)
                {
                    Haslo += duzeLitery[random.Next(0, duzeLitery.Length + 1)];
                    continue;
                }
                if (ZnakiSpecjalne.IsChecked == true && i == 1)
                {
                    Haslo += znakiSpecjalne[random.Next(0, znakiSpecjalne.Length + 1)];
                    continue;
                }
                if (Cyfry.IsChecked == true && i == 2)
                {
                    Haslo += liczby[random.Next(0, liczby.Length + 1)];
                    continue;
                }
                Haslo += maleZnaki[random.Next(0, maleZnaki.Length + 1)];
            }
            MessageBox.Show(Haslo);
        }
    }
}