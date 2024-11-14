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
using WpfApp1.entities;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddLecture.xaml
    /// </summary>
    public partial class AddLecture : Window
    {
        public AddLecture()
        {
            InitializeComponent();

            cb_Sub.ItemsSource = App.Context.Final_Courses.Select(p => p.CourseName).ToList();
        }

        private void but_Return_Click(object sender, RoutedEventArgs e)
        {
            ProfWindow profWindow = new ProfWindow();
            profWindow.Show();
            this.Close();
        }

        private void b_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cb_Sub.SelectedItem != null &&
                    !string.IsNullOrWhiteSpace(tb_NumClass.Text) &&
                    !string.IsNullOrWhiteSpace(tb_NumRoom.Text) &&
                    dp_Date.SelectedDate != null)
                {
                    var Subject = App.Context.Final_Courses.Where(p => p.CourseName == cb_Sub.Text).Select(p => p.ID).FirstOrDefault();
                    var LastName = App._Professors.ID;

                    if (Subject == 0)
                    {
                        MessageBox.Show("Выберите существующий предмет.");
                        return;
                    }

                    if (!int.TryParse(tb_NumClass.Text, out int numClass) || !int.TryParse(tb_NumRoom.Text, out int numRoom))
                    {
                        MessageBox.Show("Введите корректные значения для номера класса и номера комнаты.");
                        return;
                    }

                    if (dp_Date.SelectedDate < DateTime.Today)
                    {
                        MessageBox.Show("Нельзя добавлять доп занятия в прошедшие дни!");
                        return;
                    }

                    var newClass = new Final_Add_Lectures
                    {
                        ID_Professors = LastName,
                        ID_Courses = Subject,
                        NumClass = numClass,
                        NumRoom = numRoom,
                        DateOfClass = dp_Date.SelectedDate.Value
                    };

                    App.Context.Final_Add_Lectures.Add(newClass);
                    App.Context.SaveChanges();

                    MessageBox.Show("Новое доп занятие добавлено");
                    ProfWindow profWindow = new ProfWindow();
                    profWindow.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
