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
    public partial class FormTambahKategori : Form
    {
        C_SukuCadang Controller;

        
        public FormTambahKategori(C_SukuCadang controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void FormTambahKategori_Load(object sender, EventArgs e)
        {
            var kategorilist = Controller.GetDataKategori();

        }
    }
}
