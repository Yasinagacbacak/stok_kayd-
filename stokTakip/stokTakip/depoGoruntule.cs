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
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace stokTakip
{
    public partial class depoGoruntule : Form
    {
        public depoGoruntule()
        {
            InitializeComponent();
        }
        sqlBaglantisi baglantim = new sqlBaglantisi();
        public string marka;
        public string stokadi;
        public string birim;
        public int miktar;
        

        //listele
        public void listele_Kisi()
        {
            SqlCommand sorgu = new SqlCommand("select * from tbl_stokKarti", baglantim.baglanti());
          

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
            gridView1.Columns["birim"].Caption = "BİRİM";
            gridView1.Columns["tedarikci"].Caption = "TEDARİKÇİ";
            gridView1.Columns["tarih"].Caption = "TARİH";
            gridView1.Columns["seriNo"].Caption = "SERİ NO";
            gridView1.Columns["marka"].Caption = "MARKA";
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


        //        gridview i BOYAR

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

            GridView view = sender as GridView;
            int MİKTAR = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "miktar"));
            int İHTİYAC = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "ihtiyac"));
            if (MİKTAR >= İHTİYAC)
            {

                e.Appearance.BackColor = Color.LightGreen;
            }
            else
            {
                e.Appearance.BackColor = Color.Red;
            }
        }
        //EXCEL , WORD , PDF ŞEKLİNDE İNDİRME YAPAN BUTON
        private void export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|.xls|Excel (2010) (.xlsx)|.xlsx |RichText File (.rtf)|.rtf |Pdf File (.pdf)|.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControl1.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl1.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl1.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl1.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl1.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl1.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "Dosya açılamadı." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "Dosya kaydedilemedi." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            
        

            EKLE_CIKART yeni = new EKLE_CIKART();
            yeni.s = gridView1.GetFocusedRowCellValue("parcaStokAdi").ToString();
            yeni.b = gridView1.GetFocusedRowCellValue("birim").ToString();
           yeni.m = int.Parse(gridView1.GetFocusedRowCellValue("miktar").ToString());
            yeni.mrk = gridView1.GetFocusedRowCellValue("marka").ToString();
            yeni.Show();

            
   
        }

        private void depoGoruntule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                simpleButton2.PerformClick();
            }
        }
    }
}

