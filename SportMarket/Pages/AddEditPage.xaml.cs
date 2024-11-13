using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SportMarket.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        public AddEditPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.Manager.MainFrame.Navigate(new Pages.ListViewPage());
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();
                if (String.IsNullOrEmpty(NameTextBox.Text))
                {
                    errors.AppendLine("Введите ФИО");
                }
                if (String.IsNullOrEmpty(EmailTextBox.Text))
                {
                    errors.AppendLine("Введите Email");
                }
                if (String.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    errors.AppendLine("Введите Пароль");
                }
                if (String.IsNullOrEmpty(PhoneTextBox.Text))
                {
                    errors.AppendLine("Введите Номер Телефона");
                }
                if (String.IsNullOrEmpty(BirthDateTextBox.Text))
                {
                    errors.AppendLine("Введите Дату рождения");
                }
                if (PasswordTextBox.Text != Password2TextBox.Text)
                {
                    errors.AppendLine("Пароли не совпадают");
                }








                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString(), "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else { MessageBox.Show("Спасибо за использование пробной версии!", "Благодарность!", MessageBoxButton.OK, MessageBoxImage.None); }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}
