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
    /// Логика взаимодействия для PageEditRatio.xaml
    /// </summary>
    public partial class PageEditRatio : Page
    {
        public PageEditRatio()
        {
            InitializeComponent();



            Junior.Text = AppData.Manager.Coef.GradeCoef.Junior.ToString();
            Middle.Text = AppData.Manager.Coef.GradeCoef.Middle.ToString();
            Senior.Text = AppData.Manager.Coef.GradeCoef.Senior.ToString();
            Analysis.Text = AppData.Manager.Coef.Analysis.ToString();
            Deployment.Text = AppData.Manager.Coef.Deployment.ToString();
            Support.Text = AppData.Manager.Coef.Support.ToString();
            Difficulty.Text = AppData.Manager.Coef.Difficulty.ToString();
            Time.Text = AppData.Manager.Coef.Time.ToString();
            Transfer.Text = AppData.Manager.Coef.Transfer.ToString();




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.Frame.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDecimal(Analysis.Text) > 1 || Convert.ToDecimal(Deployment.Text) > 1 || Convert.ToDecimal(Support.Text) > 1)
            {
                MessageBox.Show("Характер выполненных работ - это диапазон [0, 1]");
                return;
            }

            try
            {

                AppData.Manager.Coef.GradeCoef.Junior = Convert.ToDecimal(Junior.Text);
                AppData.Manager.Coef.GradeCoef.Middle = Convert.ToDecimal(Middle.Text);
                AppData.Manager.Coef.GradeCoef.Senior = Convert.ToDecimal(Senior.Text);
                AppData.Manager.Coef.Analysis = Convert.ToDecimal(Analysis.Text);
                AppData.Manager.Coef.Deployment = Convert.ToDecimal(Deployment.Text);
                AppData.Manager.Coef.Support = Convert.ToDecimal(Support.Text);
                AppData.Manager.Coef.Difficulty = Convert.ToDecimal(Difficulty.Text);
                AppData.Manager.Coef.Time = Convert.ToDecimal(Time.Text);
                AppData.Manager.Coef.Transfer = Convert.ToDecimal(Transfer.Text);
            }
            catch
            {
                MessageBox.Show("Проверьте корректность данных и попробуйте ещё раз!");
                return;
            }

         





            AppData.Ent.SaveChanges();
            MessageBox.Show("Сохранено");
        }

      

        private void Junior_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ",")
               && (!Junior.Text.Contains(",")
               && Junior.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }

        private void Middle_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ",")
               && (!Middle.Text.Contains(",")
               && Middle.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }

        private void Senior_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ",")
               && (!Senior.Text.Contains(",")
               && Senior.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }

        private void Analysis_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ",")
               && (!Analysis.Text.Contains(",")
               && Analysis.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }

        private void Deployment_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ",")
               && (!Analysis.Text.Contains(",")
               && Analysis.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }

        private void Support_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ",")
               && (!Support.Text.Contains(",")
               && Support.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }

        private void Difficulty_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ",")
               && (!Difficulty.Text.Contains(",")
               && Difficulty.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }

        private void Time_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ",")
               && (!Time.Text.Contains(",")
               && Time.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }

        private void Transfer_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ",")
               && (!Transfer.Text.Contains(",")
               && Transfer.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }

    }
}
