﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1_3
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
        private void Clicker(object sender, RoutedEventArgs e)
        {
            button.Margin = new Thickness(new Random().Next(375), new Random().Next(200), new Random().Next(200), new Random().Next(375));
        }
    }
}