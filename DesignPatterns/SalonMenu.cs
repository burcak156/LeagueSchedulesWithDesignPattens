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
    public partial class SalonMenu : Form
    {
        Logger log = Logger.getInstance();
        ComponentConfiguration cc = ComponentConfiguration.getInstance();
        salonlar slnlar;
        SalonController scont;
        public SalonMenu()
        {
            InitializeComponent();
            scont = new SalonController();
            slnlar = new salonlar();
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
            this.bindingSource1.DataSource = this.scont.salonListele();
        }

        private void SalonMenu_Load(object sender, EventArgs e)
        {
            gridDoldur();
            dataGridView1.ReadOnly = true;
            dataGridView1.Refresh();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            slnlar.adi = txt_s_adi.Text.ToString();
            slnlar.sehir = cmb_sehir.Items[cmb_sehir.SelectedIndex].ToString();
            slnlar.ligi = cmb_lig.Items[cmb_lig.SelectedIndex].ToString();
            slnlar.diger = txt_s_diger.Text.ToString();
        
            if (scont.salonVeriEkle(slnlar))
            {
                log.LogInfo(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString() + " Ekleme: Salon " + txt_s_adi.Text.ToString() + " Eklendi.");
                label5.Text = "Başarıyla eklendi !";
                txt_s_adi.Clear();
                txt_s_diger.Clear();
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
                log.LogInfo(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString() + " Silme: Salon " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " Silindi.");
                slnlar.id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                scont.salonSil(slnlar);
                dataGridView1.ReadOnly = true;
                dataGridView1.Refresh();
                gridDoldur();
                btn_edit.Enabled = false;
                btn_tamam.Enabled = true;
            }
            else {
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
            slnlar.id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            slnlar.adi =            dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            slnlar.sehir =          dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            slnlar.ligi =           dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            slnlar.diger =          dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        
            scont.salonDuzenle(slnlar);
        }

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = scont.salonAra(txt_arama.Text.ToString());
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            log.LogInfo(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString() + " Güncelleme: " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dataGridView1.Columns[e.ColumnIndex].Name.ToString() + " Güncellendi.");
        }
    }
}