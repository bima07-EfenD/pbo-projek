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
    public class C_ManagementTeknisiDanKasir : Connector
    {
        C_Homepage Controller;
        V_ManagementTeknisiDanKasir vmanagement;
        public C_ManagementTeknisiDanKasir(C_Homepage controller,V_ManagementTeknisiDanKasir view)
        {
            Controller = controller;
            vmanagement = view;
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

        public List<M_Teknisi> GetDataTeknisi()
        {
            List<M_Teknisi> dtteknisi = new List<M_Teknisi>();
            DataTable query =Execute_With_Return("SELECT Id_Teknisi, Nama_Teknisi FROM Data_Teknisi");

            foreach (DataRow row in query.Rows)
            {
                M_Teknisi m_Teknisi = new M_Teknisi
                {
                    Id_Teknisi = Convert.ToInt32(row["Id_Teknisi"]),
                    Nama_Teknisi = row["Nama_Teknisi"].ToString(),
                };
                dtteknisi.Add(m_Teknisi);
            }
            return dtteknisi;
        }
        public void AddTeknisi(string namaTeknisi)
        {
            string query = @" INSERT INTO Data_Teknisi (Nama_Teknisi) VALUES (@NamaTeknisi); ";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open(); using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@namaTeknisi", namaTeknisi);
                    cmd.ExecuteNonQuery();
                }
            }
        }
            
        public void DeleteTeknisi(int idTeknisi)
        {
            string query = "DELETE FROM data_teknisi WHERE Id_Teknisi = @Id_Teknisi";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open(); using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_Teknisi", idTeknisi);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable SearchTeknisi(string searchText)
        {
            string query = "SELECT Id_Teknisi, Nama_Teknisi FROM Data_Teknisi WHERE Nama_Teknisi LIKE @searchText";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open(); using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    DataTable dataTable = new DataTable();
                    dataTable.Load(cmd.ExecuteReader());
                    dataTable.Columns.Add("No", typeof(int));
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dataTable.Rows[i]["No"] = i + 1;
                    }
                    return dataTable;
                }
            }
        }
        public List<M_Kasir> GetDataKasir()
        {
            List<M_Kasir> dtkasir = new List<M_Kasir>();
            DataTable query = Execute_With_Return("SELECT id_kasir, nama_kasir, username, password FROM data_kasir");

            foreach (DataRow row in query.Rows)
            {
                M_Kasir m_Kasir = new M_Kasir
                {
                    Id_Kasir = Convert.ToInt32(row["id_kasir"]),
                    Nama_Kasir = row["nama_kasir"].ToString(),
                    Username = row["username"].ToString(),
                    Password = row["password"].ToString(),
                };
                dtkasir.Add(m_Kasir);
            }
            return dtkasir;
        }

        public void AddKasir(string namakasir, string username, string password)
        {
            string query = @" INSERT INTO Data_Kasir (Nama_Kasir,Username,Password)VALUES(@NamaKasir,@Username,@Password); ";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@namaKasir", namakasir);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteKasir(int idKasir)
        {
            string query = "DELETE FROM Data_Kasir WHERE Id_Kasir = @Id_Kasir";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open(); using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_Kasir", idKasir);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditKasir(int idkasir, string namakasir, string username, string password)
        {
            string query = @" UPDATE data_kasir SET nama_kasir = :nama_kasir, username = :username, password = :password WHERE id_kasir = :id_kasir; ";
            using (var conn = new NpgsqlConnection(addres))
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

        public DataTable SearchKasir(string searchText)
        {
            string query = "SELECT id_kasir, nama_kasir, username, password FROM data_kasir WHERE nama_kasir LIKE @searchText";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open(); using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    DataTable dataTable = new DataTable(); dataTable.Load(cmd.ExecuteReader());
                    dataTable.Columns.Add("No", typeof(int));
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dataTable.Rows[i]["No"] = i + 1;
                    }
                    return dataTable;
                }
            }
        }
    }
}
