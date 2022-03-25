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
    public partial class urunCikisi : Form
    {
        public urunCikisi()
        {
            InitializeComponent();
        }
        sqlBaglantisi baglantım = new sqlBaglantisi();

        string eskisiIstenicek = "";
         string eskisiIsteme="";

        public void listele_urunCikisi()
        {
            SqlCommand sorgu = new SqlCommand("select * from malzemeCikis", baglantım.baglanti());
            // gridview içerisinde gösterme

            SqlDataAdapter dak = new SqlDataAdapter(sorgu);
            DataTable dtk = new DataTable();
            dak.Fill(dtk);
            gridControl1.DataSource = dtk;
            gridView1.Columns["ID"].Visible = false;

            gridView1.Columns["projeNO"].Caption = "PROJE NO";
            gridView1.Columns["parcaStokAdi"].Caption = "PARÇA STOK ADI";
            gridView1.Columns["miktar"].Caption = "MİKTAR";
            gridView1.Columns["tur"].Caption = "TÜR";
            gridView1.Columns["tesimAlan"].Caption = "TESLİM ALAN";
            gridView1.Columns["birim"].Caption = "BİRİM";
            gridView1.Columns["tarih"].Caption = "TARİH";
            gridView1.Columns["acıklama"].Caption = "AÇIKLAMA";
            gridView1.Columns["eskisiİstenicek"].Caption = "ESKİSİ İSTENİCEK";
            gridView1.Columns["İstenmeyecek"].Caption = "İSTENMEYECEK";



            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;


        }



        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_projeNo.Text != "" && txt_stokAdi.Text != "" && txt_miktar.Text != "" && cmb_birim.Text != "Seçiniz..." && txt_teslimAlan.Text != "" && cmb_tur.Text != "Seçiniz...")
            {
                //VERİ TABANINA KAYDEDER
                SqlCommand kaydet = new SqlCommand("insert into malzemeCikis(projeNO,parcaStokAdi,miktar,tur," +
                    "tesimAlan,birim,tarih,acıklama,eskisiİstenicek,İstenmeyecek) values (@projeNO,@parcaStokAdi,@miktar,@tur," +
                    "@tesimAlan,@birim,@tarih,@acıklama,@eskisiİstenicek,@İstenmeyecek)", baglantım.baglanti());
                kaydet.Parameters.Add("@projeNO", SqlDbType.NVarChar, 10).Value = txt_projeNo.Text;
                kaydet.Parameters.Add("@parcaStokAdi", SqlDbType.NVarChar, 50).Value = txt_stokAdi.Text;
                kaydet.Parameters.Add("@miktar", SqlDbType.Int).Value = txt_miktar.Text;
                kaydet.Parameters.Add("@tur", SqlDbType.NVarChar, 10).Value = cmb_tur.Text;
                kaydet.Parameters.Add("@tesimAlan", SqlDbType.NVarChar, 50).Value = txt_teslimAlan.Text;
                kaydet.Parameters.Add("@birim", SqlDbType.NVarChar, 50).Value = cmb_birim.Text;
                kaydet.Parameters.Add("@tarih", SqlDbType.Date).Value = dateTimePicker1.Text;
                kaydet.Parameters.Add("@acıklama", SqlDbType.NVarChar, 200).Value = txt_acıklama.Text;
                if (rb_kırıldı_bozuldu.Checked == true)
                {
                    kaydet.Parameters.Add("@eskisiİstenicek", SqlDbType.NVarChar, 50).Value = rb_kırıldı_bozuldu.Text;
                }
                if (rb_is_gormedi.Checked == true)
                {
                    kaydet.Parameters.Add("@eskisiİstenicek", SqlDbType.NVarChar, 50).Value = rb_is_gormedi.Text;
                }
                if (rb_servis.Checked == true)
                {
                    kaydet.Parameters.Add("@eskisiİstenicek", SqlDbType.NVarChar, 50).Value = rb_servis.Text;
                }
                if (rb_yanlıs_malzeme.Checked == true)
                {
                    kaydet.Parameters.Add("@eskisiİstenicek", SqlDbType.NVarChar, 50).Value = rb_yanlıs_malzeme.Text;
                }
                if (rb_eksik.Checked == true)
                {
                    kaydet.Parameters.Add("@İstenmeyecek", SqlDbType.NVarChar, 50).Value = rb_eksik.Text;
                }
                if (rb_sarf.Checked == true)
                {
                    kaydet.Parameters.Add("@İstenmeyecek", SqlDbType.NVarChar, 50).Value = rb_sarf.Text;
                }
                if (rb_bosisteme.Checked == true)
                {
                    kaydet.Parameters.Add("@eskisiİstenicek", SqlDbType.NVarChar, 50).Value = "";
                }
                if (rb_istemebos.Checked == true)
                {
                    kaydet.Parameters.Add("@İstenmeyecek", SqlDbType.NVarChar, 50).Value = "";
                }

                try
                {
                    kaydet.ExecuteNonQuery();
                    MessageBox.Show("KAYDEDİLDİ");
                }
                catch (Exception)
                {
                    MessageBox.Show("hata");
                    throw;
                }

            }
            else
            {
                MessageBox.Show("LÜTFEN BOŞLUKLARI DOLDURUNUZ !");
            }
            listele_urunCikisi();
        }
        //temizle
        public void temizle()
        {
            txt_projeNo.Clear();
            txt_stokAdi.Clear();
            txt_miktar.Clear();
            txt_teslimAlan.Clear();
            txt_acıklama.Clear();
            cmb_birim.Text = "Seçiniz...";
            cmb_tur.Text = "Seçiniz...";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            temizle();

        }

        private void urunCikisi_Load(object sender, EventArgs e)
        {
            listele_urunCikisi();
        }
        //gridviewe çif tık yaparak texboxlara yazdırmak
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            txt_projeNo.Text = gridView1.GetFocusedRowCellValue("projeNO").ToString();
            txt_stokAdi.Text = gridView1.GetFocusedRowCellValue("parcaStokAdi").ToString();
            txt_miktar.Text = gridView1.GetFocusedRowCellValue("miktar").ToString();
            cmb_tur.Text = gridView1.GetFocusedRowCellValue("tur").ToString();
            txt_teslimAlan.Text = gridView1.GetFocusedRowCellValue("tesimAlan").ToString();
            cmb_birim.Text = gridView1.GetFocusedRowCellValue("birim").ToString();
            dateTimePicker1.Text = gridView1.GetFocusedRowCellValue("tarih").ToString();
            txt_miktar.Text = gridView1.GetFocusedRowCellValue("miktar").ToString();
            txt_acıklama.Text = gridView1.GetFocusedRowCellValue("acıklama").ToString();
            textBox1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            //rb_kırıldı_bozuldu.Text = gridView1.GetFocusedRowCellValue("tedarikci").ToString();
            //cb_birim.Text = gridView1.GetFocusedRowCellValue("birim").ToString();
            //textBox1.Text = gridView1.GetFocusedRowCellValue("id").ToString();
            if(gridView1.GetFocusedRowCellValue("eskisiİstenicek").ToString()== rb_kırıldı_bozuldu.Text)
            {
                rb_kırıldı_bozuldu.Checked = true;
            }
            else if(gridView1.GetFocusedRowCellValue("eskisiİstenicek").ToString() == rb_is_gormedi.Text)
            {
                rb_is_gormedi.Checked = true;
            }

            else if (gridView1.GetFocusedRowCellValue("eskisiİstenicek").ToString() == rb_servis.Text)
            {
                rb_servis.Checked = true;
            }
            else if (gridView1.GetFocusedRowCellValue("eskisiİstenicek").ToString() == rb_yanlıs_malzeme.Text)
            {
                rb_yanlıs_malzeme.Checked = true;
            }
            else if (gridView1.GetFocusedRowCellValue("eskisiİstenicek").ToString() == eskisiIstenicek)
            {
                rb_bosisteme.Checked = true;
            }
            else
                MessageBox.Show("Bir hata ile karşılaşıldı. Yönetici ile iletişime geçiniz.");


            if (gridView1.GetFocusedRowCellValue("İstenmeyecek").ToString() == rb_eksik.Text)
            {
                rb_eksik.Checked = true;
            }
            else if (gridView1.GetFocusedRowCellValue("İstenmeyecek").ToString() == rb_sarf.Text)
            {
                rb_sarf.Checked = true;
            }

            else if (gridView1.GetFocusedRowCellValue("İstenmeyecek").ToString() == eskisiIsteme)
            {
                rb_istemebos.Checked = true;
            }
            
            else
                MessageBox.Show("Bir hata ile karşılaşıldı. Yönetici ile iletişime geçiniz.");





        }
        //SİlME
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int ID = 0;



            {
                bool kayit_arama_durumu = false;

                SqlCommand secmeSorgusu = new SqlCommand("Select *from malzemeCikis where ID='" + textBox1.Text + "'", baglantım.baglanti());
                SqlDataReader kayitokuma = secmeSorgusu.ExecuteReader();
                while (kayitokuma.Read())
                {


                    kayit_arama_durumu = true;
                    SqlCommand silsorgusu = new SqlCommand("delete from malzemeCikis where ID='" + textBox1.Text + "'", baglantım.baglanti());

                    silsorgusu.ExecuteNonQuery();
                    MessageBox.Show("Stok kaydı başarılı bir şekilde silinmiştir.", "STOK KONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    baglantım.baglanti().Close();

                    listele_urunCikisi();
                    
                    break;
                }
            }
        }


        //GÜNCELLE
        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            if (txt_projeNo.Text != "" && txt_stokAdi.Text != "" && txt_miktar.Text != "" && cmb_birim.Text != "Seçiniz..." && txt_teslimAlan.Text != "" && cmb_tur.Text != "Seçiniz...")
            {
                SqlCommand guncellekomutu = new SqlCommand("update malzemeCikis set projeNO=@projeNO, parcaStokAdi=@parcaStokAdi, miktar=@miktar, tur=@tur, tesimAlan=@tesimAlan, birim=@birim, tarih=@tarih, acıklama=@acıklama, eskisiİstenicek=@eskisiİstenicek, İstenmeyecek=@İstenmeyecek where ID=@ID", baglantım.baglanti());
                
                guncellekomutu.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox1.Text));
                guncellekomutu.Parameters.Add("@projeNO", SqlDbType.NVarChar, 10).Value = txt_projeNo.Text;
                guncellekomutu.Parameters.Add("@parcaStokAdi", SqlDbType.NVarChar, 50).Value = txt_stokAdi.Text;
                guncellekomutu.Parameters.Add("@miktar", SqlDbType.Int).Value = txt_miktar.Text;
                guncellekomutu.Parameters.Add("@tur", SqlDbType.NVarChar, 15).Value = cmb_tur.Text;
                guncellekomutu.Parameters.Add("@tesimAlan", SqlDbType.NVarChar, 50).Value = txt_teslimAlan.Text;
                guncellekomutu.Parameters.Add("@birim", SqlDbType.NVarChar, 50).Value = cmb_birim.Text;
                guncellekomutu.Parameters.Add("@tarih", SqlDbType.Date).Value = dateTimePicker1.Text;
                guncellekomutu.Parameters.Add("@acıklama", SqlDbType.NVarChar, 200).Value = txt_acıklama.Text;

                if (rb_kırıldı_bozuldu.Checked == true)
                {
                    guncellekomutu.Parameters.Add("@eskisiİstenicek", SqlDbType.NVarChar, 50).Value = rb_kırıldı_bozuldu.Text;
                }
                else if (rb_is_gormedi.Checked == true)
                {
                    guncellekomutu.Parameters.Add("@eskisiİstenicek", SqlDbType.NVarChar, 50).Value = rb_is_gormedi.Text;
                }
                else if (rb_servis.Checked == true)
                {
                    guncellekomutu.Parameters.Add("@eskisiİstenicek", SqlDbType.NVarChar, 50).Value = rb_servis.Text;
                }
               else if (rb_yanlıs_malzeme.Checked == true)
                {
                    guncellekomutu.Parameters.Add("@eskisiİstenicek", SqlDbType.NVarChar, 50).Value = rb_yanlıs_malzeme.Text;
                }
                else
                    guncellekomutu.Parameters.Add("@eskisiİstenicek", SqlDbType.NVarChar, 50).Value = eskisiIstenicek;


                if (rb_eksik.Checked == true)
                {
                    guncellekomutu.Parameters.Add("@İstenmeyecek", SqlDbType.NVarChar, 50).Value = rb_eksik.Text;
                }
               else if (rb_sarf.Checked == true)
                {
                    guncellekomutu.Parameters.Add("@İstenmeyecek", SqlDbType.NVarChar, 50).Value = rb_sarf.Text;
                }
                //if (radioButton1.Checked == true)
                //{
                //    guncellekomutu.Parameters.Add("@eskisiİstenicek", SqlDbType.NVarChar, 50).Value = "";
                //}
               else
                {
                    guncellekomutu.Parameters.Add("@İstenmeyecek", SqlDbType.NVarChar, 50).Value = eskisiIsteme;
                }
               


                guncellekomutu.ExecuteNonQuery();
                listele_urunCikisi();
                
                MessageBox.Show("Başarılı bir şekilde güncellenmiştir.", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {
                MessageBox.Show("Güncelleme işlemi BAŞARISIZDIR ! lütfen Boşlukları doldurunuz !", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //yazı girilemez yapar
        private void txt_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        // PDF EXCEL WORD FORMATINA CEVİRME
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
    }
}
