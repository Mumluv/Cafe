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

namespace Cafe
{
    /// <summary>
    /// Логика взаимодействия для Cooker.xaml
    /// </summary>
    public partial class Cooker : Window
    {
        public Cooker()
        {
            InitializeComponent();
        }

        private void OrderStatus_Click(object sender, RoutedEventArgs e)
        {
            OrderStatus orderStatus = new OrderStatus();
            orderStatus.Show();
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
