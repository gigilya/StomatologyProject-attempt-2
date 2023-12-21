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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void DoctorButton_Click(object sender, RoutedEventArgs e)
        {
            Doctor doctorWindow = new Doctor();
            this.Close();
            doctorWindow.ShowDialog();
        }

        private void AssistanButton_Click(object sender, RoutedEventArgs e)
        {
            Assistant assistanWindow = new Assistant();
            this.Close();
            assistanWindow.ShowDialog();
        }

        private void PatientButton_Click(object sender, RoutedEventArgs e)
        {
            Patient patientWindow = new Patient();
            this.Close();
            patientWindow.ShowDialog();
        }

        private void ProcedureButton_Click(object sender, RoutedEventArgs e)
        {
            Procedure procedureWindow = new Procedure();
            this.Close();
            procedureWindow.ShowDialog();
        }

        private void EntryButton_Click(object sender, RoutedEventArgs e)
        {
            Entry entryWindow = new Entry();
            this.Close();
            entryWindow.ShowDialog();
        }

        private void SpecializationButton_Click(object sender, RoutedEventArgs e)
        {
            Specialization specializationWindow = new Specialization();
            this.Close();
            specializationWindow.ShowDialog();
        }
    }
}
