using PBO_Projek.Views;
using PBO_Projek.Views.Homepage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Controller
{
    public class C_HomepageOwner
    {
        C_HomepageOwner Controller;
        public HomepageOwner homepageOwner;
        public V_ManagementTeknisi V_ManagementTeknisi;
        public V_SukuCadang V_sukuCadang;
        public V_RiwayatTransaksi V_riwayatTransaksi;

        public C_HomepageOwner(HomepageOwner homepageowner)
        {
            this.homepageOwner = homepageowner;
            V_ManagementTeknisi = new V_ManagementTeknisi(this);
            V_sukuCadang = new V_SukuCadang(this);
            V_riwayatTransaksi = new V_RiwayatTransaksi(this);
            SwitchView(V_ManagementTeknisi);
        }
        public void SwitchView(UserControl view)
        {
                homepageOwner.panel2.Controls.Clear(); 
                homepageOwner.panel2.Controls.Add(view); 
        }
    }


}
