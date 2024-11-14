using System;
using System.Linq;
using System.Windows;
using WpfApp1.entities;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для EditLecture.xaml
    /// </summary>
    public partial class EditLecture : Window
    {
        private int _lectureId;
        public EditLecture(entities.Final_Add_Lectures sender1)
        {
            InitializeComponent();
            _lectureId = sender1.ID;

            cb_Sub.ItemsSource = App.Context.Final_Courses.Select(p => p.CourseName).ToList();

            LoadLectureData();
        }

        private void LoadLectureData()
        {
            var lecture = App.Context.Final_Add_Lectures.FirstOrDefault(l => l.ID == _lectureId);
            if (lecture != null)
            {
                cb_Sub.SelectedItem = App.Context.Final_Courses.FirstOrDefault(c => c.ID == lecture.ID_Courses)?.CourseName;
                tb_NumClass.Text = lecture.NumClass.ToString();
                tb_NumRoom.Text = lecture.NumRoom.ToString();
                dp_Date.SelectedDate = lecture.DateOfClass;
            }
            else
            {
                MessageBox.Show("Занятие не найдено.");
                this.Close();
            }
        }

        private void but_Return_Click(object sender, RoutedEventArgs e)
        {
            ProfWindow profWindow = new ProfWindow();
            profWindow.Show();
            this.Close();
        }

        private void b_Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cb_Sub.SelectedItem != null &&
                    !string.IsNullOrWhiteSpace(tb_NumClass.Text) &&
                    !string.IsNullOrWhiteSpace(tb_NumRoom.Text) &&
                    dp_Date.SelectedDate != null)
                {
                    var subjectId = App.Context.Final_Courses
                        .Where(p => p.CourseName == cb_Sub.Text)
                        .Select(p => p.ID)
                        .FirstOrDefault();

                    if (subjectId == 0)
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
                        MessageBox.Show("Нельзя изменять занятия на прошедшие дни!");
                        return;
                    }

                    var lecture = App.Context.Final_Add_Lectures.FirstOrDefault(l => l.ID == _lectureId);
                    if (lecture != null)
                    {
                        lecture.ID_Courses = subjectId;
                        lecture.NumClass = numClass;
                        lecture.NumRoom = numRoom;
                        lecture.DateOfClass = dp_Date.SelectedDate.Value;

                        App.Context.SaveChanges();
                        MessageBox.Show("Занятие изменено успешно.");
                    }
                    else
                    {
                        MessageBox.Show("Занятие не найдено.");
                    }

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