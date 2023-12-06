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

namespace UniversityPractice.Pages
{
    /// <summary>
    /// Логика взаимодействия для Guest.xaml
    /// </summary>
    public partial class Guest : Page
    {
        public Guest()
        {
            InitializeComponent();
            DisciplineDataGrid.ItemsSource = App.db.Exam.ToList();
            DisciplineDataGrid.DataContext = App.db.Exam.ToList();

        }

        private void DisciplineDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
    }
}
