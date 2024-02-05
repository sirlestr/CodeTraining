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

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            DataContext = list;
        }
        private ItemList list = new ItemList();
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                list.AddItem(textBoxItem.Text);
                //list.Save();
                textBoxItem.Text = ""; 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba v zadání", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {
            
                try
                {
                    if (listBox.SelectedItems.Count == 0 && listBox.Items.Count > 0)
                    {
                        listBox.SelectedIndex = 0;
                        list.RemoveItem((ShoppingItem)listBox.SelectedItem);
                    }
                    else
                    {
                        list.RemoveItem((ShoppingItem)listBox.SelectedItem);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Chyba pri odstranění", MessageBoxButton.OK, MessageBoxImage.Error);
                }



            
        }
    }
}