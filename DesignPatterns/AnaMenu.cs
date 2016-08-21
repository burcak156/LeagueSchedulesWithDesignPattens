using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class AnaMenu : Form
    {
        ComponentConfiguration cc = ComponentConfiguration.getInstance();
        public AnaMenu()
        {
            InitializeComponent();
              foreach(Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromName(cc.getButtonStyle("first", "bgcolor"));
                    c.ForeColor = Color.FromName(cc.getButtonStyle("first", "textcolor"));
                }
            }
        }

        private void takim_btn_Click(object sender, EventArgs e)
        {
            TakimMenu takim = new TakimMenu();
            takim.Show();

        }

        private void salon_btn_Click(object sender, EventArgs e)
        {
            SalonMenu sln = new SalonMenu();
            sln.Show();
        }

        private void hakem_btn_Click(object sender, EventArgs e)
        {
            HakemMenu hkm = new HakemMenu();
            hkm.Show();
        }

        private void btn_mac_Click(object sender, EventArgs e)
        {
            MacIslemleri mc = new MacIslemleri();
            mc.Show();
        }
    }
}
