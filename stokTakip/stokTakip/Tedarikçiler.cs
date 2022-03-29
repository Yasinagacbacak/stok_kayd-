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
    public partial class Tedarikçiler : Form
    {
        public Tedarikçiler()
        {
            InitializeComponent();
        }
        sqlBaglantisi baglantım = new sqlBaglantisi();



        //kaydet
        public void kaydet()
        {
            if (txt_firmaAdi.Text != "" && txt_firmaYetkilisi.Text != "")
            {
                SqlCommand kaydet = new SqlCommand("insert into tedarikciBilgileri(firmaAdi,sektor,firmaYetkilisi,telefonNumarası," +
                  "adresi) values (@firmaAdi,@sektor,@firmaYetkilisi,@telefonNumarası," +
                  "@adresi)", baglantım.baglanti());
                kaydet.Parameters.Add("@firmaAdi", SqlDbType.NVarChar, 50).Value = txt_firmaAdi.Text;
                kaydet.Parameters.Add("@sektor", SqlDbType.NVarChar, 30).Value = txt_sektor.Text;
                kaydet.Parameters.Add("@firmaYetkilisi", SqlDbType.NVarChar, 30).Value = txt_firmaYetkilisi.Text;
                kaydet.Parameters.Add("@telefonNumarası", SqlDbType.NVarChar, 15).Value = txt_telNo.Text;
                kaydet.Parameters.Add("@adresi", SqlDbType.NVarChar, 150).Value = txt_adres.Text;

                try
                {
                    kaydet.ExecuteNonQuery();
                    MessageBox.Show("KAYDEDİLDİ");
                }
                catch (Exception)
                {
                    MessageBox.Show("sdsad");
                    throw;
                }
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen boşlukları doldurunuz !");
            }


        }
        public void temizle()
        {
            txt_adres.Clear();
            txt_firmaAdi.Clear();
            txt_firmaYetkilisi.Clear();
            txt_sektor.Clear();
            txt_telNo.Clear();
        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
            listele_tedarikci();
        }

        private void btn_temiz_Click(object sender, EventArgs e)
        {
            temizle();
        }

        public void listele_tedarikci()
        {
            SqlCommand sorgu = new SqlCommand("select * from tedarikciBilgileri", baglantım.baglanti());
            // gridview içerisinde gösterme

            SqlDataAdapter dak = new SqlDataAdapter(sorgu);
            DataTable dtk = new DataTable();
            dak.Fill(dtk);
            gridControl1.DataSource = dtk;
            gridView1.Columns["ID"].Visible = false;

            gridView1.Columns["firmaAdi"].Caption = "FİRMA ADI";
            gridView1.Columns["sektor"].Caption = "SEKTÖR";
            gridView1.Columns["firmaYetkilisi"].Caption = "FİRMA YETKİLİSİ";
            gridView1.Columns["telefonNumarası"].Caption = "TELEFON NUMARASI";
            gridView1.Columns["adresi"].Caption = "ADRES";


            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;


        }

        private void Tedarikçiler_Load(object sender, EventArgs e)
        {
            listele_tedarikci();
        }

        // ÇİF TIKLIYARAK TEXTBOXLARA YAZDIRMAK

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            txt_firmaAdi.Text = gridView1.GetFocusedRowCellValue("firmaAdi").ToString();
            txt_sektor.Text = gridView1.GetFocusedRowCellValue("sektor").ToString();
            txt_firmaYetkilisi.Text = gridView1.GetFocusedRowCellValue("firmaYetkilisi").ToString();
            txt_telNo.Text = gridView1.GetFocusedRowCellValue("telefonNumarası").ToString();
            txt_adres.Text = gridView1.GetFocusedRowCellValue("adresi").ToString();

            textBox1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();

        }


        // SİL
        public void sil()
        {

           // int ID = 0;

            bool kayit_arama_durumu = false;

            SqlCommand secmeSorgusu = new SqlCommand("Select *from tedarikciBilgileri where ID = '" + textBox1.Text + "'", baglantım.baglanti());
            SqlDataReader kayitokuma = secmeSorgusu.ExecuteReader();
            while (kayitokuma.Read())
            {


                kayit_arama_durumu = true;
                SqlCommand silsorgusu = new SqlCommand("delete from tedarikciBilgileri where ID = '" + textBox1.Text + "'", baglantım.baglanti());

                silsorgusu.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarılı bir şekilde silinmiştir.", "STOK KONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                baglantım.baglanti().Close();

                listele_tedarikci();
                temizle();
         
                break;
            }

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            sil();
        }

        //GÜNCELLE
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_firmaAdi.Text != "" && txt_firmaYetkilisi.Text != "")
            {
                SqlCommand guncellekomutu = new SqlCommand("update tedarikciBilgileri set firmaAdi=@firmaAdi, sektor=@sektor, firmaYetkilisi=@firmaYetkilisi, telefonNumarası=@telefonNumarası, adresi=@adresi where ID=@ID", baglantım.baglanti());

                guncellekomutu.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox1.Text));
                guncellekomutu.Parameters.Add("@firmaAdi", SqlDbType.NVarChar, 50).Value = txt_firmaAdi.Text;
                guncellekomutu.Parameters.Add("@sektor", SqlDbType.NVarChar, 30).Value = txt_sektor.Text;
                guncellekomutu.Parameters.Add("@firmaYetkilisi", SqlDbType.NVarChar, 30).Value = txt_firmaYetkilisi.Text;
                guncellekomutu.Parameters.Add("@telefonNumarası", SqlDbType.NVarChar, 15).Value = txt_telNo.Text;
                guncellekomutu.Parameters.Add("@adresi", SqlDbType.NVarChar, 150).Value = txt_adres.Text;
              
                guncellekomutu.ExecuteNonQuery();
                listele_tedarikci();
                temizle();

                MessageBox.Show("Başarılı bir şekilde güncellenmiştir.", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
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

        private void txt_firmaAdi_TextChanged(object sender, EventArgs e)
        {
            txt_firmaAdi.Text = txt_firmaAdi.Text.ToUpper();
            txt_firmaAdi.SelectionStart = txt_firmaAdi.Text.Length;
        }

        private void txt_sektor_TextChanged(object sender, EventArgs e)
        {
            txt_sektor.Text = txt_sektor.Text.ToUpper();
            txt_sektor.SelectionStart = txt_sektor.Text.Length;
        }

        private void txt_firmaYetkilisi_TextChanged(object sender, EventArgs e)
        {
            txt_firmaYetkilisi.Text = txt_firmaYetkilisi.Text.ToUpper();
            txt_firmaYetkilisi.SelectionStart = txt_firmaYetkilisi.Text.Length;
        }
    }

}





