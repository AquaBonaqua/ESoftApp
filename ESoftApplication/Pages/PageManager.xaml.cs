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
using ESoftApplication.Class;
using ESoftApplication.Pages;

namespace ESoftApplication.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageManager.xaml
    /// </summary>
    public partial class PageManager : Page
    {
        public PageManager()
        {
            InitializeComponent();
            HelloLabel.Content = String.Concat(AppData.Manager.Name);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                
            }
            else
            {
                AppData.Executor = null;
                AppData.Manager = null;
                AppData.Frame.Navigate(new PageLogin());
            }




            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppData.Frame.Navigate(new PageEditRatio());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AppData.Frame.Navigate(new PageTasks());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AppData.Frame.Navigate(new PageExecutors());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WindowManagerEdit window = new WindowManagerEdit();
            window.Show();
        }
    }
}
