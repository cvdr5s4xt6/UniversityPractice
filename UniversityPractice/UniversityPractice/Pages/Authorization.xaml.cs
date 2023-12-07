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
            //if(PasswordAuth.Text == "0")
            //{
            //    NavigationService.Navigate(new Teacher());
            //}

            string selectedPost = ((ComboBoxItem)RoleCmBI.SelectedItem)?.Content.ToString();
            string passwordAuth = PasswordAuthorization.Password;

            if (!string.IsNullOrEmpty(selectedPost) && !string.IsNullOrEmpty(passwordAuth))
            {
                if (CheckCredentials(selectedPost, passwordAuth))
                {
                    OpenPage(selectedPost);
                }
                else
                {
                    MessageBox.Show("Введены неверные данные");
                }
            }
            else
            {
                MessageBox.Show("Выберите свой пост и введите пароль");
            }
        }

        private bool CheckCredentials(string Post, string passwordAuth)
        {
            switch (Post)
            {
                case "Учитель":
                    return passwordAuth == "111111";
                case "Зав кафедры":
                    return passwordAuth == "222222";
                case "Инженер":
                    return passwordAuth == "333333";
                case "Гость":
                    return true;
                default:
                    return false;
            }
        }


        private void OpenPage(string Post)
        {
            switch (Post)
            {
                case "Учитель": OpenTeacherPage();
                    break;
                case "Зав кафедры": OpenHeadPage();
                    break;
                case "Инженер": OpenEngineerPage();
                    break;
            }
        }

        public void OpenTeacherPage()
        {
            Teacher teacherPage = new Teacher();
            NavigationService.Navigate(teacherPage);
        }

        private void OpenHeadPage()
        {
            Department departmentPage = new Department();
            NavigationService.Navigate(departmentPage);

        }

        private void OpenEngineerPage()
        {
            Engineer engineerPage = new Engineer();
            NavigationService.Navigate(engineerPage);

        }

        private void GuestBtn_Click(object sender, RoutedEventArgs e)
        {
            {
                NavigationService.Navigate(new Guest());
            }
        }

       
    }
}
