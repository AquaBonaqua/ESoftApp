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
    /// Логика взаимодействия для PageExecutors.xaml
    /// </summary>
    public partial class PageExecutors : Page
    {
        public PageExecutors()
        {
            InitializeComponent();
            ExecutorsGrid.ItemsSource = AppData.Ent.Executors.ToList();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.Frame.GoBack();
        }
    }
}
