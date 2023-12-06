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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
            
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if(PasswordAuth.Text == "0")
            {
                NavigationService.Navigate(new Teacher());
            }
        }

        private void GuestBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PasswordAuth_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
