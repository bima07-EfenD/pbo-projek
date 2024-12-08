using PBO_Projek.Controller;
using PBO_Projek.Views.Homepage;
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
    public partial class V_HomePageTeknisi : Form
    {
        C_HomepageTeknisi Controller;
        public V_HomePageTeknisi()
        {
            InitializeComponent();
            Controller = new C_HomepageTeknisi(this);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void V_HomePageTeknisi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.V_layananServis = new Teknisi.V_LayananServis(Controller);
            Controller.SwitchView(Controller.V_layananServis);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller.V_sukuCadang = new V_SukuCadang(Controller);
            Controller.SwitchView(Controller.V_sukuCadang);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
