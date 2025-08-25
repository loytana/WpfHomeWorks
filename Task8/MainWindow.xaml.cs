using System.Collections.ObjectModel;
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
using static Task8.Product;

namespace Task8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products = new ObservableCollection<Product>();
        public MainWindow()
        {
            InitializeComponent();

            products.Add(new Product { Name = "Яблоки", Price = 299.99m, Image = "Images/Apple.jpg", Category = Categories.Food });
            products.Add(new Product { Name = "Холодильник", Price = 59999.99m, Image = "Images/Fridge.jpg", Category = Categories.Appliances });
            products.Add(new Product { Name = "Бананы", Price = 199.40m, Image = "Images/Banan.jpg", Category = Categories.Food });


            productListBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                Name = "Микроволновая печь",
                Price = 12000,
                Image = "Images/microwave.png",
                Category = Categories.Appliances
            });
        }
    }  
}