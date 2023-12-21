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

namespace StomatologyProject_attempt_2.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menuWindow = new Menu();
            this.Close();
            menuWindow.ShowDialog();
        }
        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            //User guestWindow = new User();
            //this.Close();
            //guestWindow.ShowDialog();
        }
    }
}
