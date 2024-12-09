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
        C_HomepageOwner Controller;
        String title = "Mekanik Hunter";
        bool cek = false;
        public FormSukuCadang(C_HomepageOwner controller)
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
    }
}
