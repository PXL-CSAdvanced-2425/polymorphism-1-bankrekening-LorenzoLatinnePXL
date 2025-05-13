using Bankrekening.Entities;
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

namespace Bankrekening
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Zichtrekening _zichtRekening = new Zichtrekening(2000, "PXL Digital", "Elfde-Liniestraat 26, 3500 Hasselt");
        private Spaarrekening _spaarRekening = new Spaarrekening(9500, "PXL Digital", "Elfde-Liniestraat 26, 3500 Hasselt");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSaldo_Click(object sender, RoutedEventArgs e)
        {
            LblSaldoZichtrekening.Content = "€ " + _zichtRekening.HuidigSaldo.ToString("f2");
            LblSaldoSpaarrekening.Content = "€ " + _spaarRekening.HuidigSaldo.ToString("f2");
        }

        private void BtnRente_Click(object sender, RoutedEventArgs e)
        {
            LblRenteZichtrekening.Content = "€ " + (_zichtRekening.BerekenRente()).ToString("f2");
            LblRenteSpaarrekening.Content = "€ " + (_spaarRekening.BerekenRente()).ToString("f2");
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GbxZichtrekening_Loaded(object sender, RoutedEventArgs e)
        {
            LblZichtrekening.Content = _zichtRekening.ToString();
            LblZichtrekening.Foreground = Brushes.Blue;
            LblSpaarrekening.Content = _spaarRekening.ToString();
            LblSpaarrekening.Foreground = Brushes.Blue;
        }

        private void TxtBedrag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                bool isValidNumber = double.TryParse(TxtBedrag.Text, out double amount);
                
                if (amount < 0)
                {
                    _zichtRekening.CreditSaldo(amount);
                    _spaarRekening.CreditSaldo(amount);
                }
                else
                {
                    _zichtRekening.DebetSaldo(amount);
                    _spaarRekening.DebetSaldo(amount);
                }
            }
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            LblSaldoZichtrekening.Content = "€ " + _zichtRekening.HuidigSaldo.ToString("f2");
            LblSaldoSpaarrekening.Content = "€ " + _spaarRekening.HuidigSaldo.ToString("f2");
            LblRenteZichtrekening.Content = "€ " + (_zichtRekening.BerekenRente()).ToString("f2");
            LblRenteSpaarrekening.Content = "€ " + (_spaarRekening.BerekenRente()).ToString("f2");
        }
    }
}