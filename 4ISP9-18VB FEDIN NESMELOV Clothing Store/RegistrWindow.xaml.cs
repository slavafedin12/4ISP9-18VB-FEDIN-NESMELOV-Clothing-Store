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
    /// Логика взаимодействия для RegistrWindow.xaml
    /// </summary>
    public partial class RegistrWindow : Window
    {
        public RegistrWindow()
        {
            InitializeComponent();
        }


        private void ButtonReg_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBLastName.Text))
            {
                MessageBox.Show("Поле Фамилия не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBFirstName.Text))
            {
                MessageBox.Show("Поле Имя не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBPhone.Text))
            {
                MessageBox.Show("Поле Телефон не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBEmail.Text))
            {
                MessageBox.Show("Поле Почта не заполнено");
            }
            if (string.IsNullOrWhiteSpace(TBLogin.Text))
            {
                MessageBox.Show("Заполните логин");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBPassword.Text))
            {
                MessageBox.Show("Заполните пароль");
                return;
            }

            DB.Client addClient = new DB.Client();
            addClient.Login = TBLogin.Text;
            addClient.Password = TBPassword.Text;
            addClient.LastName = TBLastName.Text;
            addClient.FirstName = TBFirstName.Text;
            addClient.Phone = TBPhone.Text;
            addClient.Email = TBEmail.Text;

            ClassHelper.EFCL.Context.Client.Add(addClient);
            ClassHelper.EFCL.Context.SaveChanges();
            MessageBox.Show("Пользоваталь успешно добавлен");
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
        }

        private void TBLastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
