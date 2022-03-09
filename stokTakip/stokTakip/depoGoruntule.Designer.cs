
namespace stokTakip
{
    partial class depoGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depoGoruntule));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SimpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1067, 554);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);

            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // SimpleButton1
            // 
            this.SimpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SimpleButton1.Appearance.Options.UseFont = true;
            this.SimpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton1.ImageOptions.Image")));
            this.SimpleButton1.Location = new System.Drawing.Point(426, 0);
            this.SimpleButton1.Name = "SimpleButton1";
            this.SimpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.SimpleButton1.Size = new System.Drawing.Size(84, 35);
            this.SimpleButton1.TabIndex = 1;
            this.SimpleButton1.Text = "SİL";
            this.SimpleButton1.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.SimpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(535, 0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(124, 35);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "YENİLE";
            this.simpleButton2.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(132, 95);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 22);
            this.txt_id.TabIndex = 3;
            this.txt_id.Visible = false;
            // 
            // depoGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.SimpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txt_id);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "depoGoruntule";
            this.Text = "STOK GÖRÜNTÜLE";
            this.Load += new System.EventHandler(this.depoGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton SimpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox txt_id;
    }
}