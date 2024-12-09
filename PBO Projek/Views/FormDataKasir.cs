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
    public partial class FormDataKasir : Form
    {
        C_HomepageOwner Controller;
        String title = "Mekanik Hunter";
        bool cek = false;
        public FormDataKasir(C_HomepageOwner controller)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Controller = controller;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string namakasir = txtNamaKas.Text;
            string username = txtUserKas.Text;
            string password = txtPassKas.Text;
            try
            {
                cekkosong();
                if (cek)
                {
                    if (MessageBox.Show("Apakah anda yakin ingin menambah?", "Tambah Kasir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Controller.AddKasir(namakasir, username, password);
                        MessageBox.Show("Data Kasir Berhasil Ditambah", title);
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

        public void Clear()
        {
            txtNamaKas.Clear();
            txtPassKas.Clear();
            txtUserKas.Clear();
        }
        public void cekkosong()
        {
            if (txtNamaKas.Text == "" || txtPassKas.Text == "" || txtUserKas.Text == "")
            {
                MessageBox.Show("Isilah Nama Jangan Kosong", "Warning");
                return;
            }
            cek = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
