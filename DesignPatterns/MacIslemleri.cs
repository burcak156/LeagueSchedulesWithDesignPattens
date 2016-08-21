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
    public partial class MacIslemleri : Form
    {
        ComponentConfiguration cc = ComponentConfiguration.getInstance();
        maclar mc;
        macController macc;
        takimlar t;
        TakimController tcont;
        HakemController hcont;
        SalonController scont;
        CreateFixture cfix;
        AutoRefree aRef;
        MusabakaController mcont;
        LogWrite log;
        Logger logs = Logger.getInstance();
        public MacIslemleri()
        {
            InitializeComponent();
            macc = new macController();
            t = new takimlar();
            tcont = new TakimController();
            hcont = new HakemController();
            scont = new SalonController();
            mc = new maclar();
            tabPage1styleRun();
            tabPage2styleRun();
        }
        public void gridDoldur()
        {
            cfix = new CreateFixture();
            mcont = new MusabakaController(cfix);
            this.bindingSource1.DataSource = this.mcont.fixtureListele();
            homeIDDataGridViewComboBoxColumn.DataSource = tcont.takimListele();
            homeIDDataGridViewComboBoxColumn.ValueMember = "id";
            homeIDDataGridViewComboBoxColumn.DisplayMember = "adi";
            awayIDDataGridViewComBoxColumn.DataSource = tcont.takimListele();
            awayIDDataGridViewComBoxColumn.ValueMember = "id";
            awayIDDataGridViewComBoxColumn.DisplayMember = "adi";
            salonIDDataGridViewComBoxColumn.DataSource = scont.salonListele();
            salonIDDataGridViewComBoxColumn.ValueMember = "id";
            salonIDDataGridViewComBoxColumn.DisplayMember = "adi";
            basHakemIDDataGridViewComboBoxColumn.DataSource = hcont.hakemListele();
            basHakemIDDataGridViewComboBoxColumn.ValueMember = "id";
            basHakemIDDataGridViewComboBoxColumn.DisplayMember = "soyadi";
            yHakemIDDataGridViewComboBoxColumn.DataSource = hcont.hakemListele();
            yHakemIDDataGridViewComboBoxColumn.ValueMember = "id";
            yHakemIDDataGridViewComboBoxColumn.DisplayMember = "soyadi";
            iyHakemIDDataGridViewComboBoxColumn.DataSource = hcont.hakemListele();
            iyHakemIDDataGridViewComboBoxColumn.ValueMember = "id";
            iyHakemIDDataGridViewComboBoxColumn.DisplayMember = "soyadi";
        }

        private void tabPage1styleRun()
        {
            foreach (Control c in tabPage1.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromName(cc.getButtonStyle("first", "bgcolor"));
                    c.ForeColor = Color.FromName(cc.getButtonStyle("first", "textcolor"));
                }
                if (c is ComboBox)
                {
                    c.BackColor = Color.FromName(cc.getcomboBoxStyle("first", "bgcolor"));
                    c.ForeColor = Color.FromName(cc.getcomboBoxStyle("first", "fgcolor"));
                }
                if (c is Label)
                    c.ForeColor = Color.FromName(cc.getLabelStyle("second", "textcolor"));
                if (c is TextBox)
                    c.ForeColor = Color.FromName(cc.getTextboxStyle("second", "textcolor"));
            }
        }

        private void tabPage2styleRun()
        {
            foreach (Control c in tabPage2.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromName(cc.getButtonStyle("first", "bgcolor"));
                    c.ForeColor = Color.FromName(cc.getButtonStyle("first", "textcolor"));
                }
                if (c is ComboBox)
                {
                    c.BackColor = Color.FromName(cc.getcomboBoxStyle("first", "bgcolor"));
                    c.ForeColor = Color.FromName(cc.getcomboBoxStyle("first", "fgcolor"));
                }
                if (c is Label)
                    c.ForeColor = Color.FromName(cc.getLabelStyle("second", "textcolor"));
                if (c is TextBox)
                    c.ForeColor = Color.FromName(cc.getTextboxStyle("second", "textcolor"));
                if (c is DataGridView)
                {
                    c.BackColor = Color.FromName(cc.getdataGridStyle("first", "bgcolor"));
                    c.ForeColor = Color.FromName(cc.getdataGridStyle("first", "textcolor"));
                }
            }
        }


        private void btn_createFix_Click(object sender, EventArgs e)
        {
            cfix = new CreateFixture();
            mcont = new MusabakaController(cfix);
            log = new LogWrite(cfix);
            if (cmb_lig.SelectedIndex == -1)
                 label5.Text = "Lütfen Lig Seçiniz !!!";
            else
            {
                
                int takimSayisi = tcont.takimSayisi(cmb_lig.SelectedItem.ToString());
                if (takimSayisi > 10)
                {
                    var x = tcont.takimID(cmb_lig.SelectedItem.ToString());
                    int[] sID = new int[x.Count];
                    int[] y = new int[x.Count];
                    for (int i = 0; i < x.Count; i++)
                    {// Loop with for.
                        y[i] = x[i];
                        var s = tcont.salonID(y[i]);
                        sID[i] = s[0];
                    }

                    cfix.olustur(takimSayisi, y, cmb_lig.SelectedItem.ToString(), sID);
                }
                else
                    label5.Text = "Seçili Ligde yeterli sayıda takım bulunmamaktadır..!";
            }
        }

        private void MacIslemleri_Load(object sender, EventArgs e)
        {
            gridDoldur();
            
        }

        private void btn_HakemAta_Click(object sender, EventArgs e)
        {
            aRef = new AutoRefree();
            mcont = new MusabakaController(aRef);
            log = new LogWrite(aRef);
            if (cmb_lig.SelectedIndex == -1)
                label5.Text = "Lütfen Lig Seçiniz !!!";
            else
            {
                int takimSayisi = tcont.takimSayisi(cmb_lig.SelectedItem.ToString());
                var x = hcont.bHakemID(cmb_lig.SelectedItem.ToString());
                var yH = hcont.yHakemID(cmb_lig.SelectedItem.ToString());
                if (takimSayisi > 10 && x.Count >= takimSayisi / 2)
                {
                    int[] yhID = new int[yH.Count];
                    int[] y = new int[x.Count];
                    for (int i = 0; i < x.Count; i++)
                    {// Loop with for.
                        y[i] = x[i];
                    }
                    for (int i = 0; i < yH.Count; i++)
                    {// Loop with for.
                        yhID[i] = yH[i];
                    }
                    aRef.hakemAta(takimSayisi, y, yhID);
                }
                else
                    label5.Text = "Seçili lig için yeterli sayıda hakem yada takım bulunmamaktadır..!";
            }
        }

        private void cmb_fixLig_SelectedIndexChanged(object sender, EventArgs e)
        {
           dataGridView1.DataSource = macc.ligMacAra(cmb_fixLig.SelectedItem.ToString());
            if (cmb_fixLig.SelectedItem != null)
            {
                cmb_hafta.DataSource = macc.haftaGetir(cmb_fixLig.SelectedItem.ToString());
                cmb_hafta.DisplayMember = "hafta";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = macc.ligMacAra(textBox1.Text);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            mc.macID = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            mc.salonID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["salonIDDataGridViewComBoxColumn"].Value);
            mc.basHakemID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["basHakemIDDataGridViewComboBoxColumn"].Value);
            mc.yHakemID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["yHakemIDDataGridViewComboBoxColumn"].Value);
            mc.iyHakemID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["iyHakemIDDataGridViewComboBoxColumn"].Value);
            
            macc.macDuzenle(mc);

            logs.LogInfo(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString() + " Güncelleme: " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " ID'li maçın " + dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString() + " Güncellendi.");

        }

        private void cmb_hafta_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = macc.ligMacAra(cmb_hafta.SelectedItem.ToString(),cmb_fixLig.SelectedItem.ToString());
        }
    }
}
