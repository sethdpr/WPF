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

namespace WPF
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


        // Event handlers voor knoppen
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Home geselecteerd!");
        }

        private void BestellingenButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bestellingen geselecteerd!");
        }

        private void ProductenButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Producten geselecteerd!");
        }

        private void KlantenButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Klanten geselecteerd!");
        }
    }
}