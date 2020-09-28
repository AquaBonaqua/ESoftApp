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

namespace ESoftApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {


            InitializeComponent();


            AppData.Frame = MainFrame;
            AppData.Ent = new eSoftEntities();
            AppData.Executor = null;
            AppData.Manager = null;
            AppData.Frame.Navigate(new PageLogin());

         


        }
    }
}
