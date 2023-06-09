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
    /// Logika interakcji dla klasy add_client.xaml
    /// </summary>
    public partial class add_client : Window
    {
        public add_client()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow1 = new MainWindow();
            mainWindow1.Show();
            this.Close();
        }

        private void submit_client_add_Click(object sender, RoutedEventArgs e)
        {
            Projekt_POEntities db = new Projekt_POEntities();
            Klienci kilentobj = new Klienci()
            {
                imie = imie_dodaj.Text,
                naziwsko = nazwisko_dodaj.Text,
                telefon = int.Parse(nr_telefonu_dodaj.Text),
                kod_pocztowy = kod_pocztowy_dodaj.Text,
                adres = adres_dodaj.Text
            };
            db.Klienci.Add(kilentobj);
            db.SaveChanges();

            client_list client_List1 = new client_list();
            client_List1.Show();
            this.Close();

        }
    }
}
