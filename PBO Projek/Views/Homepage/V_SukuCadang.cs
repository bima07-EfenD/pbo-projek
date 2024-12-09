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
        C_HomepageOwner Controller;
        C_HomepageTeknisi _Controller;
        public V_SukuCadang(C_HomepageOwner controller)
        {
            InitializeComponent();
            Controller = controller;
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
            FormSukuCadang sukuCadang = new FormSukuCadang(Controller);
            sukuCadang.ShowDialog();
        }

        public void dgvsukucadang()
        {

        }
    }
}
