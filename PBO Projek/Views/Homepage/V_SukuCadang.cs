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
        C_Homepage Controller;
        C_SukuCadang csuca;
        C_HomepageTeknisi _Controller;
        string title = "Mekanik Hunter";
        public V_SukuCadang(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            csuca = new C_SukuCadang(Controller, this);
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
            FormSukuCadang sukuCadang = new FormSukuCadang(csuca);
            sukuCadang.ShowDialog();
        }

        public void dgvsukucadang()
        {
            try
            {
                dgvSukuCadang.Rows.Clear();
                var sukuCadangList = csuca.GetSukuCadang();
                if (sukuCadangList != null && sukuCadangList.Count > 0)
                {
                    int no = 1;
                    foreach (var sukuCadang in sukuCadangList)
                    {
                        dgvSukuCadang.Rows.Add(no++, sukuCadang.Nama_Suku_Cadang, sukuCadang.Nama_Kategori, sukuCadang.Stok, sukuCadang.Harga);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTambahKategori kategori =  new FormTambahKategori(csuca);
            kategori.ShowDialog();
        }
    }
}
