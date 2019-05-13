using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AnakKost.Controller
{
    class MainPageController
    {
        private View.MainPage viewmainpage;
        private Model.MainPageModel modelmainpage;

        private View.Home viewhome;

        public MainPageController (View.MainPage viewmainpage)
        {
            this.viewmainpage = viewmainpage;
            modelmainpage = new Model.MainPageModel();

        }

        public void pengguna()
        {
            DataSet data = modelmainpage.pengguna();

            viewmainpage.TxtPengguna.DataContext = data.Tables[0].DefaultView;            
            viewmainpage.TxtPengguna.Text = data.Tables[0].Rows[0]["NamaPengguna"].ToString();
            viewmainpage.txt_Pengguna.Text = data.Tables[0].Rows[0]["NamaPengguna"].ToString();
            viewmainpage.txt_Nama.Text = data.Tables[0].Rows[0]["UserNama"].ToString();

           

        }
        public Boolean UpdateDataAdmin()
        {
            modelmainpage.Setnamapengguna(viewmainpage.txt_Pengguna.Text);
            modelmainpage.Setusernama(viewmainpage.txt_Nama.Text);
            modelmainpage.Setpassword(viewmainpage.txt_passbaru.Text);
            Boolean hasil = modelmainpage.UpdatePengguna();
            return hasil;
        }

        public bool Pengenaldata()
        {
            bool hasil = modelmainpage.DataLama(viewmainpage.txt_Passlama.Password);
            return hasil;
        }

    }
}
