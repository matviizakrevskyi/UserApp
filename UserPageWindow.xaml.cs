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
using System.Windows.Shapes;

namespace UserApp
{
    /// <summary>
    /// Логика взаимодействия для UserPageWindow.xaml
    /// </summary>
    public partial class UserPageWindow : Window
    {
        public UserPageWindow(string username, string pass)
        {
            InitializeComponent();

            ApplicationContext db = new ApplicationContext();
            hi.Text = $"Hello, {username}";

        }

        private void ButtonLogOutClick(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Hide();
        }

        private void ButtonShowBiletsClick(object sender, RoutedEventArgs e)
        {
            List<string> bilets = new List<string>();

            if (bilets.Count() == 0)
            {
                listofbilets.ItemsSource = new List<string> { "You don't have tickets yet!" };
            }
            else
            {
                listofbilets.ItemsSource = bilets;
            }
        }
    }
}
