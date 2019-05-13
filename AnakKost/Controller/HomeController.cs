using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AnakKost.Controller
{
    class HomeController
    {
        private View.Home viewhome;
        private View.Grafic viewgrafic;
        private Model.HomeModel modelkeuangan;

        private Model.MainPageModel modelmainpage;

     
        //construktor
        

        public HomeController(View.Home viewhome)
        {
            this.viewhome = viewhome;
            modelkeuangan = new Model.HomeModel();
            modelmainpage = new Model.MainPageModel();
        }
        public void SelectHistory()
        {

            DataSet data = modelkeuangan.SelectHistory();
            viewhome.Historylist.DataContext = data.Tables[0].DefaultView;
           

        }
        public void SelectKeuangan()
        {
          
            DataSet data = modelkeuangan.SelectKeuangan();
            viewhome.ListView.DataContext = data.Tables[0].DefaultView;
  
        }
        public void pengguna()
        {
            DataSet data = modelmainpage.pengguna();

          
            viewhome.txbSaldo.Text = data.Tables[0].Rows[0]["SaldoPengguna"].ToString();
            viewhome.txt_Saldo.Text = data.Tables[0].Rows[0]["SaldoPengguna"].ToString();
          
        }
   

        public void totalpengeluaran()
        {
            DataSet data = modelkeuangan.TotalPengeluaran();
           
            viewhome.txt_totalpengeluaran.Text = data.Tables[0].Rows[0]["Column1"].ToString();
        }

  
        public Boolean UpdateSaldo()
        {
            modelmainpage.Setsaldo(viewhome.txt_Saldo.Text);
            Boolean hasil = modelmainpage.UpdateSaldo();
            return hasil;
        }

        public Boolean InsertData()
        {
            modelkeuangan.Setno(viewhome.txt_No.Text);
            modelkeuangan.Setnamabarang(viewhome.txt_Barang.Text);
            modelkeuangan.Settanggal(viewhome.dtTanggal.Text);
            modelkeuangan.Setharga(viewhome.txt_harga.Text);
            modelkeuangan.Setketerangan(viewhome.cbKeterangan.Text);
            Boolean hasil = modelkeuangan.insertdata();
            return hasil;
        }
        public Boolean Updatedata()
        {
           
            modelkeuangan.Setno(viewhome.txt_No.Text);
            modelkeuangan.Setnamabarang(viewhome.txt_Barang.Text);
            modelkeuangan.Settanggal(viewhome.dtTanggal.Text);
            modelkeuangan.Setharga(viewhome.txt_harga.Text);
            modelkeuangan.Setketerangan(viewhome.cbKeterangan.Text);
            Boolean hasil = modelkeuangan.Updatedata();
            return hasil;
        }

        public Boolean DeleteData()
        {
            modelkeuangan.Setno(viewhome.txt_No_Delet.Text);
            Boolean hasil = modelkeuangan.deletdata();
            return hasil;
        }
   
       

    }
}
