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
using System.Windows.Navigation;
using System.Windows.Shapes;
using UniversityPractice.Components;

namespace UniversityPractice.Pages
{
    /// <summary>
    /// Логика взаимодействия для Teacher.xaml
    /// </summary>
    public partial class Teacher : Page
    {
        private Student student;
        private Exam exam;
        public Teacher()
        {
            InitializeComponent();
            ExamsDataGrid.ItemsSource = App.db.Exam.ToList();
            ExamsDataGrid.DataContext = App.db.Exam.ToList();
            StudentsComboBox.ItemsSource = App.db.Student.ToList();
            StudentsComboBox.DisplayMemberPath = "Last_name";
            DiscComboBox.ItemsSource = App.db.Discipline.ToList();
            DiscComboBox.DisplayMemberPath = "Name";
            TeachComboBox.ItemsSource = App.db.Employee.ToList();
            TeachComboBox.DisplayMemberPath = "Last_name";
            //App.COuntOfExams = App.db.Exam.Count();


        }
    }
}
