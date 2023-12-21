using StomatologyProject.DataBase;
using StomatologyProject.ViewModels;
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
    /// Логика взаимодействия для Assistant.xaml
    /// </summary>
    public partial class Assistant : Window
    {
        private AssistantRepository assistants;
        public Assistant()
        {
            InitializeComponent();
            assistants = new AssistantRepository();
            TableAssistant.ItemsSource = assistants.GetList();
        }
        void Updating()
        {
            TableAssistant.ItemsSource = assistants.GetList();
        }
        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menuWindow = new Menu();
            this.Close();
            menuWindow.ShowDialog();
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            List<long> list = new List<long>();
            foreach (AssistantViewModel item in TableAssistant.ItemsSource)
            {
                try
                {
                    list.Add(item.Id);
                    assistants.Update(item);
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Name")
                    {
                        MessageBox.Show($"Некорректно введено поле ФИО у записи под номером {item.Id}", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else if (ex.Message == "Contactinfo")
                    {
                        MessageBox.Show($"Некорректно введено поле номера телефона у записи под номером {item.Id}", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        MessageBox.Show($"У записи под номером {item.Id} введены данные некорректно", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            if (list.Count > 0)
            {
                MessageBox.Show($"Обновление прошло успешно!\nОбновлённые записи {string.Join(",", list)}.", "База данных", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
        private void DeletButton_Click(object sender, RoutedEventArgs e)
        {
            AssistantViewModel assistantM = TableAssistant.SelectedItem as AssistantViewModel;
            if (assistantM == null) return;
            try
            {
                assistants.Delete(assistantM.Id);
                MessageBox.Show($"Удаление записи под номером {assistantM.Id} прошло успешно", "База данных", MessageBoxButton.OK, MessageBoxImage.Error);
                Updating();
            }
            catch { MessageBox.Show($"Удаление записи не может быть осуществлено", "База данных", MessageBoxButton.OK, MessageBoxImage.Error); }
        }
        private void Return_Button_Click(object sender, RoutedEventArgs e)
        {
            Updating();
        }
    }
}
