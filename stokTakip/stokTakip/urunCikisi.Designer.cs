namespace stokTakip
{
    partial class urunCikisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunCikisi));
            this.cmb_tur = new System.Windows.Forms.ComboBox();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_teslimAlan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_stokAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_birim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_projeNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_kırıldı_bozuldu = new System.Windows.Forms.RadioButton();
            this.rb_is_gormedi = new System.Windows.Forms.RadioButton();
            this.rb_yanlıs_malzeme = new System.Windows.Forms.RadioButton();
            this.rb_servis = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_bosisteme = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_istemebos = new System.Windows.Forms.RadioButton();
            this.rb_eksik = new System.Windows.Forms.RadioButton();
            this.rb_sarf = new System.Windows.Forms.RadioButton();
            this.txt_acıklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_tur
            // 
            this.cmb_tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tur.FormattingEnabled = true;
            this.cmb_tur.Items.AddRange(new object[] {
            "ADET",
            "METRE",
            "KİLO",
            "LİTRE"});
            this.cmb_tur.Location = new System.Drawing.Point(448, 174);
            this.cmb_tur.Name = "cmb_tur";
            this.cmb_tur.Size = new System.Drawing.Size(121, 24);
            this.cmb_tur.TabIndex = 17;
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(197, 174);
            this.txt_miktar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(244, 22);
            this.txt_miktar.TabIndex = 16;
            this.txt_miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_miktar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "MİKTAR";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 300);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 305);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "TARİH";
            // 
            // txt_teslimAlan
            // 
            this.txt_teslimAlan.Location = new System.Drawing.Point(197, 258);
            this.txt_teslimAlan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_teslimAlan.Name = "txt_teslimAlan";
            this.txt_teslimAlan.Size = new System.Drawing.Size(244, 22);
            this.txt_teslimAlan.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "TESLİM ALAN";
            // 
            // txt_stokAdi
            // 
            this.txt_stokAdi.Location = new System.Drawing.Point(197, 132);
            this.txt_stokAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stokAdi.Name = "txt_stokAdi";
            this.txt_stokAdi.Size = new System.Drawing.Size(244, 22);
            this.txt_stokAdi.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "PARÇA STOK ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "BİRİM";
            // 
            // cmb_birim
            // 
            this.cmb_birim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_birim.FormattingEnabled = true;
            this.cmb_birim.Items.AddRange(new object[] {
            "TASARIM",
            "ÖN İMALAT",
            "İMALAT",
            "KAYNAK",
            "YÜKSEK TEKNOLOJİ",
            "MUTFAK",
            "GENEL",
            "MUHASEBE",
            "MALİYET",
            "PROJE",
            "ARGE",
            "ELEKTRİK",
            "OTOMASYON",
            "İNSAN KAYNAKLARI",
            "BEKÇİ",
            "TEMİZLİK",
            "DEPO",
            "SATIŞ/PAZARLAMA",
            "TEDARİK",
            "KALİTE KONTROL",
            "EKİPMAN MONTAJ",
            "HAT MONTAJ"});
            this.cmb_birim.Location = new System.Drawing.Point(197, 215);
            this.cmb_birim.Name = "cmb_birim";
            this.cmb_birim.Size = new System.Drawing.Size(244, 24);
            this.cmb_birim.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(224, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "MALZEME ÇIKIŞ";
            // 
            // txt_projeNo
            // 
            this.txt_projeNo.Location = new System.Drawing.Point(197, 94);
            this.txt_projeNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_projeNo.Name = "txt_projeNo";
            this.txt_projeNo.Size = new System.Drawing.Size(244, 22);
            this.txt_projeNo.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "PROJE NO";
            // 
            // rb_kırıldı_bozuldu
            // 
            this.rb_kırıldı_bozuldu.AutoSize = true;
            this.rb_kırıldı_bozuldu.Location = new System.Drawing.Point(40, 35);
            this.rb_kırıldı_bozuldu.Name = "rb_kırıldı_bozuldu";
            this.rb_kırıldı_bozuldu.Size = new System.Drawing.Size(265, 22);
            this.rb_kırıldı_bozuldu.TabIndex = 31;
            this.rb_kırıldı_bozuldu.TabStop = true;
            this.rb_kırıldı_bozuldu.Text = "Üretim esnasında kırıldı - bozuldu";
            this.rb_kırıldı_bozuldu.UseVisualStyleBackColor = true;
            // 
            // rb_is_gormedi
            // 
            this.rb_is_gormedi.AutoSize = true;
            this.rb_is_gormedi.Location = new System.Drawing.Point(40, 73);
            this.rb_is_gormedi.Name = "rb_is_gormedi";
            this.rb_is_gormedi.Size = new System.Drawing.Size(172, 22);
            this.rb_is_gormedi.TabIndex = 32;
            this.rb_is_gormedi.TabStop = true;
            this.rb_is_gormedi.Text = "Üretimde iş görmedi";
            this.rb_is_gormedi.UseVisualStyleBackColor = true;
            // 
            // rb_yanlıs_malzeme
            // 
            this.rb_yanlıs_malzeme.AutoSize = true;
            this.rb_yanlıs_malzeme.Location = new System.Drawing.Point(40, 155);
            this.rb_yanlıs_malzeme.Name = "rb_yanlıs_malzeme";
            this.rb_yanlıs_malzeme.Size = new System.Drawing.Size(244, 22);
            this.rb_yanlıs_malzeme.TabIndex = 33;
            this.rb_yanlıs_malzeme.TabStop = true;
            this.rb_yanlıs_malzeme.Text = "Üretime yanlış malzeme verildi";
            this.rb_yanlıs_malzeme.UseVisualStyleBackColor = true;
            // 
            // rb_servis
            // 
            this.rb_servis.AutoSize = true;
            this.rb_servis.Location = new System.Drawing.Point(40, 113);
            this.rb_servis.Name = "rb_servis";
            this.rb_servis.Size = new System.Drawing.Size(156, 22);
            this.rb_servis.TabIndex = 34;
            this.rb_servis.TabStop = true;
            this.rb_servis.Text = "Servis için istendi";
            this.rb_servis.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_bosisteme);
            this.groupBox1.Controls.Add(this.rb_kırıldı_bozuldu);
            this.groupBox1.Controls.Add(this.rb_servis);
            this.groupBox1.Controls.Add(this.rb_is_gormedi);
            this.groupBox1.Controls.Add(this.rb_yanlıs_malzeme);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(584, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 235);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESKİSİ İSTENİCEK";
            // 
            // rb_bosisteme
            // 
            this.rb_bosisteme.AutoSize = true;
            this.rb_bosisteme.Location = new System.Drawing.Point(40, 207);
            this.rb_bosisteme.Name = "rb_bosisteme";
            this.rb_bosisteme.Size = new System.Drawing.Size(163, 22);
            this.rb_bosisteme.TabIndex = 35;
            this.rb_bosisteme.TabStop = true;
            this.rb_bosisteme.Text = "İşlem Yapılmayacak";
            this.rb_bosisteme.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_istemebos);
            this.groupBox2.Controls.Add(this.rb_eksik);
            this.groupBox2.Controls.Add(this.rb_sarf);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(592, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 151);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İSTENMEYECEK";
            // 
            // rb_istemebos
            // 
            this.rb_istemebos.AutoSize = true;
            this.rb_istemebos.Location = new System.Drawing.Point(40, 121);
            this.rb_istemebos.Name = "rb_istemebos";
            this.rb_istemebos.Size = new System.Drawing.Size(180, 22);
            this.rb_istemebos.TabIndex = 46;
            this.rb_istemebos.TabStop = true;
            this.rb_istemebos.Text = "boş bırakmak için seç";
            this.rb_istemebos.UseVisualStyleBackColor = true;
            // 
            // rb_eksik
            // 
            this.rb_eksik.AutoSize = true;
            this.rb_eksik.Location = new System.Drawing.Point(40, 44);
            this.rb_eksik.Name = "rb_eksik";
            this.rb_eksik.Size = new System.Drawing.Size(175, 22);
            this.rb_eksik.TabIndex = 31;
            this.rb_eksik.TabStop = true;
            this.rb_eksik.Text = "Üretime eksik verildi";
            this.rb_eksik.UseVisualStyleBackColor = true;
            // 
            // rb_sarf
            // 
            this.rb_sarf.AutoSize = true;
            this.rb_sarf.Location = new System.Drawing.Point(41, 72);
            this.rb_sarf.Name = "rb_sarf";
            this.rb_sarf.Size = new System.Drawing.Size(147, 22);
            this.rb_sarf.TabIndex = 32;
            this.rb_sarf.TabStop = true;
            this.rb_sarf.Text = "Sarf malzemeleri";
            this.rb_sarf.UseVisualStyleBackColor = true;
            // 
            // txt_acıklama
            // 
            this.txt_acıklama.Location = new System.Drawing.Point(197, 342);
            this.txt_acıklama.Margin = new System.Windows.Forms.Padding(4);
            this.txt_acıklama.Multiline = true;
            this.txt_acıklama.Name = "txt_acıklama";
            this.txt_acıklama.Size = new System.Drawing.Size(244, 117);
            this.txt_acıklama.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "AÇIKLAMA";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(338, 494);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton4.ShowToolTips = false;
            this.simpleButton4.Size = new System.Drawing.Size(118, 39);
            this.simpleButton4.TabIndex = 41;
            this.simpleButton4.Text = "TEMİZLE";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.ImageOptions.Image = global::stokTakip.Properties.Resources.add_32x32;
            this.btn_kaydet.Location = new System.Drawing.Point(197, 484);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_kaydet.Size = new System.Drawing.Size(127, 59);
            this.btn_kaydet.TabIndex = 40;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(913, -5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1066, 697);
            this.gridControl1.TabIndex = 42;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(611, 494);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(124, 29);
            this.simpleButton1.TabIndex = 44;
            this.simpleButton1.Text = "SİL";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(481, 494);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(124, 29);
            this.simpleButton3.TabIndex = 43;
            this.simpleButton3.Text = "GÜNCELLE";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 584);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 45;
            this.textBox1.Visible = false;
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1501, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 689);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1501, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 689);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1501, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 689);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Word Dosyaları(*.docx)";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Tag = "Word Dosyaları(*.docx)|*.docx";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Excel Dosyaları(*.xlsx)";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.Tag = "Excel Dosyaları(*.xlsx)|*.xlsx";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Pdf Dosyaları(*.pdf)";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.Tag = "Pdf Dosyaları(*.pdf)|*.pdf";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Arial", 8F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(780, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(127, 43);
            this.simpleButton2.TabIndex = 51;
            this.simpleButton2.Text = "AKTAR";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // urunCikisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1501, 689);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_acıklama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_projeNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_birim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_stokAdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_teslimAlan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_tur);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "urunCikisi";
            this.Text = "urunCikisi";
            this.Load += new System.EventHandler(this.urunCikisi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_tur;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_teslimAlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_stokAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_birim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_projeNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_kırıldı_bozuldu;
        private System.Windows.Forms.RadioButton rb_is_gormedi;
        private System.Windows.Forms.RadioButton rb_yanlıs_malzeme;
        private System.Windows.Forms.RadioButton rb_servis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_eksik;
        private System.Windows.Forms.RadioButton rb_sarf;
        private System.Windows.Forms.TextBox txt_acıklama;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rb_bosisteme;
        private System.Windows.Forms.RadioButton rb_istemebos;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}