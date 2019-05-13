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

namespace AnakKost.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
       private Controller.HomeController controller;
       //private Model.MainPageModel modelmainpage;

        bool hasil;

        public void Tampildata()
        {
            controller.SelectHistory();
            controller.SelectKeuangan();
            controller.pengguna();
            controller.totalpengeluaran();
            //controller.sisapengeluaran();
            decimal sisa = Decimal.Parse(txt_Saldo.Text)- Decimal.Parse(txt_totalpengeluaran.Text);
            txt_sisa.Text = (decimal.Round(sisa, 2, MidpointRounding.AwayFromZero)).ToString();
 
        }
        public Home()
        {
            InitializeComponent();
            controller = new Controller.HomeController(this);
            Tampildata();    
        }

        private void btn_tambahtable_Click(object sender, RoutedEventArgs e)
        {
       

            hasil = controller.InsertData();
          

            Tampildata();

        }

        private void btnsaldo_Click(object sender, RoutedEventArgs e)
        {
            hasil = controller.UpdateSaldo();
         
            Tampildata();

        }


        private void btn_Delete_Click(object sender, RoutedEventArgs e)

        {

            hasil = controller.DeleteData();
         

            Tampildata();
        }

     

      

        private void btn_view_edit_Click(object sender, RoutedEventArgs e)
        {
            btn_tambahtable.IsEnabled = false;
            btn_edittable.IsEnabled = true;
        }

        private void btn_view_tambah_Click(object sender, RoutedEventArgs e)
        {
            txt_No.Text = "";
            txt_Barang.Text = "";
            txt_harga.Text = "";
            dtTanggal.Text = "";
            cbKeterangan.Text = "";
            btn_edittable.IsEnabled = false;
            btn_tambahtable.IsEnabled = true;
        }


        private void btn_edittable_Click(object sender, RoutedEventArgs e)
        {
            hasil = controller.Updatedata();
         
            Tampildata();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object item = ListView.SelectedItem;
            
        }
    }
}
