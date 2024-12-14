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
    public partial class FormTambahKategori : Form
    {
        C_SukuCadang Controller;
        string title = "Mekanik Hunter";
        bool cek = false;
        public FormTambahKategori(C_SukuCadang controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void FormTambahKategori_Load(object sender, EventArgs e)
        {
            var kategorilist = Controller.GetDataKategori();
        }
        private void txtNamaTek_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string namakategori = txtNamakategori.Text;
            try
            {
                cekkosong();
                if (cek)
                {
                    if (MessageBox.Show("Apakah anda yakin ingin menambah?", "Tambah Teknisi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Controller.AddKategori(namakategori);
                        MessageBox.Show("Data Teknisi Berhasil Ditambah", title);
                        Clear();
                        cek = false;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void cekkosong()
        {
            if (txtNamakategori.Text == "")
            {
                MessageBox.Show("Isilah Nama Jangan Kosong", "Warning");
                return;
            }
            cek = true;
        }
        public void Clear()
        {
            txtNamakategori.Clear();

        }
    }
}
