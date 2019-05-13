using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AnakKost.Model
{
    class JadwalModel
    {
        private SqlConnection conn;
        private SqlCommand command;

        //declarasi variabel
        private string query;
        private bool hasil;

        //constructor
        public JadwalModel()
        {
            conn = Connect.Koneksi.GetKoneksi();
        }
        private string No;
        private string Hari;
        private string Kegiatan;
        private string Keterangan;

        public string GetNo()
        {
            return No;
        }

        public void SetNo(string No)
        {
            this.No = No;
        }
        public string GetHari()
        {
            return Hari;
        }

        public void SetHari(string Hari)
        {
            this.Hari = Hari;
        }
        public string GetKegiatan()
        {
            return Kegiatan;
        }

        public void SetKegiatan(string Kegiatan)
        {
            this.Kegiatan = Kegiatan;
        }
        public string GetKeterangan()
        {
            return Keterangan;
        }

        public void SetKeterangan(string Keterangan)
        {
            this.Keterangan = Keterangan;
        }


    }
}
