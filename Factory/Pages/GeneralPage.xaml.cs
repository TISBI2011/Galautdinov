using Factory.Models;
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
    /// Логика взаимодействия для GeneralPage.xaml
    /// </summary>
    public partial class GeneralPage : Page
    {
        public GeneralPage()
        {
            InitializeComponent();
        }

        private void ViewBT_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ViewingPage());
        }
        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            Furniture addata = new Furniture();
            addata.Название = Title.Text;
            addata.Материал = Material.Text;
            addata.Стиль = Style.Text;
            addata.Кол_во_на_складе = int.Parse(Count.Text);
            App.DB.Furniture.Add(addata);
            App.DB.SaveChanges();
            MessageBox.Show("Данные успешно добавлены");
        }
    }
}
