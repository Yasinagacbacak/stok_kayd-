namespace stokTakip
{
    partial class EKLE_CIKART
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EKLE_CIKART));
            this.lbl_stokadi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ihtiyac = new System.Windows.Forms.TextBox();
            this.lbl_birim = new System.Windows.Forms.Label();
            this.lbl_mevcut = new System.Windows.Forms.Label();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_projeadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_talepeden = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_stokadi
            // 
            this.lbl_stokadi.AutoSize = true;
            this.lbl_stokadi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stokadi.Location = new System.Drawing.Point(45, 53);
            this.lbl_stokadi.Name = "lbl_stokadi";
            this.lbl_stokadi.Size = new System.Drawing.Size(173, 23);
            this.lbl_stokadi.TabIndex = 0;
            this.lbl_stokadi.Text = "PARÇA STOK ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(83, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "İHTİYAÇ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(74, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "MEVCUT";
            // 
            // txt_ihtiyac
            // 
            this.txt_ihtiyac.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ihtiyac.Location = new System.Drawing.Point(186, 237);
            this.txt_ihtiyac.Name = "txt_ihtiyac";
            this.txt_ihtiyac.Size = new System.Drawing.Size(153, 30);
            this.txt_ihtiyac.TabIndex = 4;
            this.txt_ihtiyac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ihtiyac_KeyPress);
            // 
            // lbl_birim
            // 
            this.lbl_birim.AutoSize = true;
            this.lbl_birim.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_birim.Location = new System.Drawing.Point(371, 225);
            this.lbl_birim.Name = "lbl_birim";
            this.lbl_birim.Size = new System.Drawing.Size(51, 18);
            this.lbl_birim.TabIndex = 7;
            this.lbl_birim.Text = "BİRİM";
            // 
            // lbl_mevcut
            // 
            this.lbl_mevcut.AutoSize = true;
            this.lbl_mevcut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mevcut.Location = new System.Drawing.Point(197, 152);
            this.lbl_mevcut.Name = "lbl_mevcut";
            this.lbl_mevcut.Size = new System.Drawing.Size(21, 24);
            this.lbl_mevcut.TabIndex = 13;
            this.lbl_mevcut.Text = "0";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_guncelle.Appearance.Options.UseFont = true;
            this.btn_guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.ImageOptions.Image")));
            this.btn_guncelle.Location = new System.Drawing.Point(87, 369);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(233, 29);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "TALEP OLUŞTUR";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "PROJE ADI";
            // 
            // txt_projeadi
            // 
            this.txt_projeadi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_projeadi.Location = new System.Drawing.Point(186, 278);
            this.txt_projeadi.Name = "txt_projeadi";
            this.txt_projeadi.Size = new System.Drawing.Size(153, 30);
            this.txt_projeadi.TabIndex = 15;
            this.txt_projeadi.TextChanged += new System.EventHandler(this.txt_projeadi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(100, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "TARİH";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 322);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 30);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(35, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "TALEP EDEN";
            // 
            // lbl_talepeden
            // 
            this.lbl_talepeden.AutoSize = true;
            this.lbl_talepeden.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_talepeden.Location = new System.Drawing.Point(186, 200);
            this.lbl_talepeden.Name = "lbl_talepeden";
            this.lbl_talepeden.Size = new System.Drawing.Size(52, 23);
            this.lbl_talepeden.TabIndex = 19;
            this.lbl_talepeden.Text = "------";
            // 
            // EKLE_CIKART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(443, 499);
            this.Controls.Add(this.lbl_talepeden);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_projeadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_mevcut);
            this.Controls.Add(this.lbl_birim);
            this.Controls.Add(this.txt_ihtiyac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_stokadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "EKLE_CIKART";
            this.Text = "MALZEME_TALEBİ";
            this.Load += new System.EventHandler(this.EKLE_CIKART_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EKLE_CIKART_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_stokadi;
        public System.Windows.Forms.TextBox txt_ihtiyac;
        public System.Windows.Forms.Label lbl_birim;
        private System.Windows.Forms.Label lbl_mevcut;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_projeadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_talepeden;
    }
}