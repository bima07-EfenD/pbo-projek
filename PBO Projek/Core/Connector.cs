using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBO_Projek.Core
{
    public abstract class Connector
    {
        protected string addres = $"Host=localhost;Database=MekanikHunter;Username=postgres;Password=123";
        private NpgsqlConnection Conn;
        protected NpgsqlConnection conn
        {
            get
            {
                return this.Conn;
            }
            set
            {
                if (Conn != null)
                {
                    Conn.Close();
                    Conn.Dispose();
                    Conn = null;
                }
                Conn = value;
                Conn.Open();
            }
        }
        public void setup()
        {
            Execute_No_Return(@"
    CREATE TABLE IF NOT EXISTS Data_Kasir (
        Id_Kasir SERIAL PRIMARY KEY,
        Username VARCHAR(50) NOT NULL,
        Password VARCHAR(50) NOT NULL,
        Nama_Kasir VARCHAR(100) NOT NULL
    );
    ");

            Execute_No_Return(@"
    CREATE TABLE IF NOT EXISTS Data_Teknisi(
        Id_Teknisi SERIAL PRIMARY KEY,
        Nama_Teknisi VARCHAR(100) NOT NULL
    );
    ");

            Execute_No_Return(@"
    CREATE TABLE IF NOT EXISTS Data_Layanan (
         Id_Layanan SERIAL PRIMARY KEY,
         Nama_Layanan VARCHAR(100) NOT NULL,
         Harga_Layanan DECIMAL(10, 2) NOT NULL
    );
    ");

            Execute_No_Return(@"
    CREATE TABLE IF NOT EXISTS Data_Suku_Cadang (
         Id_Suku_Cadang SERIAL PRIMARY KEY,
         Nama_Suku_Cadang VARCHAR(100) NOT NULL,
         Kategori VARCHAR(50) ,
         Stok INT NOT NULL,
           Harga DECIMAL(10, 2) NOT NULL
    );
    ");

            Execute_No_Return(@"
    CREATE TABLE IF NOT EXISTS Data_Pesanan (
         Id_Pesanan SERIAL PRIMARY KEY,
         Nama_Pemilik VARCHAR(100) NOT NULL,
         Nomor_Kendaraan VARCHAR(50) NOT NULL,
         Harga_Pesanan DECIMAL(10, 2) NOT NULL,
         Id_Suku_Cadang INT,
         Id_Teknisi INT,
         FOREIGN KEY (Id_Suku_Cadang) REFERENCES Data_Suku_Cadang(Id_Suku_Cadang),
         FOREIGN KEY (Id_Teknisi) REFERENCES Data_Teknisi(Id_Teknisi)
);
    ");

            Execute_No_Return(@"
   CREATE TABLE IF NOT EXISTS Data_Transaksi (
         Id_Transaksi SERIAL PRIMARY KEY,
         Nama_Kendaraan VARCHAR(100) NOT NULL,
         Tanggal_Transaksi DATE NOT NULL,
         Harga_Total DECIMAL(10, 2) NOT NULL,
         Id_Kasir INT,
         Id_Pesanan INT,
         FOREIGN KEY (Id_Kasir) REFERENCES Data_Kasir(Id_Kasir),
         FOREIGN KEY (Id_Pesanan) REFERENCES Data_Pesanan(Id_Pesanan)
);
    ");
        }

        public void Execute_No_Return(string query)
        { 
            using (var conn = new NpgsqlConnection(addres)) 
            { 
                conn.Open(); using (var cmd = new NpgsqlCommand(query, conn)) 
                { 
                    cmd.ExecuteNonQuery(); 
                } 
            } 
        }
        public DataTable Execute_With_Return(string query) 
        {
            using (var conn = new NpgsqlConnection(addres)) 
            {
                conn.Open(); using (var cmd = new NpgsqlCommand(query, conn)) 
                {
                    DataTable data = new DataTable();
                    data.Load(cmd.ExecuteReader());
                    return data; 
                }
            } 
        }

        public DataTable Execute_With_Return(NpgsqlCommand query) 
        {
            using (var conn = new NpgsqlConnection(addres)) 
            {
                conn.Open(); 
                query.Connection = conn; 
                DataTable data = new DataTable(); 
                data.Load(query.ExecuteReader());
                return data; 
            } 
        }
    }
}
