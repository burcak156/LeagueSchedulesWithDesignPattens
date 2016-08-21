namespace DesignPatterns
{
    partial class AnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
            this.sporcu_btn = new System.Windows.Forms.Button();
            this.salon_btn = new System.Windows.Forms.Button();
            this.hakem_btn = new System.Windows.Forms.Button();
            this.btn_mac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sporcu_btn
            // 
            this.sporcu_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sporcu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sporcu_btn.Location = new System.Drawing.Point(37, 33);
            this.sporcu_btn.Name = "sporcu_btn";
            this.sporcu_btn.Size = new System.Drawing.Size(114, 36);
            this.sporcu_btn.TabIndex = 0;
            this.sporcu_btn.Text = "Takım İşlemleri";
            this.sporcu_btn.UseVisualStyleBackColor = true;
            this.sporcu_btn.Click += new System.EventHandler(this.takim_btn_Click);
            // 
            // salon_btn
            // 
            this.salon_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salon_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salon_btn.Location = new System.Drawing.Point(37, 85);
            this.salon_btn.Name = "salon_btn";
            this.salon_btn.Size = new System.Drawing.Size(114, 36);
            this.salon_btn.TabIndex = 2;
            this.salon_btn.Text = "Salon İşlemleri";
            this.salon_btn.UseVisualStyleBackColor = true;
            this.salon_btn.Click += new System.EventHandler(this.salon_btn_Click);
            // 
            // hakem_btn
            // 
            this.hakem_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hakem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hakem_btn.Location = new System.Drawing.Point(37, 142);
            this.hakem_btn.Name = "hakem_btn";
            this.hakem_btn.Size = new System.Drawing.Size(114, 36);
            this.hakem_btn.TabIndex = 3;
            this.hakem_btn.Text = "Hakem İşlemleri";
            this.hakem_btn.UseVisualStyleBackColor = true;
            this.hakem_btn.Click += new System.EventHandler(this.hakem_btn_Click);
            // 
            // btn_mac
            // 
            this.btn_mac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mac.Location = new System.Drawing.Point(37, 194);
            this.btn_mac.Name = "btn_mac";
            this.btn_mac.Size = new System.Drawing.Size(114, 36);
            this.btn_mac.TabIndex = 4;
            this.btn_mac.Text = "Maç İşlemleri";
            this.btn_mac.UseVisualStyleBackColor = true;
            this.btn_mac.Click += new System.EventHandler(this.btn_mac_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(501, 242);
            this.Controls.Add(this.btn_mac);
            this.Controls.Add(this.hakem_btn);
            this.Controls.Add(this.salon_btn);
            this.Controls.Add(this.sporcu_btn);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Name = "AnaMenu";
            this.ShowIcon = false;
            this.Text = "Ana Ekran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sporcu_btn;
        private System.Windows.Forms.Button salon_btn;
        private System.Windows.Forms.Button hakem_btn;
        private System.Windows.Forms.Button btn_mac;
    }
}

