using Npgsql;
using PBO_Projek.Core;
using PBO_Projek.Model;
using PBO_Projek.Views.Teknisi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Controller
{
    public class C_Servis : Connector
    {
        C_Homepage Controller;
        V_LayananServis Servis;

        public C_Servis(C_Homepage controller, V_LayananServis servis)
        {
            Controller = controller;
            this.Servis = servis;
        }

        public List<M_Teknisi> GetAllTeknisi()
        {
            List<M_Teknisi> teknisiList = new List<M_Teknisi>();

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Id_Teknisi, Nama_Teknisi FROM Data_Teknisi";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                teknisiList.Add(new M_Teknisi
                                {
                                    Id_Teknisi = reader.GetInt32(reader.GetOrdinal("Id_Teknisi")),
                                    Nama_Teknisi = reader.GetString(reader.GetOrdinal("Nama_Teknisi"))
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return teknisiList;
        }

        public List<M_Layanancs> GetAllLayanan()
        {
            List<M_Layanancs> layananList = new List<M_Layanancs>();

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Id_Layanan, Nama_Layanan, Harga_Layanan FROM Data_Layanan";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                layananList.Add(new M_Layanancs
                                {
                                    Id_Layanan = reader.GetInt32(reader.GetOrdinal("Id_Layanan")),
                                    Nama_Layanan = reader.GetString(reader.GetOrdinal("Nama_Layanan")),
                                    Harga_Layanan = reader.GetDecimal(reader.GetOrdinal("Harga_Layanan"))
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return layananList;
        }

        public List<M_SukuCadang> GetAllSukuCadang()
        {
            List<M_SukuCadang> sukuCadangList = new List<M_SukuCadang>();

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = @"
              SELECT sc.Id_Suku_Cadang, sc.Nama_Suku_Cadang, sc.Stok, sc.Harga, 
                 sc.Id_Kategori, kc.Nama_Kategori
              FROM Data_Suku_Cadang sc
              LEFT JOIN Kategori_Suku_Cadang kc ON sc.Id_Kategori = kc.Id_Kategori";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sukuCadangList.Add(new M_SukuCadang
                                {
                                    Id_Suku_Cadang = reader.GetInt32(reader.GetOrdinal("Id_Suku_Cadang")),
                                    Nama_Suku_Cadang = reader.GetString(reader.GetOrdinal("Nama_Suku_Cadang")),
                                    Harga = reader.GetDecimal(reader.GetOrdinal("Harga")),
                                    Stok = reader.GetInt32(reader.GetOrdinal("Stok")),
                                    Id_Kategori = reader.GetInt32(reader.GetOrdinal("Id_Kategori")),
                                    Nama_Kategori = reader.IsDBNull(reader.GetOrdinal("Nama_Kategori"))
                                        ? null
                                        : reader.GetString(reader.GetOrdinal("Nama_Kategori"))
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return sukuCadangList;
        }
    }
}
