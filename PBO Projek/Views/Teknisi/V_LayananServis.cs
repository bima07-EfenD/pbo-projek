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
        C_HomepageTeknisi Controller;
        public V_LayananServis(C_HomepageTeknisi controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void V_LayananServis_Load(object sender, EventArgs e)
        {

        }
    }
}
