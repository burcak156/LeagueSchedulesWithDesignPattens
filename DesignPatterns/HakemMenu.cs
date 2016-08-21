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
    public partial class HakemMenu : Form
    {
        hakem hkmler;
        HakemController hcont;
        ComponentConfiguration cc = ComponentConfiguration.getInstance();
        Logger log = Logger.getInstance();
        public HakemMenu()
        {
            InitializeComponent();
            hkmler = new hakem();
            hcont = new HakemController();
            tabControlStyleRun();
            tabPage1styleRun();
            tabPage2styleRun();
        }

        private void tabControlStyleRun()
        {
            foreach (Control c in tabControl1.Controls)
                if (c is TabPage)
                    c.BackColor = Color.FromName(cc.gettabPageStyle("first", "bgcolor"));
        }
        private void tabPage1styleRun()
        {
            foreach (Control c in tabPage1.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromName(cc.getButtonStyle("second", "bgcolor"));
                    c.ForeColor = Color.FromName(cc.getButtonStyle("second", "textcolor"));
                }
                if (c is ComboBox)
                {
                    c.BackColor = Color.FromName(cc.getcomboBoxStyle("first", "bgcolor"));
                    c.ForeColor = Color.FromName(cc.getcomboBoxStyle("first", "fgcolor"));
                }
                if (c is Label)
                    c.ForeColor = Color.FromName(cc.getLabelStyle("first", "textcolor"));
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
                    c.BackColor = Color.FromName(cc.getButtonStyle("second", "bgcolor"));
                    c.ForeColor = Color.FromName(cc.getButtonStyle("second", "textcolor"));
                }
                if (c is ComboBox)
                {
                    c.BackColor = Color.FromName(cc.getcomboBoxStyle("first", "bgcolor"));
                    c.ForeColor = Color.FromName(cc.getcomboBoxStyle("first", "fgcolor"));
                }
                if (c is Label)
                    c.ForeColor = Color.FromName(cc.getLabelStyle("first", "textcolor"));
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
            this.bindingSource1.DataSource = this.hcont.hakemListele();
        }

        private void HakemMenu_Load(object sender, EventArgs e)
        {
            gridDoldur();
            dataGridView1.ReadOnly = true;
            dataGridView1.Refresh();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            hkmler.adi = txt_h_adi.Text.ToString();
            hkmler.soyadi = txt_h_soyadi.Text.ToString();
            hkmler.sehir = cmb_sehir.Items[cmb_sehir.SelectedIndex].ToString();
            hkmler.klasmani = cmb_klasman.Items[cmb_klasman.SelectedIndex].ToString();
            hkmler.gorev = cmb_gorev.Items[cmb_gorev.SelectedIndex].ToString();
            hkmler.diger = txt_h_diger.Text.ToString();

            log.LogInfo(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString() + " Ekleme: Hakem " + txt_h_adi.Text.ToString() +" "+ txt_h_soyadi.Text.ToString() + " Eklendi.");

            if (hcont.hakemVeriEkle(hkmler))
            {
                label5.Text = "Başarıyla eklendi !";
                txt_h_adi.Clear();
                txt_h_soyadi.Clear();
                txt_h_diger.Clear();
            }
            gridDoldur();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns[0].ReadOnly = true;
            btn_edit.Enabled = false;
            btn_sil.Enabled = false;
            btn_tamam.Enabled = true;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Gerçekten silmek istiyormusunuz ?", "Important Question", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                log.LogInfo(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString() + " Silme: Hakem " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString() + " Silindi.");

                hkmler.id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                hcont.hakemSil(hkmler);
                dataGridView1.ReadOnly = true;
                dataGridView1.Refresh();
                gridDoldur();
                btn_edit.Enabled = false;
                btn_tamam.Enabled = true;
            }
            else
            {
                btn_edit.Enabled = true;
                btn_tamam.Enabled = true;
            }
        }

        private void btn_tamam_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            btn_edit.Enabled = true;
            btn_sil.Enabled = true;
            btn_tamam.Enabled = false;
            gridDoldur();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            hkmler.id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            hkmler.adi = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            hkmler.soyadi = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            hkmler.gorev = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            hkmler.sehir = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            hkmler.klasmani = Convert.ToString((dataGridView1.Rows[e.RowIndex].Cells["dgcomboklas"] as DataGridViewComboBoxCell).FormattedValue.ToString());
            hcont.hakemDuzenle(hkmler);
        }

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hcont.hakemAra(txt_arama.Text.ToString());
        }

        private void txt_h_adi_TextChanged(object sender, EventArgs e)
        {
            if(label5.Text != "")
            label5.Text.Remove(0);
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            log.LogInfo(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString() + " Güncelleme: Hakem " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + " "+ dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() +" "+ dataGridView1.Columns[e.ColumnIndex].Name.ToString() + " Güncellendi.");
        }
    }
}
