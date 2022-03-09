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
            SqlCommand sorgu = new SqlCommand("select * from tbl_stokKarti", baglantim.baglanti());
            // sorgu_Kisi.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dak = new SqlDataAdapter(sorgu);
            DataTable dtk = new DataTable();
            dak.Fill(dtk);
            gridControl1.DataSource = dtk;
            gridView1.Columns["id"].Visible = false;

            gridView1.Columns["prosesGrubu"].Caption = "PROSES GRUBU";
            gridView1.Columns["grupAdi"].Caption = "GRUP ADI";
            gridView1.Columns["altGrupAdi"].Caption = "ALT GRUP ADI";
            gridView1.Columns["parcaStokAdi"].Caption = "PARÇA STOK ADI";
            gridView1.Columns["malzemeCinsi"].Caption = "MALZEME CİNSİ";
            gridView1.Columns["uzunluk"].Caption = "UZUNLUK";
            gridView1.Columns["miktar"].Caption = "MİKTAR";
            gridView1.Columns["ihtiyac"].Caption = "İHTİYAÇ";
            gridView1.Columns["tedarikci"].Caption = "TEDARİKÇİ";
            gridView1.Columns["tarih"].Caption = "TARİH";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;


        }

        private void depoGoruntule_Load(object sender, EventArgs e)
        {
            listele_Kisi();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            listele_Kisi();
        }
        //VERİ TABANINDAN MAUSE İLE SEÇİLEN SATIRI SİLER id ye göre
        int id = 0;
        private void SimpleButton1_Click(object sender, EventArgs e)
        {


            bool kayit_arama_durumu = false;
           
            SqlCommand secmeSorgusu = new SqlCommand("Select *from tbl_stokKarti where id='" + txt_id.Text + "'", baglantim.baglanti());
            SqlDataReader kayitokuma = secmeSorgusu.ExecuteReader();
            while (kayitokuma.Read())
            {

   
                kayit_arama_durumu = true;
                SqlCommand silsorgusu = new SqlCommand("delete from tbl_stokKarti where id='" + txt_id.Text + "'", baglantim.baglanti());

                silsorgusu.ExecuteNonQuery();
                MessageBox.Show("Stok kaydı başarılı bir şekilde silinmiştir.", "STOK KONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                baglantim.baglanti().Close();
                txt_id.Text = "";

                listele_Kisi();
                break;
            }

        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("id").ToString();
        }
    }
}

