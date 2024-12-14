using PBO_Projek.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Projek.Views
{
    public partial class FormSukuCadang : Form
    {
        C_SukuCadang Controller;
        String title = "Mekanik Hunter";
        bool cek = false;
        public FormSukuCadang(C_SukuCadang controller)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Controller = controller;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormSukuCadang_Load(object sender, EventArgs e)
        {
            var kategorilist = Controller.GetDataKategori();
            comboBox1.DataSource = kategorilist;
            comboBox1.DisplayMember = "Nama_Kategori";
            comboBox1.ValueMember = "Id_Kategori";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string namaSukuCadang = txtSuku.Text;
            int stok;
            decimal harga;
            bool stoknya = int.TryParse(txtStok.Text, out stok);
            bool harganya = decimal.TryParse(txtHarSuk.Text, out harga);
            if (stoknya && harganya)
            {
                try
                {
                    cekkosong();
                    if (cek)
                    {
                        if (MessageBox.Show("Apakah anda yakin ingin menambah?", "Tambah Suku Cadang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Controller.AddSuCa(namaSukuCadang, stok, harga);
                            MessageBox.Show("Data Suku Cadang Berhasil Ditambah", title);
                            Clear();
                            cek = false;
                        }

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, title);
                }
            }

        }
        public void Clear()
        {
            txtSuku.Clear();
            txtHarSuk.Clear();
            txtStok.Clear();

        }

        public void cekkosong()
        {
            if (txtSuku.Text == "" || txtHarSuk.Text == "" || txtSuku.Text == "")
            {
                MessageBox.Show("Isilah Data Jangan Kosong", "Warning");
                return;
            }
            cek = true;
        }

        private void txtHarSuk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHarSuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
