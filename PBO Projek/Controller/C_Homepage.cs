using Npgsql;
using PBO_Projek.Core;
using PBO_Projek.Views;
using PBO_Projek.Views.Homepage;
using PBO_Projek.Views.Teknisi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Controller
{
    public class C_Homepage : Connector
    {
        string title = "Mekanik Hunter";
        C_Homepage Controller;
        public HomepageOwner homepageOwner;
        public V_ManagementTeknisiDanKasir V_ManagementTeknisi;
        public V_SukuCadang V_sukuCadang;
        public V_RiwayatTransaksi V_riwayatTransaksi;
        public V_TambahLayanan V_Tambahlayanan;

        public HomepageKasir Kasir;
        public V_LayananServis layananServis;

        public C_Homepage(HomepageOwner homepageowner)
        {
            this.homepageOwner = homepageowner;
            V_sukuCadang = new V_SukuCadang(this);
            V_riwayatTransaksi = new V_RiwayatTransaksi(this);
            V_Tambahlayanan = new V_TambahLayanan(this);
            V_ManagementTeknisi = new V_ManagementTeknisiDanKasir(this);
            SwitchView(V_ManagementTeknisi);
        }

        public C_Homepage(HomepageKasir kasir)
        {
            this.Kasir = kasir;
            layananServis = new V_LayananServis(this);
            V_sukuCadang = new V_SukuCadang(this);
            V_riwayatTransaksi = new V_RiwayatTransaksi(this);
            SwitchView(layananServis);

        }
        public void SwitchView(UserControl view)
        {
            if (homepageOwner != null)
            {
                homepageOwner.panel2.Controls.Clear();
                homepageOwner.panel2.Controls.Add(view);
            }
            else if (Kasir != null)
            {
                Kasir.panel2.Controls.Clear(); 
                Kasir.panel2.Controls.Add(view);
            }
        }

        }
    }

