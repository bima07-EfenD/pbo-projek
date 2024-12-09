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
    public partial class V_ManagementTeknisi : UserControl
    {
        C_HomepageOwner Controller;
        private string connectionString = "Host=localhost;Database=MekanikHunter;Username=postgres;Password=123";
        string title = "Mekanik Hunter";

        public V_ManagementTeknisi(C_HomepageOwner controller)
        {
            InitializeComponent();
            Controller = controller;
            dgvteknisi();
            dgvdatakasir();
        }

        private void V_ManagementTeknisi_Load(object sender, EventArgs e)
        {

        }

        private void dgvManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvManagement.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Yakin ingin menghapus ?", "Hapus Teknisi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int idTeknisi = Convert.ToInt32(dgvManagement.Rows[e.RowIndex].Cells["Column1"].Value);
                        string query = "DELETE FROM data_teknisi WHERE Id_Teknisi = @Column1";

                        using (var conn = new NpgsqlConnection(connectionString))
                        {
                            conn.Open();
                            using (var cmd = new NpgsqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Column1", idTeknisi);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Data teknisi berhasil dihapus!", title);
                        dgvteknisi();

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, title);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TambahTeknisi tambahProduk = new TambahTeknisi(Controller);
            tambahProduk.ShowDialog();
            dgvteknisi();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormDataKasir kasir = new FormDataKasir(Controller);
            kasir.ShowDialog();
        }

        public void dgvteknisi()
        {
            try
            {
                dgvManagement.Rows.Clear();
                string query = "SELECT Id_Teknisi, Nama_Teknisi FROM Data_Teknisi";
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
                        dgvManagement.Rows.Clear();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            dgvManagement.Rows.Add(row["No"], row["Id_Teknisi"], row["Nama_Teknisi"]);
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT Id_Teknisi, Nama_Teknisi FROM Data_Teknisi WHERE Nama_Teknisi LIKE @searchText";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open(); using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchText", "%" + txtSearch.Text + "%");
                    DataTable dataTable = new DataTable();
                    dataTable.Load(cmd.ExecuteReader());
                    dataTable.Columns.Add("No", typeof(int));
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dataTable.Rows[i]["No"] = i + 1;
                    }
                    dgvManagement.Rows.Clear();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        dgvManagement.Rows.Add(row["No"], row["Id_Teknisi"], row["Nama_Teknisi"]);
                    }
                }
            }
        }
        public void dgvdatakasir()
        {
            try
            {
                dgvKasir.Rows.Clear();
                string query = "SELECT id_kasir, nama_kasir, username, password FROM data_kasir";
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
                        dgvKasir.Rows.Clear();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            dgvKasir.Rows.Add(row["No"], row["Id_Kasir"], row["Nama_Kasir"], row["Username"], row["Password"]);
                        }

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT Id_Kasir, Nama_Kasir, Username, Password FROM Data_Kasir WHERE Nama_Kasir LIKE @searchText";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open(); using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchText", "%" + txtsKas.Text + "%");
                    DataTable dataTable = new DataTable();
                    dataTable.Load(cmd.ExecuteReader());
                    dataTable.Columns.Add("No", typeof(int));
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dataTable.Rows[i]["No"] = i + 1;
                    }
                    dgvKasir.Rows.Clear();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        dgvKasir.Rows.Add(row["No"], row["Id_Kasir"], row["Nama_Kasir"], row["Username"], row["Password"]);
                    }
                }
            }
        }

        private void dgvKasir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvKasir.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FormDataKasir kasir = new FormDataKasir(Controller);
                kasir.lblEid.Text = dgvKasir.Rows[e.RowIndex].Cells[1].Value.ToString();
                kasir.txtNamaKas.Text = dgvKasir.Rows[e.RowIndex].Cells[2].Value.ToString();
                kasir.txtUserKas.Text = dgvKasir.Rows[e.RowIndex].Cells[3].Value.ToString();
                kasir.txtPassKas.Text = dgvKasir.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            else if (colName == "Hapus")
            {
                try
                {
                    if (MessageBox.Show("Yakin ingin menghapus ?", "Hapus Kasir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int idTeknisi = Convert.ToInt32(dgvManagement.Rows[e.RowIndex].Cells["Column1"].Value);
                        string query = "DELETE FROM Data_Kasir WHERE Id_Kasir = @Column1";

                        using (var conn = new NpgsqlConnection(connectionString))
                        {
                            conn.Open();
                            using (var cmd = new NpgsqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Column1", idTeknisi);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Data teknisi berhasil dihapus!", title);
                        dgvdatakasir();

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, title);
                }
            }
        }
    }
}
