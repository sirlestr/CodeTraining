﻿using System.Security.Cryptography.X509Certificates;
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

namespace TextResize
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

       

        private void zvetsiButton_Click(object sender, RoutedEventArgs e)
        {
            string text = vstupTextBox.Text.ToUpper(); 
            vstupTextBox.Text = text.ToString();
            


        }
    }
}