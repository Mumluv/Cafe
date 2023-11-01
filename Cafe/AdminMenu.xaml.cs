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
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddEmp emp = new AddEmp();
            emp.Show();
            this.Close();
        }

        private void Yvolen_Click(object sender, RoutedEventArgs e)
        {
            Yvolit yvol = new Yvolit();
            yvol.Show();
            this.Close();
        }

        private void AddSmena_Click(object sender, RoutedEventArgs e)
        {
            Smeni smeni = new Smeni();
            smeni.Show();
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
