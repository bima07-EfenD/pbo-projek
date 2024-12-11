using Npgsql;
using PBO_Projek.Controller;
using System;
using System.Collections.Generic;   
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Projek.Views.Homepage
{
    public partial class V_SukuCadang : UserControl
    {
        private string connectionString = "Host=localhost;Database=MekanikHunter;Username=postgres;Password=123";
        C_Homepage Controller;
        C_HomepageTeknisi _Controller;
        string title = "Mekanik Hunter";
        public V_SukuCadang(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            dgvsukucadang();
        }
        public V_SukuCadang(C_HomepageTeknisi controller)
        {
            InitializeComponent();
            _Controller = controller;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void V_SukuCadang_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSukuCadang sukuCadang = new FormSukuCadang(Controller);
            sukuCadang.ShowDialog();
        }

        public void dgvsukucadang()
        {
            try
            {
                dgvSukuCadang.Rows.Clear();
                string query = "SELECT Id_Suku_Cadang, Nama_Suku_Cadang, Stok, Harga FROM Data_Suku_Cadang";
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(cmd.ExecuteReader());
                        dataTable.Columns.Add("No", typeof(int));
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            dataTable.Rows[i]["No"] = i + 1;
                        }
                        dgvSukuCadang.Rows.Clear();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            dgvSukuCadang.Rows.Add(row["No"], row["Id_Suku_Cadang"], row["Nama_Suku_Cadang"], row["Stok"], row["Harga"]);
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }
    }
}
