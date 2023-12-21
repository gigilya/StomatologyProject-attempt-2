using StomatologyProject.DataBase;
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
    /// Логика взаимодействия для Procedure.xaml
    /// </summary>
    public partial class Procedure : Window
    {
        private ProcedureRepository _repository;
        public Procedure()
        {
            InitializeComponent();
            _repository = new ProcedureRepository();
            TableProcedure.ItemsSource = _repository.GetList();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menuWindow = new Menu();
            this.Close();
            menuWindow.ShowDialog();
        }
    }
}
