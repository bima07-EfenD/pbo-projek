using Npgsql;
using PBO_Projek.Core;
using PBO_Projek.Views;
using PBO_Projek.Views.Homepage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Controller
{
    public class C_Homepage : Connector
    {
        private string connectionString = "Host=localhost;Database=MekanikHunter;Username=postgres;Password=123";
        string title = "Mekanik Hunter";
        C_Homepage Controller;
        public HomepageOwner homepageOwner;
        public V_ManagementTeknisiDanKasir V_ManagementTeknisi;
        public V_SukuCadang V_sukuCadang;
        public V_RiwayatTransaksi V_riwayatTransaksi;
        public V_TambahLayanan V_Tambahlayanan;

        public C_Homepage(HomepageOwner homepageowner)
        {
            this.homepageOwner = homepageowner;
            V_ManagementTeknisi = new V_ManagementTeknisiDanKasir(this);
            V_sukuCadang = new V_SukuCadang(this);
            V_riwayatTransaksi = new V_RiwayatTransaksi(this);
            V_Tambahlayanan = new V_TambahLayanan(this);
            SwitchView(V_ManagementTeknisi);
        }
        public void SwitchView(UserControl view)
        {
            homepageOwner.panel2.Controls.Clear();
            homepageOwner.panel2.Controls.Add(view);
        }


        public void AddTeknisi(string namaTeknisi) 
        {
            string query = @" INSERT INTO Data_Teknisi (Nama_Teknisi) VALUES (@NamaTeknisi); ";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query)) 
            {
                
                cmd.Parameters.AddWithValue("@NamaTeknisi", namaTeknisi); 
                Execute_No_Return(cmd);
            } 
        }

        public void AddKasir(string namakasir, string username, string password)
        {
            string query = @" INSERT INTO Data_Kasir (Nama_Kasir,Username,Password)VALUES(@NamaKasir,@Username,@Password); ";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@NamaKasir", namakasir);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    Execute_No_Return(cmd);
                }
            }
        }
        public void EditKasir(int idkasir, string namakasir, string username, string password)
        {
            string query = @" UPDATE data_kasir SET nama_kasir = :nama_kasir, username = :username, password = :password WHERE id_kasir = :id_kasir; ";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query))
                {
                    cmd.Parameters.AddWithValue(":Id_Kasir", idkasir);
                    cmd.Parameters.AddWithValue(":Nama_Kasir", namakasir);
                    cmd.Parameters.AddWithValue(":Username", username);
                    cmd.Parameters.AddWithValue(":Password", password);
                    Execute_No_Return(cmd);
                }
            }
        }
        public void AddSuCa(string namaSukuCadang, int stok, decimal harga)
        {
            string query = @" INSERT INTO Data_Suku_Cadang (Nama_Suku_Cadang, Stok, Harga) VALUES (:Nama_Suku_Cadang, :Stok, :Harga); ";
            using (var conn = new NpgsqlConnection(connectionString))
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

        public void AddLayanan(string namalayanan, decimal harlay)
        {
            string query = @" INSERT INTO Data_Layanan (Nama_Layanan, Harga_Layanan) VALUES (:Nama_Layanan, :Harga_Layanan); ";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(":Nama_Layanan", namalayanan);
                    cmd.Parameters.AddWithValue(":Harga_Layanan", harlay);
                    cmd.ExecuteNonQuery();
                }
            }
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
    }
}
