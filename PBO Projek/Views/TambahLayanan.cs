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
    public partial class TambahLayanan : Form
    {
        String title = "Mekanik Hunter";
        private bool IsEditing;
        bool cek = false;
        C_Homepage Controller;
        public TambahLayanan(C_Homepage controller, bool isEditing)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Controller = controller;
            this.IsEditing = isEditing;
            SetButtonStatus();
        }

        private void SetButtonStatus()
        {
            if (IsEditing)
            {
                button2.Enabled = false; button3.Enabled = true;
            }
            else
            {
                button2.Enabled = true; button3.Enabled = false;
            }
        }
        private void TambahLayanan_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string namalayanan = txtLayanan.Text;
            decimal harlay;
            bool harga = decimal.TryParse(txtHarLay.Text, out harlay);
            if (harga)
            {
                try
                {
                    cekkosong();
                    if (cek)
                    {
                        Controller.AddLayanan(namalayanan, harlay);
                        if (MessageBox.Show("Apakah anda yakin ingin menambah?", "Tambah Teknisi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show("Data Layanan Berhasil Ditambah", title);
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
            txtLayanan.Clear();
            txtHarLay.Clear();

        }

        public void cekkosong()
        {
            if (txtLayanan.Text == "" || txtHarLay.Text == "")
            {
                MessageBox.Show("Isilah Data Jangan Kosong", "Warning");
                return;
            }
            cek = true;
        }

        private void txtHarLay_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
