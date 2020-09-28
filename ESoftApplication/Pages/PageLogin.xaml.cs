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
using System.Security.Cryptography;
using System.IO;
using AesEncDec;


namespace ESoftApplication.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
      
        public PageLogin()
        {
            InitializeComponent();
            
            

        }

        

      



        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            string encpass = AesCryp.Encrypt(TbPassword.Password);
            

            if (TbLogin.Text == string.Empty && TbLogin.Text == string.Empty) { MessageBox.Show("Введите данные!"); }


            else

            {
                AppData.Manager = AppData.Ent.Managers.FirstOrDefault(x => x.Login == TbLogin.Text && x.Password == encpass);
                AppData.Executor = AppData.Ent.Executors.FirstOrDefault(x => x.Login == TbLogin.Text && x.Password == encpass);

                if (AppData.Manager == null & AppData.Executor == null)

                {
                    MessageBox.Show("Неправильный логин или пароль");
                }

                else
                {
                    if (AppData.Manager == null) { AppData.Frame.Navigate(new PageExecutor()); }

                    else
                    {
                        AppData.Frame.Navigate(new PageManager());
                    }
                }
            }


        }



        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            WindowRegister register = new WindowRegister();
            register.Show();
        }
    }
}
