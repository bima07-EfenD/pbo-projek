using PBO_Projek.Views.Homepage;
using PBO_Projek.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_Projek.Views.Teknisi;

namespace PBO_Projek.Controller
{
    public class C_HomepageTeknisi
    {
        C_HomepageTeknisi Controller;
        public V_HomePageTeknisi V_HomepageTeknisi;
        public V_LayananServis V_layananServis;
        public V_SukuCadang V_sukuCadang;

        public C_HomepageTeknisi(V_HomePageTeknisi homepageTeknisi)
        {
            this.V_HomepageTeknisi = homepageTeknisi;
            V_layananServis = new V_LayananServis(this);
            V_sukuCadang = new V_SukuCadang(this);
            SwitchView(V_layananServis);
        }
        public void SwitchView(UserControl view)
        {
            V_HomepageTeknisi.panel3.Controls.Clear();
            V_HomepageTeknisi.panel3.Controls.Add(view);

        }
    }
}
