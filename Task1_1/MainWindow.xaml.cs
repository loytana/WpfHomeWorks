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

namespace Task1_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _result = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Clicker(object sender, RoutedEventArgs e)
        {
            _result ++;
            Value.Text = _result.ToString();
        }
    }
}