using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AnakKost.Model
{
    class LoginModel
    {
        //object class conn
        private SqlConnection conn;
        private SqlCommand command;
        //declare variabel
        private string query;
        private bool hasil;

        //construktor
        public LoginModel()
        {
            conn = Connect.Koneksi.GetKoneksi ();
        }

        //enkapsulasi

        private string No_Pengguna;
        private string NamaPengguna;
        private string UserNama;
        private string Password;

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

        //fungsi
        //1. Login
        public bool Login(string user, string password)
        {
            query = "SELECT * FROM datapengguna WHERE UserNama = '" + user + "'" +
                    " AND Password = '" + password + "'";
            conn.Open();

            SqlCommand command = conn.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((reader.GetString(2).ToString() == user) &&
                    (reader.GetString(3).ToString() == password))
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
