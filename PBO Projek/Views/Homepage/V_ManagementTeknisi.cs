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
    public partial class V_ManagementTeknisi : UserControl
    {
        C_HomepageOwner Controller;

        public V_ManagementTeknisi(C_HomepageOwner controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void V_ManagementTeknisi_Load(object sender, EventArgs e)
        {

        }

        private void dgvManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TambahProduk tambahProduk = new TambahProduk();
            tambahProduk.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TambahLayanan tambahLayanan = new TambahLayanan();
            tambahLayanan.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}