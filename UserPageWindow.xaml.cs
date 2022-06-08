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
using UserApp.Models;

namespace UserApp
{
    /// <summary>
    /// Логика взаимодействия для UserPageWindow.xaml
    /// </summary>
    public partial class UserPageWindow : Window
    {
        User thisUser;
        ApplicationContext db;
        Purchase purchase;
        Flight flight;

        public UserPageWindow(string username, string pass)
        {
            InitializeComponent();

            db = new ApplicationContext();
            thisUser = db.Users.ToList().Find(i => i.Username == username && i.Password == pass);
            hi.Text = $"Hello, {thisUser.Username}";
            

        }

        private void ButtonLogOutClick(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Hide();
        }

        private void ButtonShowBiletsClick(object sender, RoutedEventArgs e)
        {
            var prchs =
                from p in db.Purchases
                where p.IDUser == thisUser.ID
                select p;

            IEnumerable<Flight> bilets = new List<Flight>();

            foreach (Purchase p in prchs)
            {
                bilets =
                    from b in db.Flights
                    where b.ID == p.IDFlight
                    select b;
            }

            if (bilets.Count() == 0)
            {
                nobilets.Text = "You don't have tickets yet!";
                listofbilets.ItemsSource = null;
            }
            else
            {
                listofbilets.ItemsSource = bilets.ToList();
            }

            //ApplicationContext db = new ApplicationContext();

            //listofbilets.ItemsSource = db.Flights.ToList();
        }

        private void ButtonBuyClick(object sender, RoutedEventArgs e)
        {
            PurchaseWindow purchaseWindow = new PurchaseWindow(thisUser.ID);
            purchaseWindow.Show();
            this.Hide();
        }
    }
}
