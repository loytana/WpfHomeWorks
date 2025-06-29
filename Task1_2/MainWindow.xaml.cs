//using System.Drawing;
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
using System.Xml.Schema;

namespace Task1_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Color red = Color.FromRgb(128, 0, 0);
        Color yellow = Color.FromRgb(128, 128, 0);
        Color green = Color.FromRgb(0, 128, 0);
        Color gray = Color.FromRgb(128, 128, 128);
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Clicker(object sender, RoutedEventArgs e)
        {
            if(GreenCircle.Fill.ToString() == green.ToString()) //тут что-то мешает сравнить через == "Green"
            {
                GreenCircle.Fill = new SolidColorBrush(gray);
                RedCircle.Fill = new SolidColorBrush(red);
            }
            else if (YellowCircle.Fill.ToString() == yellow.ToString())
            {
                YellowCircle.Fill = new SolidColorBrush(gray);
                GreenCircle.Fill = new SolidColorBrush(green);
            }
            else
            {
                RedCircle.Fill = new SolidColorBrush(gray);
                YellowCircle.Fill = new SolidColorBrush(yellow);
            }
        }
    }
}