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
    /// Logika interakcji dla klasy client_list.xaml
    /// </summary>
    public partial class client_list : Window
    {
        public client_list()
        {
            InitializeComponent();

            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow1 = new MainWindow();
            mainWindow1.Show();
            this.Close();
        }
    }
}
