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
    public class C_RiwayatTransaksi : Connector
    {
        C_Homepage Controller;
        V_RiwayatTransaksi Riwayat;

        public C_RiwayatTransaksi(C_Homepage controller, V_RiwayatTransaksi riwayat)
        {
            Controller = controller;
            Riwayat = riwayat;
        }

        public List<M_Servis> GetRiwayatTransaksi()
        {
            var riwayatList = new List<M_Servis>();

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = @"
                SELECT ds.Id_Servis, ds.Nama_Pemilik, ds.No_Kendaraan, ds.Id_Teknisi, 
                       ds.Total_Harga, ds.Tanggal_Servis, t.Nama_Teknisi
                FROM Data_Servis ds
                INNER JOIN Data_Teknisi t ON ds.Id_Teknisi = t.Id_Teknisi
                ORDER BY ds.Tanggal_Servis DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                riwayatList.Add(new M_Servis
                                {
                                    Id_Servis = reader.GetInt32(reader.GetOrdinal("Id_Servis")),
                                    Nama_Pemilik = reader.GetString(reader.GetOrdinal("Nama_Pemilik")),
                                    No_Kendaraan = reader.GetString(reader.GetOrdinal("No_Kendaraan")),
                                    Id_Teknisi = reader.GetInt32(reader.GetOrdinal("Id_Teknisi")),
                                    Total_Harga = reader.GetDecimal(reader.GetOrdinal("Total_Harga")),
                                    Tanggal_Servis = reader.GetDateTime(reader.GetOrdinal("Tanggal_Servis"))
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        throw;
                    }
                }
            }

            return riwayatList;
        }
        private class RiwayatViewModel
        {
            public int Id_Servis { get; set; }
            public string Nama_Pemilik { get; set; }
            public string No_Kendaraan { get; set; }
            public string Nama_Teknisi { get; set; }
            public DateTime Tanggal_Servis { get; set; }
            public decimal Total_Harga { get; set; }
        }

        public void LoadRiwayatTransaksi()
        {
            try
            {
                var servisList = GetRiwayatTransaksi();
                Riwayat.dgvLay.Rows.Clear();
                int no = 1;
                foreach (var servis in servisList)
                {
                    string namaTeknisi = GetNamaTeknisiById(servis.Id_Teknisi);

                    Riwayat.dgvLay.Rows.Add(
                        no++,
                        servis.Id_Servis,
                        servis.Nama_Pemilik,
                        servis.No_Kendaraan,
                        namaTeknisi,
                        servis.Tanggal_Servis.ToString("dd/MM/yyyy"),
                        servis.Total_Harga.ToString("C")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetNamaTeknisiById(int idTeknisi)
        {
            string namaTeknisi = string.Empty;

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Nama_Teknisi FROM Data_Teknisi WHERE Id_Teknisi = @IdTeknisi";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdTeknisi", idTeknisi);
                    try
                    {
                        conn.Open();
                        namaTeknisi = cmd.ExecuteScalar().ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return namaTeknisi;
        }
    }
}

