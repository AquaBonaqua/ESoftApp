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
using System.Windows.Shapes;
using AesEncDec;
using ESoftApplication.Class;

namespace ESoftApplication.Pages
{
    /// <summary>
    /// Логика взаимодействия для WindowRegister.xaml
    /// </summary>
    public partial class WindowRegister : Window
    {
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "qwertyuiopasdfghjklzxcvbnm0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public WindowRegister()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
          
            if (TbNewPassword2.Password == TbNewPassword.Password)
            {
                if (AppData.Ent.Executors.Count(x => x.Login == TbLogin.Text) > 0) { MessageBox.Show("You are not ok!"); }
                else
                {
                    Executor executor = new Executor()
                    {
                        Login = TbLogin.Text,
                        GradeId = 1,
                        IV = RandomString(16),
                        V = RandomString(32),
                    };


                    AppData.Ent.Executors.Add(executor);
                    AppData.Ent.SaveChanges();


                    AppData.Executor = AppData.Ent.Executors.FirstOrDefault(x => x.Login == TbLogin.Text);
                    AppData.Executor.Password = AesCryp.Encrypt(TbNewPassword2.Password);
                    AppData.Ent.SaveChanges();
                    MessageBox.Show("Crypt ok!");

                }


            }

            else
            {
                MessageBox.Show("You are not ok!");
            }

          

        }
    }
}
