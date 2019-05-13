using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace AnakKost.Model
{
    class HomeModel
    {
        private SqlConnection Conn;
        private SqlCommand command;
        private Model.HomeModel modelkeuangan;
        //declarasi variabel
        private string query;
        private bool hasil;
        //pengurangan
       
        //databae
        private string No;
        public string Getno()
        {
            return No;
        }

        public void Setno(string No)
        {
            this.No = No;
        }

        private string NamaBarang;
        public string Getnamabarang()
        {
            return NamaBarang;
        }

        public void Setnamabarang(string NamaBarang)
        {
            this.NamaBarang = NamaBarang;
        }

        private string Tanggal;
        public string Gettanggal()
        {
            return Tanggal;
        }

        public void Settanggal(string Tanggal)
        {
            this.Tanggal = Tanggal;
        }
        private string Harga;
        public string GetHarga()
        {
            return Harga;
        }

        public void Setharga(string Harga)
        {
            this.Harga = Harga;
        }
        private string Keterangan;
        public string Getketerangan()
        {
            return Keterangan;
        }

        public void Setketerangan(string Keterangan)
        {
            this.Keterangan = Keterangan;
        }
    

        //construktorpengurangan    



        //construktor
        public HomeModel()
        {
            Conn = Connect.Koneksi.GetKoneksi();
        }

        //select history
      
        
        public DataSet SelectHistory()
        {
            DataSet ds = new DataSet();
            try
            {
                Conn.Close();
                Conn.Open();
                command = new SqlCommand();
                command.Connection = Conn;
                command.CommandType = CommandType.Text;
                command.CommandText = " select Tanggal,sum(Harga) from Keuangan group by Tanggal";

                SqlDataAdapter sda = new SqlDataAdapter(command);


                sda.Fill(ds, "Keuangan");
                {

                }

            }
            catch (SqlException)
            {

            }
            return ds;
        }



        public DataSet SelectKeuangan()
        {
            DataSet ds = new DataSet();
            try
            {
                Conn.Close();
                Conn.Open();
                command = new SqlCommand();
                command.Connection = Conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT No, NamaBarang, Tanggal, Harga, Keterangan FROM Keuangan";
               SqlDataAdapter sda = new SqlDataAdapter(command);
                

                sda.Fill(ds, "Keuangan");
                {
                    
                }

            }
            catch (SqlException)
            {

            }
            return ds;
        }
        public DataSet TotalPengeluaran()
        {
            DataSet ds = new DataSet();
            try
            {
                Conn.Close();
                Conn.Open();
                command = new SqlCommand();
                command.Connection = Conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT COALESCE(SUM(Harga), 0) FROM Keuangan ";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Keuangan");



            }
            catch (SqlException)
            {

            }
            return ds;
        }

      



        //fungsi untuk menambahkan Data

        public Boolean insertdata()
        {
            hasil = false;
            try
            {


                query = "INSERT INTO Keuangan VALUES ('" + No + "', '" + NamaBarang + "','" + Tanggal + "','" + Harga + "','" + Keterangan + "')";
           
                command = new SqlCommand();
                command.Connection = Conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
             

            }
            catch (SqlException)
            {
                hasil = false;

            }
            return hasil;
        }

        public Boolean Updatedata()
        {
            hasil = false;
            try
            {
                query = "UPDATE Keuangan SET  NamaBarang = '" + NamaBarang + "', Tanggal ='" + Tanggal + "', Harga ='" + Harga + "', Keterangan ='" + Keterangan + "' WHERE No = " + No + "";
                command = new SqlCommand();
                command.Connection = Conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;


            }
            catch (SqlException)
            {
                hasil = false;

            }
            return hasil;
        }

        public Boolean deletdata()
        {
            hasil = false;
            try
            {
                query = "DELETE FROM Keuangan WHERE No = " + No + "";
                Conn.Close();
                Conn.Open();
                command = new SqlCommand();
                command.Connection = Conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
                   

            }
            catch (SqlException)
            {
                hasil = false;
            }
            return hasil;
        }
     



    }

      

    }



