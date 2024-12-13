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
            V_sukuCadang = new V_SukuCadang(this);
            V_riwayatTransaksi = new V_RiwayatTransaksi(this);
            V_Tambahlayanan = new V_TambahLayanan(this);
            V_ManagementTeknisi = new V_ManagementTeknisiDanKasir(this);
            SwitchView(V_ManagementTeknisi);
        }
        public void SwitchView(UserControl view)
        {
            homepageOwner.panel2.Controls.Clear();
            homepageOwner.panel2.Controls.Add(view);
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
