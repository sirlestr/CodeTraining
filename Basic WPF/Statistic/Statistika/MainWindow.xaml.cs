using System.Collections.Immutable;
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
using System.Drawing;

namespace Statistika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.IsDefault = true;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //button.IsDefault = true;
            if (String.IsNullOrEmpty(CislaTextBox.Text))
            {
                MessageBox.Show("Zadejte cisla");
            }
            else
            {
                string[] retezce = CislaTextBox.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                int[] cisla = new int[retezce.Length];
                for (int i = 0; i < retezce.Length; i++)
                {
                    cisla[i] = int.Parse(retezce[i]);



                }
                SoucetLAbel.Content = cisla.Sum();
                NejmensiLabel.Content = cisla.Min();
                NejvyssiLabel.Content = cisla.Max();
                PrumerLabel.Content = cisla.Average();

                int[] cislaVzestupne = new int[cisla.Length];
                int[] cislaSestupne = new int[cisla.Length];
                Array.Copy(cisla, cislaVzestupne, cisla.Length);
                Array.Sort(cislaVzestupne);
                Array.Copy(cislaVzestupne, cislaSestupne, cisla.Length);
                Array.Reverse(cislaSestupne);

                if (comboBox.SelectedIndex == 0)
                {
                    SerazenoLabel.Content = "";
                    for (int i = 0; i < cislaVzestupne.Length; i++)
                    {
                        SerazenoLabel.Content += cislaVzestupne[i] + ", ";
                    }
                    //SerazenoLabel.Content = cislaVzestupne.ToString(); ;
                }
                else
                {
                    SerazenoLabel.Content = "";
                    for (int i = cislaVzestupne.Length - 1; i >= 0; i--)
                    {
                        SerazenoLabel.Content += cislaVzestupne[i] + ", ";
                    }
                }
            }


        }

    }
}