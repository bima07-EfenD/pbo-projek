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

namespace PBO_Projek.Views.Teknisi
{
    public partial class V_LayananServis : UserControl
    {
        C_Homepage Controller;
        C_Servis Servis;
        public V_LayananServis(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
