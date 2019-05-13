using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AnakKost.Controller
{
    class LoginController
    {
        private View.Login viewlogin;
        private Model.LoginModel modellogin;

        public LoginController(View.Login viewlogin)
        {
            this.viewlogin = viewlogin;
            modellogin = new Model.LoginModel();
        }

        public bool loginuser()
        {
            bool hasil = modellogin.Login(viewlogin.txtuser.Text,
                viewlogin.txtPassword.Password);
                return hasil;
        }

     

       

       


    }
}
