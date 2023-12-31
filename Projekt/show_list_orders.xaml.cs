﻿using System;
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
    /// Logika interakcji dla klasy show_list_orders.xaml
    /// </summary>
    public partial class show_list_orders : Window
    {
        public show_list_orders()
        {
            InitializeComponent();
            Projekt_POEntities db = new Projekt_POEntities();
            var table = from z in db.Zamowienie_Klienci select new
                        {
                z.stan_platnosci, z.stan_pracy,
                z.klient_id, z.zamowienie_id
            };

            this.table.ItemsSource = table.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow1 = new MainWindow();
            mainWindow1.Show();
            this.Close();
        }

        

        
    }
}
