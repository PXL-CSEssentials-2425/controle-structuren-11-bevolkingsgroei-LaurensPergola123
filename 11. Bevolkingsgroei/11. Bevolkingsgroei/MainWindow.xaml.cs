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

namespace _11._Bevolkingsgroei
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

        private void eraseButton_Click(object sender, RoutedEventArgs e)
        {
            landTextBox.Clear();
            populationTextBox.Clear();
            growPercentageTextBox.Clear();
            resultTextBox.Clear();
            landTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(!double.TryParse(populationTextBox.Text, out double population) || population <= 0)
                {
                    MessageBox.Show("Voer een geldig getal in!", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (!double.TryParse(growPercentageTextBox.Text, out double growPercentage) || growPercentage <= 0)
                {
                    MessageBox.Show("Voer een geldig getal in!", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                double doublePopulation = population * 2;
                int numberOfYears = 0;
                double growFactor = 1 + growPercentage / 100;

                while (population < doublePopulation) ;
                {
                    resultTextBox.Text = $"Verdubbeling bevolking in {landTextBox.Text} na {numberOfYears} jaar.\r\n " +
                        $"Nieuwe bevolkingsaantal op dat moment is {population}";
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}