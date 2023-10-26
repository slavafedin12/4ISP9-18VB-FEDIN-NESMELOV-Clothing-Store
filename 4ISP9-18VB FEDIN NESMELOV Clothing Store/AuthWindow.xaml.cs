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

namespace _4ISP9_18VB_FEDIN_NESMELOV_Clothing_Store
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void TBLogin_MouseEnter(object sender, MouseEventArgs e)
        {
            if (TBLogin.Text == "Логин")
            {
                TBLogin.Text = "";
            }
        }

        private void TBPassword_MouseLeave(object sender, MouseEventArgs e)
        {
            if (TBPassword.Text == "")
            {
                TBPassword.Text = "Пароль";
            }
        }

        private void TBPassword_MouseEnter(object sender, MouseEventArgs e)
        {
            if (TBPassword.Text == "Пароль")
            {
                TBPassword.Text = "";
            }
        }

        private void TBLogin_MouseLeave(object sender, MouseEventArgs e)
        {
            if (TBLogin.Text == "")
            {
                TBLogin.Text = "Логин";
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var userAuth = ClassHelper.EFCL.Context.Client.ToList().
              Where(i => i.Login == TBLogin.Text && i.Password == TBPassword.Text).FirstOrDefault();

            if (userAuth != null)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RegistrWindow regWindow = new RegistrWindow();
            regWindow.Show();
            this.Hide();
        }

        private void TBLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }

