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
    public partial class TakimMenu : Form
    {
        Logger log = Logger.getInstance();
        ComponentConfiguration cc = ComponentConfiguration.getInstance();
        TakimController cont;
        SalonController scont;
        takimlar tkmlar;

        public TakimMenu()
        {
            cont = new TakimController();
            scont = new SalonController();
            tkmlar = new takimlar();
            InitializeComponent();
            tabControlStyleRun();
            tabPage1styleRun();
            tabPage2styleRun();
        }

        private void tabControlStyleRun()
        {
            foreach (Control c in tabControl1.Controls)
                if (c is TabPage)
                    c.BackColor = Color.FromName(cc.gettabPageStyle("second", "bgcolor"));
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
        public void gridDoldur()
        {
            this.bindingSource1.DataSource = this.cont.takimListele();

            dgcombosalon.DataSource = scont.salonListele();
            dgcombosalon.ValueMember = "id";
            dgcombosalon.DisplayMember = "adi";

        }

        private void TakimMenu_Load(object sender, EventArgs e)
        {
            gridDoldur();
            
            cmb_salon.DataSource = scont.salonListele();
            cmb_salon.DisplayMember = "adi";
            cmb_salon.ValueMember = "id";
            
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            tkmlar.adi = txt_adi.Text.ToString();
            tkmlar.lig = cmb_lig.Items[cmb_lig.SelectedIndex].ToString();
            tkmlar.diger = txt_sdiger.Text.ToString();
            tkmlar.sehir = cmb_sehir.Items[cmb_sehir.SelectedIndex].ToString();
            tkmlar.salonID = Int32.Parse(cmb_salon.SelectedValue.ToString());

            if (cont.takimVeriEkle(tkmlar))
            {
                log.LogInfo(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString() + " Ekleme: Takım " + txt_adi.Text.ToString() + " Eklendi.");
                label6.Text = "Başarıyla eklendi !";
            }
            gridDoldur();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns[0].ReadOnly = true;
            btn_edit.Enabled = false;
            btn_sil.Enabled = false;
            btn_ok.Enabled = true;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
                DialogResult result1 = MessageBox.Show("Gerçekten silmek istiyormusunuz ?", "Important Question", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                log.LogInfo(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString() + " Silme: Takım " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " Silindi.");
                tkmlar.id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cont.takimSil(tkmlar);
                dataGridView1.ReadOnly = true;
                dataGridView1.Refresh();
                gridDoldur();
                btn_edit.Enabled = false;
                    btn_ok.Enabled = true;
                }
                else {
                    btn_edit.Enabled = true;
                    btn_ok.Enabled = true;
                }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            btn_edit.Enabled = true;
            btn_sil.Enabled = true;
            btn_ok.Enabled = false;
            gridDoldur();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
         
            tkmlar.id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tkmlar.adi = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tkmlar.sehir = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tkmlar.lig = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tkmlar.diger = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tkmlar.salonID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["dgcombosalon"].Value);


            cont.takimDuzenle(tkmlar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cont.takimAra(textBox1.Text.ToString());
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            log.LogInfo(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString() + " Güncelleme: " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString() + " Güncellendi.");
        }
    }
}