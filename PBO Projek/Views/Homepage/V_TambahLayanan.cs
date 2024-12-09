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
    public partial class V_TambahLayanan : UserControl
    {
        C_HomepageOwner Controller;
        public V_TambahLayanan(C_HomepageOwner controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void V_TambahLayanan_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TambahLayanan tambahLayanan = new TambahLayanan();
            tambahLayanan.ShowDialog();
        }
    }
}
