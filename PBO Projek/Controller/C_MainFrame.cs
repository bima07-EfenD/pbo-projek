using PBO_Projek.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Controller
{
    public class C_MainFrame
    {
        C_MainFrame Controller;
        public MainFrame v_mainFrame;
        public V_awal v_awal;
        public V_LoginOwner v_LoginOwner;
        public V_LoginPemilik v_LoginPemilik;
        public C_MainFrame(MainFrame mainFrame)
        {
            this.v_mainFrame = mainFrame;
            v_awal = new V_awal(this);
            v_LoginOwner = new V_LoginOwner(this);
            v_LoginPemilik = new V_LoginPemilik(this);
            SwitchView(v_awal);

        }
        public void SwitchView(UserControl view)
        {
            v_mainFrame.panel1.Controls.Clear();
            v_mainFrame.panel1.Controls.Add(view);
        }
    }
}
