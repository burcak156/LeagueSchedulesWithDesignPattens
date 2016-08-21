namespace DesignPatterns
{
    partial class MacIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmb_lig = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_createFix = new System.Windows.Forms.Button();
            this.btn_HakemAta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmb_fixLig = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_hafta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.macIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.awayIDDataGridViewComBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.haftaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonIDDataGridViewComBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.basHakemIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.yHakemIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iyHakemIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ligAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_lig
            // 
            this.cmb_lig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_lig.FormattingEnabled = true;
            this.cmb_lig.Items.AddRange(new object[] {
            "Türkiye Basketbol Ligi",
            "Türkiye Erkekler Basketbol 2. Ligi",
            "Türkiye Erkekler Basketbol 3. Ligi",
            "Türkiye Kadınlar Basketbol Ligi",
            "Türkiye Kadınlar Basketbol 2. Ligi"});
            this.cmb_lig.Location = new System.Drawing.Point(194, 137);
            this.cmb_lig.Name = "cmb_lig";
            this.cmb_lig.Size = new System.Drawing.Size(224, 21);
            this.cmb_lig.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 253);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btn_createFix);
            this.tabPage1.Controls.Add(this.btn_HakemAta);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmb_lig);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(842, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fikstür ve Hakem Atama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lig :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // btn_createFix
            // 
            this.btn_createFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_createFix.Location = new System.Drawing.Point(578, 6);
            this.btn_createFix.Name = "btn_createFix";
            this.btn_createFix.Size = new System.Drawing.Size(157, 114);
            this.btn_createFix.TabIndex = 10;
            this.btn_createFix.Text = "Maç Fikstürünü Oluştur";
            this.btn_createFix.UseVisualStyleBackColor = true;
            this.btn_createFix.Click += new System.EventHandler(this.btn_createFix_Click);
            // 
            // btn_HakemAta
            // 
            this.btn_HakemAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HakemAta.Location = new System.Drawing.Point(578, 126);
            this.btn_HakemAta.Name = "btn_HakemAta";
            this.btn_HakemAta.Size = new System.Drawing.Size(157, 94);
            this.btn_HakemAta.TabIndex = 9;
            this.btn_HakemAta.Text = "Maçlara Hakemleri Ata";
            this.btn_HakemAta.UseVisualStyleBackColor = true;
            this.btn_HakemAta.Click += new System.EventHandler(this.btn_HakemAta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fikstür oluşturma ve Hakem Ataması İçin Ligi Seçiniz";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmb_fixLig);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmb_hafta);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lig Programları";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmb_fixLig
            // 
            this.cmb_fixLig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fixLig.FormattingEnabled = true;
            this.cmb_fixLig.Items.AddRange(new object[] {
            "Türkiye Basketbol Ligi",
            "Türkiye Erkekler Basketbol 2. Ligi",
            "Türkiye Erkekler Basketbol 3. Ligi",
            "Türkiye Kadınlar Basketbol Ligi",
            "Türkiye Kadınlar Basketbol 2. Ligi"});
            this.cmb_fixLig.Location = new System.Drawing.Point(49, 8);
            this.cmb_fixLig.Name = "cmb_fixLig";
            this.cmb_fixLig.Size = new System.Drawing.Size(146, 21);
            this.cmb_fixLig.TabIndex = 8;
            this.cmb_fixLig.SelectedIndexChanged += new System.EventHandler(this.cmb_fixLig_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Arama :";
            // 
            // cmb_hafta
            // 
            this.cmb_hafta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hafta.FormattingEnabled = true;
            this.cmb_hafta.Items.AddRange(new object[] {
            ""});
            this.cmb_hafta.Location = new System.Drawing.Point(267, 7);
            this.cmb_hafta.Name = "cmb_hafta";
            this.cmb_hafta.Size = new System.Drawing.Size(72, 21);
            this.cmb_hafta.TabIndex = 4;
            this.cmb_hafta.SelectedIndexChanged += new System.EventHandler(this.cmb_hafta_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hafta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lig :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macIDDataGridViewTextBoxColumn,
            this.homeIDDataGridViewComboBoxColumn,
            this.awayIDDataGridViewComBoxColumn,
            this.haftaDataGridViewTextBoxColumn,
            this.salonIDDataGridViewComBoxColumn,
            this.basHakemIDDataGridViewComboBoxColumn,
            this.yHakemIDDataGridViewComboBoxColumn,
            this.iyHakemIDDataGridViewComboBoxColumn,
            this.ligAdiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 187);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // macIDDataGridViewTextBoxColumn
            // 
            this.macIDDataGridViewTextBoxColumn.DataPropertyName = "macID";
            this.macIDDataGridViewTextBoxColumn.HeaderText = "Maç ID";
            this.macIDDataGridViewTextBoxColumn.Name = "macIDDataGridViewTextBoxColumn";
            this.macIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homeIDDataGridViewComboBoxColumn
            // 
            this.homeIDDataGridViewComboBoxColumn.DataPropertyName = "homeID";
            this.homeIDDataGridViewComboBoxColumn.HeaderText = "Ev Sahibi";
            this.homeIDDataGridViewComboBoxColumn.Name = "homeIDDataGridViewComboBoxColumn";
            this.homeIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.homeIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // awayIDDataGridViewComBoxColumn
            // 
            this.awayIDDataGridViewComBoxColumn.DataPropertyName = "awayID";
            this.awayIDDataGridViewComBoxColumn.HeaderText = "Deplasman";
            this.awayIDDataGridViewComBoxColumn.Name = "awayIDDataGridViewComBoxColumn";
            this.awayIDDataGridViewComBoxColumn.ReadOnly = true;
            this.awayIDDataGridViewComBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.awayIDDataGridViewComBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // haftaDataGridViewTextBoxColumn
            // 
            this.haftaDataGridViewTextBoxColumn.DataPropertyName = "hafta";
            this.haftaDataGridViewTextBoxColumn.HeaderText = "Hafta";
            this.haftaDataGridViewTextBoxColumn.Name = "haftaDataGridViewTextBoxColumn";
            this.haftaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salonIDDataGridViewComBoxColumn
            // 
            this.salonIDDataGridViewComBoxColumn.DataPropertyName = "salonID";
            this.salonIDDataGridViewComBoxColumn.HeaderText = "Salon Adı";
            this.salonIDDataGridViewComBoxColumn.Name = "salonIDDataGridViewComBoxColumn";
            this.salonIDDataGridViewComBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.salonIDDataGridViewComBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // basHakemIDDataGridViewComboBoxColumn
            // 
            this.basHakemIDDataGridViewComboBoxColumn.DataPropertyName = "basHakemID";
            this.basHakemIDDataGridViewComboBoxColumn.HeaderText = "Baş Hakem";
            this.basHakemIDDataGridViewComboBoxColumn.Name = "basHakemIDDataGridViewComboBoxColumn";
            this.basHakemIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.basHakemIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // yHakemIDDataGridViewComboBoxColumn
            // 
            this.yHakemIDDataGridViewComboBoxColumn.DataPropertyName = "yHakemID";
            this.yHakemIDDataGridViewComboBoxColumn.HeaderText = "Yan Hakem";
            this.yHakemIDDataGridViewComboBoxColumn.Name = "yHakemIDDataGridViewComboBoxColumn";
            this.yHakemIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.yHakemIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // iyHakemIDDataGridViewComboBoxColumn
            // 
            this.iyHakemIDDataGridViewComboBoxColumn.DataPropertyName = "iyHakemID";
            this.iyHakemIDDataGridViewComboBoxColumn.HeaderText = "Yan Hakem";
            this.iyHakemIDDataGridViewComboBoxColumn.Name = "iyHakemIDDataGridViewComboBoxColumn";
            this.iyHakemIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iyHakemIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ligAdiDataGridViewTextBoxColumn
            // 
            this.ligAdiDataGridViewTextBoxColumn.DataPropertyName = "ligAdi";
            this.ligAdiDataGridViewTextBoxColumn.HeaderText = "Lig";
            this.ligAdiDataGridViewTextBoxColumn.Name = "ligAdiDataGridViewTextBoxColumn";
            this.ligAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DesignPatterns.maclar);
            // 
            // MacIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 277);
            this.Controls.Add(this.tabControl1);
            this.Name = "MacIslemleri";
            this.Text = "MacIslemleri";
            this.Load += new System.EventHandler(this.MacIslemleri_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_lig;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_hafta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_HakemAta;
        private System.Windows.Forms.ComboBox cmb_fixLig;
        private System.Windows.Forms.Button btn_createFix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn macIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn homeIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn awayIDDataGridViewComBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haftaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn salonIDDataGridViewComBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn basHakemIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn yHakemIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iyHakemIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ligAdiDataGridViewTextBoxColumn;
    }
}