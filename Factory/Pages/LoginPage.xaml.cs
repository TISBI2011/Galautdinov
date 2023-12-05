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

namespace Factory.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (TB_login.Text.Length > 0)
            {
                if (TB_Password.Text.Length > 0)
                {
                    App.DB.UsersInfo.FirstOrDefault(x => x.Login == TB_login.Text);
                    NavigationService.Navigate(new GeneralPage());
                    MessageBox.Show("Logged in");
                }
                else
                {
                    MessageBox.Show("error!");
                    return;
                }
            }
        }
    }
}
