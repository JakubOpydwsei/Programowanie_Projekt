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

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy add_order.xaml
    /// </summary>
    public partial class add_order : Window
    {
        public add_order()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow1 = new MainWindow();
            mainWindow1.Show();
            this.Close();
        }

        private void submit_add_new_order(object sender, RoutedEventArgs e)
        {
            Projekt_POEntities db = new Projekt_POEntities();

            Zamowienie_Klienci new_order = new Zamowienie_Klienci()
            {
                klient_id = int.Parse(klient_id_update.Text),
                zamowienie_id = int.Parse(zamowienie_id_update.Text),
                stan_platnosci = stan_platnosci_update.Text,
                stan_pracy = stan_pracy_update.Text

            };
            db.Zamowienie_Klienci.Add(new_order);
            db.SaveChanges();

            show_list_orders show_list_orders1 = new show_list_orders();
            show_list_orders1.Show();
            this.Close();
        }
    }
}
