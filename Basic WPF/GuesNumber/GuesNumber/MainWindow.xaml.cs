using System.Security.Cryptography.X509Certificates;
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

namespace GuesNumber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   

    public partial class MainWindow : Window
    {
        private GuestControll myControll;

        public MainWindow()
        {
            InitializeComponent();
            ProgramMessageLabel.Content = "";
            
        }

        public void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            myControll = new GuestControll(0,0);
            if (myControll.GenerateGuess(Convert.ToInt32(RangeComboBox.SelectedIndex)) == 999)
            {
                ProgramMessageLabel.Content = "Nastala divnná chyba, zkus to znovu!";
            }
            else
            {
                ProgramMessageLabel.Content = "Myslím si číslo, můžeš začít hádat";
            }
            

        }

        private void GuessButton_Click(object sender, RoutedEventArgs e)
        {
            int userGuess = Convert.ToInt32(GuessTextBox.Text);
            if (myControll.GuessNumber(userGuess).Contains("WIN"))
            {
                MessageBox.Show("Vyhrál jsi!!! " + "\nTvuj počet pokusů je:" + myControll.Count);
            }
            else
            {
                ProgramMessageLabel.Content = myControll.GuessNumber(userGuess);
            }
           

        }
    }
}