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
        bool cek = false;
        public TambahLayanan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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
            try
            {
                cekkosong();
                if (cek)
                {
                    if (MessageBox.Show("Apakah anda yakin ingin menambah?", "Tambah Teknisi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
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
    }
}
