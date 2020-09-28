using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для WindowManagerEdit.xaml
    /// </summary>
    public partial class WindowManagerEdit : Window
    {
        public WindowManagerEdit()
        {
            InitializeComponent();

            
        }

    


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string encpass = AesCryp.Encrypt(TbOldPassword.Password);
            string encpass2 = AesCryp.Encrypt(TbNewPassword.Password);

            if (AppData.Executor == null)
            {
                if (encpass == AppData.Manager.Password)
                {
                    if (TbNewPassword2.Password == TbNewPassword.Password)
                    {

                        AppData.Manager.Password = encpass2;
                        AppData.Ent.SaveChanges();
                        MessageBox.Show("Пароль успешно сохранён!");
                    }

                    else
                    {
                        MessageBox.Show("Пароли не совпадают");

                    }
                }

                else
                {
                    MessageBox.Show("Старый пароль ввёден неверно");
                }
            }

            else
            {
                if (encpass == AppData.Executor.Password)
                {
                    if (TbNewPassword2.Password == TbNewPassword.Password)
                    {
                        AppData.Executor.Password = encpass2;
                        AppData.Ent.SaveChanges();
                        MessageBox.Show("Пароль успешно сохранён!");
                    }

                    else
                    {
                        MessageBox.Show("Пароли не совпадают");
                    }
                }

                else
                {
                    MessageBox.Show("Старый пароль ввёден неверно");
                }

            }


        }
    }
}
