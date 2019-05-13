using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AnakKost.Model
{
    class MainPageModel
    {
        //object class con
        private SqlConnection conn;
        private SqlCommand command;

        //declarasi variabel
        private string query;
        private bool hasil;
      
        //constructor
        public MainPageModel()
        {
            conn = Connect.Koneksi.GetKoneksi();
        }
        //variabel sesuai dengan data 
        private string Saldo;
        private string NamaPengguna;
        private string UserNama;
        private string Password;
        private string No_Pengguna;

        public string Getno_pengguna()
        {
            return No_Pengguna;
        }

        public void Setno_pengguna(string No_Pengguna)
        {
            this.No_Pengguna = No_Pengguna;
        }
        public string Getnamapengguna()
        {
            return NamaPengguna;
        }

        public void Setnamapengguna(string NamaPengguna)
        {
            this.NamaPengguna = NamaPengguna;
        }

        public string Getusernama()
        {
            return UserNama;
        }

        public void Setusernama(string UserNama)
        {
            this.UserNama = UserNama;
        }

        public string Getpassword()
        {
            return Password;
        }

        public void Setpassword(string Password)
        {
            this.Password = Password;
        }
        public string Getsaldo()
        {
            return Saldo ;
        }

        public void Setsaldo(string Saldo)
        {
            this.Saldo = Saldo;
        }


        public DataSet pengguna()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Close();
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT NO_Pengguna, NamaPengguna, UserNama, Password, SaldoPengguna FROM datapengguna";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "datapengguna");
                conn.Close();
            }
            catch (SqlException)
            {

            }
           
            return ds;
        }

        public Boolean UpdatePengguna ()          
        {
            hasil = false;
            try
            {
                query = "UPDATE datapengguna SET  NamaPengguna = '" + NamaPengguna + "', UserNama = '" + UserNama + "', Password = '" + Password + "' WHERE NO_Pengguna = 1 ";
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
                conn.Close();
         

            }
            catch (SqlException)
            {
                hasil = false;
            }
            return hasil;
        }
        public Boolean UpdateSaldo()
        {
            hasil = false;
            try
            {
                query = "UPDATE datapengguna SET SaldoPengguna = '" + Saldo + "' WHERE NO_Pengguna = 1 ";
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
                conn.Close();


            }
            catch (SqlException)
            {
                hasil = false;
            }
            return hasil;
        }
        public bool DataLama(string password)
        {
            query = "SELECT * FROM datapengguna WHERE Password = '" + password + "'";
            conn.Open();

            SqlCommand command = conn.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((reader.GetString(3).ToString() == password))
                {
                    hasil = true;
                }
                else
                {
                    hasil = false;
                }
            }

            conn.Close();
            return hasil;
        }

    }
 }
    

