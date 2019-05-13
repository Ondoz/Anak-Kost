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

namespace AnakKost.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private Controller.LoginController ControllerLogin;
        public Login()
        {
            InitializeComponent();
           
            ControllerLogin = new Controller.LoginController(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(ControllerLogin.loginuser() == true)
            {
                MainPage mainview = new MainPage();
               
                mainview.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Maaf User/Password anda Salah");
                txtuser.Text = "";
                txtPassword.Password = "";
            }

        }

        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtuser_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
