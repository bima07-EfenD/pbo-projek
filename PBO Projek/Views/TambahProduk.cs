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

namespace PBO_Projek.Views
{
    public partial class TambahTeknisi : Form
    {
        C_ManagementTeknisiDanKasir Controller;
        String title = "Mekanik Hunter";
        bool cek = false;
        public TambahTeknisi(C_ManagementTeknisiDanKasir controller)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Controller = controller;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string namaTeknisi = txtNamaTek.Text;
            try
            {
                cekkosong();
                if (cek)
                {
                    if (MessageBox.Show("Apakah anda yakin ingin menambah?", "Tambah Teknisi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Controller.AddTeknisi (namaTeknisi);
                        MessageBox.Show("Data Teknisi Berhasil Ditambah", title);
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

        private void TambahProduk_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            txtNamaTek.Clear();

        }

        public void cekkosong()
        {
            if (txtNamaTek.Text == "")
            {
                MessageBox.Show("Isilah Nama Jangan Kosong", "Warning");
                return;
            }
            cek = true;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
