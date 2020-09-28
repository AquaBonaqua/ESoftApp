using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using ESoftApplication.Class;
using ESoftApplication.Pages;

namespace ESoftApplication.Pages
{
    /// <summary>
    /// Логика взаимодействия для WindowTask.xaml
    /// </summary>
    public partial class WindowTask : Window
    {

        Task editTask;


        public WindowTask(Task task)
        {
            InitializeComponent();

            

            editTask = task;
            CmbExecutor.ItemsSource = AppData.Ent.Executors.ToList();
            CmbExecutor.SelectedValuePath = "Id";
            CmbExecutor.DisplayMemberPath = "Name";

            CmbStatus.ItemsSource = AppData.Ent.Status.ToList();
            CmbStatus.SelectedValuePath = "Id";
            CmbStatus.DisplayMemberPath = "Name";

            CmbKind.ItemsSource = AppData.Ent.Kinds.ToList();
            CmbKind.SelectedValuePath = "Id";
            CmbKind.DisplayMemberPath = "Name";

            Name.Text = task.Name;
            Info.Text = task.Info;
            CmbStatus.SelectedValue = task.StatusId;
            Difficulty.Text = task.Difficulty.ToString();
            CmbExecutor.SelectedValue = task.ExecutorId;
            CmbKind.SelectedValue = task.KindId;
            CompleteDays.Text = task.CompletePeriod.ToString();
            FinishDate.SelectedDate = task.CompleteDate;
            CompleteTime.Text = task.CompleteTime.ToString();


        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            editTask.Name = Name.Text;
            editTask.Info = Info.Text;
            editTask.StatusId = (int)CmbStatus.SelectedValue;
            editTask.Difficulty = Convert.ToInt32(Difficulty.Text);
            editTask.ExecutorId = (int)CmbExecutor.SelectedValue;
            editTask.KindId = (int)CmbKind.SelectedValue;
            editTask.CompletePeriod = Convert.ToInt32(CompleteDays.Text);
            editTask.CompleteDate = FinishDate.SelectedDate;
            editTask.CompleteTime = Convert.ToInt32(CompleteTime.Text);
            AppData.Ent.SaveChanges();
            MessageBox.Show("Успешно !");
            AppData.Frame.Refresh();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.Frame.Refresh();
            this.Close();
          
        }
    }
}
