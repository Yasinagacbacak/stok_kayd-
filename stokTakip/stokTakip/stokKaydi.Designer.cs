
namespace stokTakip
{
    partial class stokKaydi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokKaydi));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_altgrup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_proses = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_malzeme = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_grup = new System.Windows.Forms.ComboBox();
            this.txt_uzunluk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ihtiyac = new System.Windows.Forms.TextBox();
            this.txt_stokAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.cb_birim = new System.Windows.Forms.ComboBox();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_tedarikci = new System.Windows.Forms.ComboBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_seriNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.ImageOptions.Image = global::stokTakip.Properties.Resources.add_32x32;
            this.btn_kaydet.Location = new System.Drawing.Point(503, 114);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_kaydet.Size = new System.Drawing.Size(178, 59);
            this.btn_kaydet.TabIndex = 0;
            this.btn_kaydet.Text = "STOK OLUŞTUR";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALT GRUP";
            // 
            // cb_altgrup
            // 
            this.cb_altgrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_altgrup.FormattingEnabled = true;
            this.cb_altgrup.Location = new System.Drawing.Point(163, 175);
            this.cb_altgrup.Margin = new System.Windows.Forms.Padding(4);
            this.cb_altgrup.Name = "cb_altgrup";
            this.cb_altgrup.Size = new System.Drawing.Size(244, 24);
            this.cb_altgrup.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PROSES GRUBU";
            // 
            // cb_proses
            // 
            this.cb_proses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_proses.FormattingEnabled = true;
            this.cb_proses.Location = new System.Drawing.Point(163, 89);
            this.cb_proses.Margin = new System.Windows.Forms.Padding(4);
            this.cb_proses.Name = "cb_proses";
            this.cb_proses.Size = new System.Drawing.Size(244, 24);
            this.cb_proses.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "MALZEME CİNSİ";
            // 
            // cb_malzeme
            // 
            this.cb_malzeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_malzeme.FormattingEnabled = true;
            this.cb_malzeme.Location = new System.Drawing.Point(165, 220);
            this.cb_malzeme.Margin = new System.Windows.Forms.Padding(4);
            this.cb_malzeme.Name = "cb_malzeme";
            this.cb_malzeme.Size = new System.Drawing.Size(244, 24);
            this.cb_malzeme.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "GRUP";
            // 
            // cb_grup
            // 
            this.cb_grup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_grup.FormattingEnabled = true;
            this.cb_grup.Location = new System.Drawing.Point(163, 133);
            this.cb_grup.Margin = new System.Windows.Forms.Padding(4);
            this.cb_grup.Name = "cb_grup";
            this.cb_grup.Size = new System.Drawing.Size(244, 24);
            this.cb_grup.TabIndex = 2;
            // 
            // txt_uzunluk
            // 
            this.txt_uzunluk.Location = new System.Drawing.Point(165, 383);
            this.txt_uzunluk.Margin = new System.Windows.Forms.Padding(4);
            this.txt_uzunluk.Name = "txt_uzunluk";
            this.txt_uzunluk.Size = new System.Drawing.Size(244, 22);
            this.txt_uzunluk.TabIndex = 3;
            this.txt_uzunluk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "UZUNLUK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 426);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "MİKTAR";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(165, 426);
            this.txt_miktar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(244, 22);
            this.txt_miktar.TabIndex = 3;
            this.txt_miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 471);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "İHTİYAÇ";
            // 
            // txt_ihtiyac
            // 
            this.txt_ihtiyac.Location = new System.Drawing.Point(165, 471);
            this.txt_ihtiyac.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ihtiyac.Name = "txt_ihtiyac";
            this.txt_ihtiyac.Size = new System.Drawing.Size(244, 22);
            this.txt_ihtiyac.TabIndex = 3;
            this.txt_ihtiyac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txt_stokAdi
            // 
            this.txt_stokAdi.Location = new System.Drawing.Point(165, 301);
            this.txt_stokAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stokAdi.Name = "txt_stokAdi";
            this.txt_stokAdi.Size = new System.Drawing.Size(244, 22);
            this.txt_stokAdi.TabIndex = 6;
            this.txt_stokAdi.TextChanged += new System.EventHandler(this.txt_stokAdi_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 301);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "PARÇA STOK ADI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 517);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "TEDARİKÇİ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "TARİH";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(503, 180);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.ShowToolTips = false;
            this.simpleButton2.Size = new System.Drawing.Size(148, 39);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "TEMİZLE";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(503, 240);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(124, 29);
            this.simpleButton3.TabIndex = 13;
            this.simpleButton3.Text = "GÜNCELLE";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // cb_birim
            // 
            this.cb_birim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_birim.FormattingEnabled = true;
            this.cb_birim.Items.AddRange(new object[] {
            "ADET",
            "METRE",
            "KİLO",
            "LİTRE"});
            this.cb_birim.Location = new System.Drawing.Point(416, 426);
            this.cb_birim.Name = "cb_birim";
            this.cb_birim.Size = new System.Drawing.Size(121, 24);
            this.cb_birim.TabIndex = 14;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1246, 671);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1246, 671);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(705, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(411, 707);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format0";
            gridFormatRule2.Rule = null;
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 578);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(503, 289);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(124, 29);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "SİL";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // cmb_tedarikci
            // 
            this.cmb_tedarikci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tedarikci.FormattingEnabled = true;
            this.cmb_tedarikci.Location = new System.Drawing.Point(166, 517);
            this.cmb_tedarikci.Name = "cmb_tedarikci";
            this.cmb_tedarikci.Size = new System.Drawing.Size(242, 24);
            this.cmb_tedarikci.TabIndex = 18;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Arial", 8F);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(572, 12);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton4.Size = new System.Drawing.Size(127, 43);
            this.simpleButton4.TabIndex = 52;
            this.simpleButton4.Text = "AKTAR";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(162, 261);
            this.txt_marka.Margin = new System.Windows.Forms.Padding(4);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(244, 22);
            this.txt_marka.TabIndex = 54;
            this.txt_marka.TextChanged += new System.EventHandler(this.txt_marka_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 261);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 53;
            this.label11.Text = "MARKA";
            // 
            // txt_seriNo
            // 
            this.txt_seriNo.Location = new System.Drawing.Point(165, 341);
            this.txt_seriNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_seriNo.Name = "txt_seriNo";
            this.txt_seriNo.Size = new System.Drawing.Size(244, 22);
            this.txt_seriNo.TabIndex = 56;
            this.txt_seriNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_seriNo_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 341);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 55;
            this.label12.Text = "SERİ NUMARASI";
            // 
            // stokKaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 701);
            this.Controls.Add(this.txt_seriNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_marka);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.cmb_tedarikci);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cb_birim);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_stokAdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ihtiyac);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.txt_uzunluk);
            this.Controls.Add(this.cb_grup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_malzeme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_proses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_altgrup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kaydet);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "stokKaydi";
            this.Text = "STOK KAYIT";
            this.Load += new System.EventHandler(this.stokKaydi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_altgrup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_proses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_malzeme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_grup;
        private System.Windows.Forms.TextBox txt_uzunluk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ihtiyac;
        private System.Windows.Forms.TextBox txt_stokAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.ComboBox cb_birim;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cmb_tedarikci;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.TextBox txt_marka;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_seriNo;
        private System.Windows.Forms.Label label12;
    }
}

