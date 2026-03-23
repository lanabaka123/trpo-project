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

namespace WpfAppoo1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public User authPenis { get; set; }
        private ApplicationDbContext dbContext;

        public MainWindow(User penis)
        {
            authPenis = penis;
            dbContext = new ApplicationDbContext();

            InitializeComponent();
        }

        private void goida_Initialized(object sender, EventArgs e)
        {
            //goida.Visibility = Visibility.Hidden;
        }

        private void fio_Initialized(object sender, EventArgs e)
        {
            fio.Content = authPenis.FIO;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ProductsDataGrid.ItemsSource = dbContext.products.ToList();
            OrdersDataGrid.ItemsSource = dbContext.orders.ToList();
        }
    }
}
