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


namespace WpfAppoo1
{

    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string login = penis.Text;
            string password = passwordPenis.Password;

            using (var db = new ApplicationDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.login == login && u.password == password);

                if (user != null)
                {
                    MainWindow mainWindow = new MainWindow(user);
                    this.Close();
                    mainWindow.Show();
                }
            }

        }
    }
}
