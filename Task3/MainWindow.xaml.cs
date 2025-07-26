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

namespace Task3
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
        private void SaveButtonClick (object sender, RoutedEventArgs e)
        {
            //Проверка согласия на рассылку
            if (!MailingCheckBox.IsChecked ?? false)
            {
                MessageBox.Show("Необходимо согласие на обработку данных!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            //Получение курсов
            var selectedCourses = CourseListView.SelectedItems
                .Cast<ListViewItem>()
                .Select(item => item.Content.ToString())
                .ToList();

            //Формирование сообщения
            string message = $"Данные отправлены!\n\n" +
                             $"Имя: {StudentName.Text}\n" +
                             $"Факультет: {FacultyComboBox.Text}\n" +
                             $"Курсы: {string.Join(",", selectedCourses)}\n";
            MessageBox.Show(message, "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}