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
                string query = "SELECT Id_Teknisi, Nama_Teknisi FROM Data_Teknisi WHERE IsActive = TRUE";

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
            var layananList = new List<M_Layanancs>();
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
                                    Id_Layanan = reader.GetInt32(0),
                                    Nama_Layanan = reader.GetString(1),
                                    Harga_Layanan = reader.GetDecimal(2)
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
            var sukuCadangList = new List<M_SukuCadang>();
            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Id_Suku_Cadang, Nama_Suku_Cadang, Harga FROM Data_Suku_Cadang";
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
                                    Id_Suku_Cadang = reader.GetInt32(0),
                                    Nama_Suku_Cadang = reader.GetString(1),
                                    Harga = reader.GetDecimal(2)
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

        public int GetStokSukuCadang(int idSukuCadang)
        {
            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Stok FROM Data_Suku_Cadang WHERE Id_Suku_Cadang = @IdSukuCadang";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@IdSukuCadang", idSukuCadang);
                        var result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int stok))
                        {
                            return stok;
                        }
                        return 0; 
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return 0; 
                    }
                }
            }
        }


        public void SimpanServis(M_Servis servisHeader, List<M_Servis_Detail> servisDetails)
        {
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        string queryHeader = @"
                    INSERT INTO Data_Servis (Nama_Pemilik, No_Kendaraan, Id_Teknisi, Total_Harga, Tanggal_Servis)
                    VALUES (@NamaPemilik, @NoKendaraan, @IdTeknisi, @TotalHarga, @TanggalServis)
                    RETURNING Id_Servis;";
                        int idServis;
                        using (var cmd = new NpgsqlCommand(queryHeader, conn))
                        {
                            cmd.Parameters.AddWithValue("@NamaPemilik", servisHeader.Nama_Pemilik);
                            cmd.Parameters.AddWithValue("@NoKendaraan", servisHeader.No_Kendaraan);
                            cmd.Parameters.AddWithValue("@IdTeknisi", servisHeader.Id_Teknisi);
                            cmd.Parameters.AddWithValue("@TotalHarga", servisHeader.Total_Harga);
                            cmd.Parameters.AddWithValue("@TanggalServis", servisHeader.Tanggal_Servis);
                            idServis = (int)cmd.ExecuteScalar();
                        }

                        string queryDetail = @"
                    INSERT INTO Detail_Servis (Id_Servis, Id_Layanan, Id_Suku_Cadang, Jumlah, Harga)
                    VALUES (@IdServis, @IdLayanan, @IdSukuCadang, @Jumlah, @Harga);";

                        string queryUpdateStok = @"
                    UPDATE Data_Suku_Cadang
                    SET Stok = Stok - @Jumlah
                    WHERE Id_Suku_Cadang = @IdSukuCadang AND Stok >= @Jumlah;";

                        foreach (var detail in servisDetails)
                        {
                            using (var cmdDetail = new NpgsqlCommand(queryDetail, conn))
                            {
                                cmdDetail.Parameters.AddWithValue("@IdServis", idServis);
                                cmdDetail.Parameters.AddWithValue("@IdLayanan", detail.Id_Layanan != 0 ? (object)detail.Id_Layanan : DBNull.Value);
                                cmdDetail.Parameters.AddWithValue("@IdSukuCadang", detail.Id_Suku_Cadang != 0 ? (object)detail.Id_Suku_Cadang : DBNull.Value);
                                cmdDetail.Parameters.AddWithValue("@Jumlah", detail.Jumlah);
                                cmdDetail.Parameters.AddWithValue("@Harga", detail.Harga);
                                cmdDetail.ExecuteNonQuery();
                            }

                            if (detail.Id_Suku_Cadang != 0) 
                            {
                                using (var cmdUpdateStok = new NpgsqlCommand(queryUpdateStok, conn))
                                {
                                    cmdUpdateStok.Parameters.AddWithValue("@IdSukuCadang", detail.Id_Suku_Cadang);
                                    cmdUpdateStok.Parameters.AddWithValue("@Jumlah", detail.Jumlah);
                                    int rowsAffected = cmdUpdateStok.ExecuteNonQuery();
                                    if (rowsAffected == 0)
                                    {
                                        throw new Exception("Stok tidak mencukupi untuk suku cadang dengan ID: " + detail.Id_Suku_Cadang);
                                    }
                                }
                            }
                        }

                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

    }
}
