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

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            

        }


        private void show_list_clients(object sender, RoutedEventArgs e)
        {
            client_list client_List1 = new client_list();
            client_List1.Show();
            this.Close();

        }

        private void add_client(object sender, RoutedEventArgs e)
        {
            add_client add_client1 = new add_client();
            add_client1.Show();
            this.Close();
        }

        private void show_list_orders(object sender, RoutedEventArgs e)
        {
            show_list_orders show_list_orders1 = new show_list_orders();
            show_list_orders1.Show();
            this.Close();
        }

        private void add_order(object sender, RoutedEventArgs e)
        {
            add_order add_order1 = new add_order();
            add_order1.Show();
            this.Close();
        }
    }
}
