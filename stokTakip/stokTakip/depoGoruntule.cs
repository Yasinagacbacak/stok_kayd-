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
    public partial class depoGoruntule : Form
    {
        public depoGoruntule()
        {
            InitializeComponent();
        }
        sqlBaglantisi baglantim = new sqlBaglantisi();

        public void listele_Kisi()
        {
            SqlCommand sorgu = new SqlCommand("select * from StokKartı", baglantim.baglanti());
            // sorgu_Kisi.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dak = new SqlDataAdapter(sorgu);
            DataTable dtk = new DataTable();
            dak.Fill(dtk);
            gridControl1.DataSource = dtk;
            gridView1.Columns["ID"].Visible = false;

            gridView1.Columns["ProsesGrubu"].Caption = "PROSES GRUBU";
            gridView1.Columns["GrupAdı"].Caption = "GRUP ADI";
            gridView1.Columns["AltGrupAdı"].Caption = "ALT GRUP ADI";
            gridView1.Columns["ParçaStokAdı"].Caption = "PARÇA STOK ADI";
            gridView1.Columns["MalzemeCinsi"].Caption = "MALZEME CİNSİ";
            gridView1.Columns["Uzunluk"].Caption = "UZUNLUK";
            gridView1.Columns["Miktar"].Caption = "MİKTAR";
            gridView1.Columns["İhtiyaç"].Caption = "İHTİYAÇ";
            gridView1.Columns["Tedarikçi"].Caption = "TEDARİKÇİ";
            gridView1.Columns["Tarih"].Caption = "TARİH";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;


        }

        private void depoGoruntule_Load(object sender, EventArgs e)
        {
            listele_Kisi();
        }
    }
}
