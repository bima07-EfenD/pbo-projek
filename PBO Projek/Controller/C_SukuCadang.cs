using Npgsql;
using PBO_Projek.Core;
using PBO_Projek.Model;
using PBO_Projek.Views.Homepage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Controller
{
    public class C_SukuCadang : Connector
    {
        C_Homepage Controller;
        V_SukuCadang viewsuca;

        public C_SukuCadang(C_Homepage controller, V_SukuCadang view)
        {
            Controller = controller;
            viewsuca = view;
        }

        public void Execute_No_Return(NpgsqlCommand cmd)
        {
            using (var conn = new NpgsqlConnection(addres))
            {
                cmd.Connection = conn; 
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<M_SukuCadang> GetSukuCadang()
        {
            List<M_SukuCadang> sukuCadangList = new List<M_SukuCadang>();
            DataTable query = Execute_With_Return("SELECT Id_Suku_Cadang, Nama_Suku_Cadang, Stok, Harga FROM Data_Suku_Cadang");

            foreach (DataRow row in query.Rows)
            {
                M_SukuCadang m_SukuCadang = new M_SukuCadang()
                {
                    Id_Suku_Cadang = Convert.ToInt32(row["Id_Suku_Cadang"]),
                    Nama_Suku_Cadang = row["Nama_Suku_Cadang"].ToString(),
                    Stok = Convert.ToInt32(row["Stok"]),
                    Harga = Convert.ToDecimal(row["Harga"]),

                };
                sukuCadangList.Add(m_SukuCadang);
            }
            return sukuCadangList;
        }
        public void AddSuCa(string namaSukuCadang, int stok, decimal harga)
        {
            string query = @" INSERT INTO Data_Suku_Cadang (Nama_Suku_Cadang, Stok, Harga) VALUES (:Nama_Suku_Cadang, :Stok, :Harga); ";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(":Nama_Suku_Cadang", namaSukuCadang);
                    cmd.Parameters.AddWithValue(":stok", stok);
                    cmd.Parameters.AddWithValue(":harga", harga);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<M_Kategori> GetDataKategori()
        {
            List<M_Kategori> dtkategori = new List<M_Kategori>();
            DataTable query = Execute_With_Return("SELECT Id_Kategori, Nama_Kategori FROM Kategori_Suku_Cadang");
            foreach (DataRow row in query.Rows)
            {
                M_Kategori m_Kategori = new M_Kategori
                {
                    Id_Kategori = Convert.ToInt32(row["Id_Kategori"]),
                    Nama_Kategori = row["Nama_Kategori"].ToString(),
                };
                dtkategori.Add(m_Kategori);
            }
            return dtkategori;
        }
        public void AddKategori(string namaKategori)
        {
            string query = @"INSERT INTO Kategori_Suku_Cadang (Nama_Kategori) VALUES (:Nama_Kategori);";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(":Nama_Kategori", namaKategori);
                    cmd.ExecuteNonQuery();
                }
            }
        }



    }
}
