﻿using PBO_Projek.Controller;
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
    public partial class V_RiwayatTransaksi : UserControl
    {
        C_Homepage Controller;
        C_RiwayatTransaksi RiwayatTransaksi;
        public V_RiwayatTransaksi(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            RiwayatTransaksi = new C_RiwayatTransaksi(controller, this);
        }

        private void V_RiwayatTransaksi_Load(object sender, EventArgs e)
        {
            RiwayatTransaksi.LoadRiwayatTransaksi();
        }
    }
}
