using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AnakKost.Connect
{
    class Koneksi
    {
        private static SqlConnection koneksi;

        public static SqlConnection GetKoneksi()
        {
            koneksi = new SqlConnection();
            koneksi.ConnectionString = "Data Source=DESKTOP-9JAV6RI\\SQLEXPRESS;" +
                                        "Initial Catalog=Anakkost;" +
                                        "Integrated Security=True";
            return koneksi;
        }
    }
}
