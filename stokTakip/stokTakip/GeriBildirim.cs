using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace stokTakip
{
    public partial class GeriBildirim : Form
    {
        public GeriBildirim()
        {
            InitializeComponent();
        }
        sqlBaglantisi baglantim = new sqlBaglantisi();
        //listele
        public void listele_talep()
        {
            SqlCommand sorgu = new SqlCommand("select * from StokTalebi", baglantim.baglanti());


            SqlDataAdapter dak = new SqlDataAdapter(sorgu);
            DataTable dtk = new DataTable();
            dak.Fill(dtk);
            gridControl1.DataSource = dtk;
            gridView1.Columns["ID"].Visible = false;

            gridView1.Columns["stokAdi"].Caption = "PARÇA STOK ADI";
            gridView1.Columns["projeAdi"].Caption = "PROJE ADI";
            gridView1.Columns["ihtiyac"].Caption = "İHTİYAÇ";
            gridView1.Columns["talepEden"].Caption = "TALEP EDEN";
            gridView1.Columns["durumu"].Caption = "DURUMU";

            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            listele_talep();
        }
    }


}
