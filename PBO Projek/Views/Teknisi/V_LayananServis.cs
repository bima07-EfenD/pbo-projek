using PBO_Projek.Controller;
using PBO_Projek.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Projek.Views.Teknisi
{
    public partial class V_LayananServis : UserControl
    {
        C_Homepage Controller;
        C_Servis Servis;
        private List<M_Servis_Detail> servisDetails = new List<M_Servis_Detail>();
        public V_LayananServis(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            InitializeGrid();
            Servis = new C_Servis(Controller, this);
        }

        private void V_LayananServis_Load(object sender, EventArgs e)
        {
            comboboxload();
            DataGridLoad();
        }

        private void comboboxload()
        {
            comboBox3.DataSource = Servis.GetAllTeknisi();
            comboBox3.DisplayMember = "Nama_Teknisi";
            comboBox3.ValueMember = "Id_Teknisi";

            comboBox1.DataSource = Servis.GetAllLayanan();
            comboBox1.DisplayMember = "Nama_Layanan";
            comboBox1.ValueMember = "Id_Layanan";

            comboBox2.DataSource = Servis.GetAllSukuCadang();
            comboBox2.DisplayMember = "Nama_Suku_Cadang";
            comboBox2.ValueMember = "Id_Suku_Cadang";

        }

        private void DataGridLoad()
        {
            var layananlist = Servis.GetAllLayanan();
            var sukucadanglist = Servis.GetAllSukuCadang();


            foreach (var layanan in layananlist)
            {
                dataGridViewLayanan.Rows.Add(layanan.Nama_Layanan, layanan.Harga_Layanan);
            }
            foreach (var sukucadang in sukucadanglist)
            {
                dataGridViewSukuCadang.Rows.Add(sukucadang.Nama_Suku_Cadang, sukucadang.Harga);
            }

        }

        private void InitializeGrid()
        {
            dataGridViewPesanan.Columns.Clear(); // Bersihkan kolom

            dataGridViewPesanan.Columns.Add("ID_Layanan", "ID Layanan");
            dataGridViewPesanan.Columns.Add("ID_SukuCadang", "ID Suku Cadang");

            dataGridViewPesanan.Columns["ID_Layanan"].Visible = false;
            dataGridViewPesanan.Columns["ID_SukuCadang"].Visible = false;

            dataGridViewPesanan.Columns.Add("NamaItem", "Nama Item");
            dataGridViewPesanan.Columns.Add("Jumlah", "Jumlah");
            dataGridViewPesanan.Columns.Add("Harga", "Harga");

            dataGridViewPesanan.Columns["Harga"].ReadOnly = true;
            dataGridViewPesanan.AllowUserToAddRows = false;
        }



        private void TambahKeGrid(string namaItem, int jumlah, decimal hargaSatuan, bool isLayanan, int idLayanan = 0, int idSukuCadang = 0)
        {
            bool itemDitemukan = false;

            foreach (DataGridViewRow row in dataGridViewPesanan.Rows)
            {
                if (row.Cells["NamaItem"].Value?.ToString() == namaItem)
                {
                    itemDitemukan = true;

                    if (isLayanan)
                    {
                        MessageBox.Show("Layanan ini sudah dipilih!", "Duplikat Layanan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int jumlahSebelumnya = Convert.ToInt32(row.Cells["Jumlah"].Value);
                        row.Cells["Jumlah"].Value = jumlahSebelumnya + jumlah;
                        row.Cells["Harga"].Value = hargaSatuan * (jumlahSebelumnya + jumlah);
                    }
                    break;
                }
            }

            if (!itemDitemukan)
            {
                decimal hargaTotal = hargaSatuan * jumlah;
                dataGridViewPesanan.Rows.Add(idLayanan, idSukuCadang, namaItem, jumlah, hargaTotal);
            }

            HitungTotalHarga();
        }






        private bool ItemSudahAda(string namaItem)
        {
            foreach (DataGridViewRow row in dataGridViewPesanan.Rows)
            {
                if (row.Cells["NamaItem"].Value != null && row.Cells["NamaItem"].Value.ToString() == namaItem)
                {
                    return true;
                }
            }
            return false;
        }

        private decimal HitungTotalHarga()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridViewPesanan.Rows)
            {
                if (!row.IsNewRow)
                {
                    total += Convert.ToDecimal(row.Cells["Harga"].Value);
                }
            }

            label10.Text = total.ToString("N0");
            return total;
        }


        private void ResetForm()
        {
            textBox2.Clear();
            textBox1.Clear();
            comboBox3.SelectedIndex = -1;
            label10.Text.Trim();
            dataGridViewPesanan.Rows.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var selectedLayanan = (M_Layanancs)comboBox1.SelectedItem;
            if (selectedLayanan == null) return;

            string namaItem = selectedLayanan.Nama_Layanan;
            decimal harga = selectedLayanan.Harga_Layanan;
            int jumlah = 1;

            TambahKeGrid(selectedLayanan.Nama_Layanan, 1, selectedLayanan.Harga_Layanan, true, idLayanan: selectedLayanan.Id_Layanan);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var selectedSukuCadang = (M_SukuCadang)comboBox2.SelectedItem;
            if (selectedSukuCadang == null) return;

            int jumlah;
            if (!int.TryParse(textBox3.Text, out jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah harus berupa angka positif!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TambahKeGrid(selectedSukuCadang.Nama_Suku_Cadang, jumlah, selectedSukuCadang.Harga, false, idSukuCadang: selectedSukuCadang.Id_Suku_Cadang);
        }




        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Nama Pemilik harus diisi!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Nomor Kendaraan harus diisi!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dataGridViewPesanan.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada pesanan yang bisa diselesaikan!!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                M_Servis servisHeader = new M_Servis
                {
                    Nama_Pemilik = textBox2.Text.Trim(),
                    No_Kendaraan = textBox1.Text.Trim(),
                    Id_Teknisi = Convert.ToInt32(comboBox3.SelectedValue),
                    Total_Harga = HitungTotalHarga(),
                    Tanggal_Servis = DateTime.Now
                };

                servisDetails.Clear();
                foreach (DataGridViewRow row in dataGridViewPesanan.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        servisDetails.Add(new M_Servis_Detail
                        {
                            Id_Layanan = row.Cells["ID_Layanan"].Value != null ? Convert.ToInt32(row.Cells["ID_Layanan"].Value) : 0,
                            Id_Suku_Cadang = row.Cells["ID_SukuCadang"].Value != null ? Convert.ToInt32(row.Cells["ID_SukuCadang"].Value) : 0,
                            Jumlah = Convert.ToInt32(row.Cells["Jumlah"].Value),
                            Harga = Convert.ToDecimal(row.Cells["Harga"].Value)
                        });
                    }
                }

                Servis.SimpanServis(servisHeader, servisDetails);
                ResetForm();
                MessageBox.Show("Transaksi berhasil disimpan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }






        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
