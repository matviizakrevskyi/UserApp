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

namespace UserApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSignUpClick(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = passBox.Password.Trim();
            string passwordRep = passBoxRep.Password.Trim();
            string email = textBoxEmail.Text.Trim();  //.ToLower().Trim() - фильтры

            if (login.Length < 5)   //---  проверка логина
            {
                textBoxLogin.ToolTip = "This field is entered incorrectly!";   //подсказка когда наводишь мышью
                textBoxLogin.Background = Brushes.DarkRed;
            }
            else if (password.Length < 5)  //---  проверка пароля
            {
                passBox.ToolTip = "This field is entered incorrectly!";
                passBox.Background = Brushes.DarkRed;
            }
            else if (password != passwordRep)  //---  проверка повтора пароля
            {
                passBoxRep.ToolTip = "Passwords do not match!";
                passBoxRep.Background = Brushes.DarkRed;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))  //---  проверка емейла
            {
                textBoxEmail.ToolTip = "Passwords do not match!";
                textBoxEmail.Background = Brushes.DarkRed;
            }
            else  //--- если проверка прошла успешно ---//
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBoxRep.ToolTip = "";
                passBoxRep.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Nice!!!");
            }

        }
    }
}
