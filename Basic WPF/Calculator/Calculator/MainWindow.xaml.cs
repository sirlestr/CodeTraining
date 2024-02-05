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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calcualte calc = new Calcualte();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Content.ToString();

            textBlockResult.Text += number;
        }

        private void button_Equals_Click(object sender, RoutedEventArgs e)
        {
           string result = calc.Calc(textBlockResult.Text);
            textBlockResult.Text = result;
        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            textBlockResult.Text = "";
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textBlockResult.Text = calc.RemoveLastChar(textBlockResult.Text);
        }
    }
}