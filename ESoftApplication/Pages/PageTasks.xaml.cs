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
using ESoftApplication.Pages;
using ESoftApplication.Class;
using System.Collections.ObjectModel;

namespace ESoftApplication.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageTasks.xaml
    /// </summary>
    public partial class PageTasks : Page
    {
        
     
       



        public PageTasks()
        {
            InitializeComponent();

            CmbExecutor.ItemsSource = AppData.Ent.Executors.ToList();
            CmbExecutor.SelectedValuePath = "Id";
            CmbExecutor.DisplayMemberPath = "Name";

            CmbStatus.ItemsSource = AppData.Ent.Status.ToList();
            CmbStatus.SelectedValuePath = "Id";
            CmbStatus.DisplayMemberPath = "Name";

            UpdateTable();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.Frame.GoBack();
        }

        public void UpdateTable()
        {
            if (AppData.Manager == null)
            {

                TasksGrid.Columns[4].Visibility = Visibility.Hidden;
                TasksGrid.Columns[5].Visibility = Visibility.Hidden;
                AddTask.Visibility = Visibility.Hidden;
                StackExecutor.Visibility = Visibility.Hidden;

                if (CmbStatus.SelectedIndex == -1)
                {
                    TasksGrid.ItemsSource = AppData.Ent.Tasks.Where(x => x.ExecutorId == AppData.Executor.Id).ToList();

                }

                else

                {
                   
                   
                    TasksGrid.ItemsSource = AppData.Ent.Tasks.Where(x => x.ExecutorId == AppData.Executor.Id && x.StatusId == (int)CmbStatus.SelectedValue).ToList();

                }
            }

            else
            {
                if (CmbStatus.SelectedIndex == -1 && CmbExecutor.SelectedIndex == -1)
                {
                    //List<Task> task1 = AppData.Ent.Tasks.Where(x => x.Executor.ManagerId == AppData.Manager.Id).ToList();
                    TasksGrid.ItemsSource = AppData.Ent.Tasks.Where(x => x.Executor.ManagerId == AppData.Manager.Id).ToList();
                }

                
                else if (CmbStatus.SelectedIndex == -1)

                {

                    //List<Task> task2 = AppData.Ent.Tasks.Where(x => x.Executor.ManagerId == AppData.Manager.Id && x.Executor.Id == (int)CmbExecutor.SelectedValue).ToList();
                    TasksGrid.ItemsSource = AppData.Ent.Tasks.Where(x => x.Executor.ManagerId == AppData.Manager.Id && x.Executor.Id == (int)CmbExecutor.SelectedValue).ToList();
                }

                else if (CmbExecutor.SelectedIndex == -1)
                {
                    //List<Task> task3 = AppData.Ent.Tasks.Where(x => x.Executor.ManagerId == AppData.Manager.Id && x.StatusId == (int)CmbStatus.SelectedValue).ToList();
                    TasksGrid.ItemsSource = AppData.Ent.Tasks.Where(x => x.Executor.ManagerId == AppData.Manager.Id && x.StatusId == (int)CmbStatus.SelectedValue).ToList();
                }

                else
                {
                    //List<Task> task4 = AppData.Ent.Tasks.Where(x => x.Executor.ManagerId == AppData.Manager.Id && x.Executor.Id == (int)CmbExecutor.SelectedValue && x.StatusId == (int)CmbStatus.SelectedValue).ToList();
                    TasksGrid.ItemsSource = AppData.Ent.Tasks.Where(x => x.Executor.ManagerId == AppData.Manager.Id && x.Executor.Id == (int)CmbExecutor.SelectedValue && x.StatusId == (int)CmbStatus.SelectedValue).ToList();
                }

            }
            
        }

        private void CmbExecutor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTable();
        }

        private void CmbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTable();
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {

            }
            else
            {
                Task task = ((sender as Button).DataContext as Task);
                AppData.Ent.Tasks.Remove(task);
                AppData.Ent.SaveChanges();
                UpdateTable();

            }
        }

        private void EditTask_Click(object sender, RoutedEventArgs e)
        {
            Task task = (sender as Button).DataContext as Task;

            WindowTask editform = new WindowTask(task);

            editform.Show();

        }
    }
}
