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


namespace stokTakip
{
    public partial class stokKaydi : Form
    {
        public stokKaydi()
        {
            InitializeComponent();
        }
       


        sqlBaglantisi baglantım = new sqlBaglantisi();
        private void stokKaydi_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from ProsesGrubu", baglantım.baglanti());
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cb_proses.Items.Add(dr["ProsesGrubu"]);
            }



            SqlCommand komut1 = new SqlCommand("select * from Grup", baglantım.baglanti());
            SqlDataReader dr1;
            dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cb_grup.Items.Add(dr1[1].ToString());
            }
            SqlCommand komut2 = new SqlCommand("select * from AltGrup", baglantım.baglanti());
            SqlDataReader dr2;
            dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cb_altgrup.Items.Add(dr2[1].ToString());//[1]=kacıncı sütün oldunu gösterir 0 dan başlar sütünlar
            }
            SqlCommand komut3 = new SqlCommand("select * from MalzemeCinsi", baglantım.baglanti());
            SqlDataReader dr3;
            dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cb_malzeme.Items.Add(dr3[1].ToString());
            }
            listele_stok();
        }
        //Gridcontrolde listeleme
        public void listele_stok()
        {
            SqlCommand sorgu = new SqlCommand("select * from tbl_stokKarti", baglantım.baglanti());
            // gridview içerisinde gösterme

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
            gridView1.Columns["birim"].Caption = "BİRİM";


            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;


        }

        //SİLGİ
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txt_uzunluk.Clear();
            txt_miktar.Clear();
            txt_ihtiyac.Clear();
            txt_stokAdi.Clear();
            txt_tedarik.Clear();
            cb_altgrup.Text = "Seçiniz..";
            cb_proses.Text = "Seçiniz..";
            cb_malzeme.Text = "Seçiniz..";
            cb_grup.Text = "Seçiniz..";
        }




        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cb_proses.Text == "Seçiniz..." || cb_grup.Text == "Seçiniz..." || cb_altgrup.Text == "Seçiniz..." || cb_malzeme.Text == "Seçiniz...." || txt_uzunluk.Text == "" || txt_miktar.Text == "" || txt_ihtiyac.Text == "" || txt_stokAdi.Text == "" || txt_tedarik.Text == "")
            {
                MessageBox.Show("EKSİK BİLGİ GİRDİNİZ !");
            }
            else
            {//GİRİLEN BİLGİLERİ VERİ TABANINA KAYDEDER

                SqlCommand komut = new SqlCommand("insert into tbl_stokKarti " +
                    "(prosesGrubu,grupAdi,altGrupAdi,parcaStokAdi,malzemeCinsi,uzunluk,miktar,ihtiyac,tedarikci,tarih) values" +
                    "('" + cb_proses.Text + "','" + cb_grup.Text + "','" + cb_altgrup.Text + "','" + txt_stokAdi.Text + "','" + cb_malzeme.Text + "','" + txt_uzunluk.Text + "','" + txt_miktar.Text + "','" + txt_ihtiyac.Text + "','" + txt_tedarik.Text + "','" + dateTimePicker1.Text + "')", baglantım.baglanti());
                komut.ExecuteNonQuery();
                MessageBox.Show("KAYIT OLUŞTURULDU");

            }

        }
        //sadece rakam yazılabilir yapar
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (cb_proses.Text == "Seçiniz..." || cb_proses.Text == "")
                label2.ForeColor = Color.Red;

            else
                label2.ForeColor = Color.Black;

            if (cb_grup.Text == "Seçiniz..." || cb_grup.Text == "")
                label4.ForeColor = Color.Red;

            else
                label4.ForeColor = Color.Black;


            if (cb_altgrup.Text == "Seçiniz..." || cb_altgrup.Text == "")
                label1.ForeColor = Color.Red;

            else
                label1.ForeColor = Color.Black;


            if (cb_malzeme.Text == "Seçiniz..." || cb_malzeme.Text == "")
                label3.ForeColor = Color.Red;

            else
                label3.ForeColor = Color.Black;


            if (txt_stokAdi.Text == "")
                label8.ForeColor = Color.Red;

            else
                label8.ForeColor = Color.Black;

            if (txt_uzunluk.Text == "")
                label5.ForeColor = Color.Red;

            else
                label5.ForeColor = Color.Black;


            if (txt_miktar.Text == "" || cb_birim.Text == "")
                label6.ForeColor = Color.Red;

            else
                label6.ForeColor = Color.Black;


            if (txt_ihtiyac.Text == "")
                label7.ForeColor = Color.Red;

            else
                label7.ForeColor = Color.Black;


            if (txt_tedarik.Text == "")
                label9.ForeColor = Color.Red;

            else
                label9.ForeColor = Color.Black;

            if (cb_proses.Text != "Seçiniz..." && cb_grup.Text != "Seçiniz..." &&
                cb_altgrup.Text != "Seçiniz..." && cb_malzeme.Text != "Seçiniz..." && cb_malzeme.Text != "" &&
                txt_stokAdi.Text != "" && txt_uzunluk.Text != "" && txt_miktar.Text != "" && cb_birim.Text != "" &&
                   txt_ihtiyac.Text != "" && txt_tedarik.Text != "")
            {
                //VERİ TABANINA KAYDEDER
                SqlCommand kaydet = new SqlCommand("insert into tbl_stokKarti(prosesGrubu,grupAdi,altGrupAdi,parcaStokAdi," +
                    "malzemeCinsi,uzunluk,miktar,ihtiyac,tedarikci,tarih,birim) values (@prosesGrubu,@grupAdi,@altGrupAdi,@parcaStokAdi," +
                    "@malzemeCinsi,@uzunluk,@miktar,@ihtiyac,@tedarikci,@tarih,@birim)", baglantım.baglanti());
                kaydet.Parameters.Add("@prosesGrubu", SqlDbType.NVarChar, 100).Value = cb_proses.Text;
                kaydet.Parameters.Add("@grupAdi", SqlDbType.NVarChar, 100).Value = cb_grup.Text;
                kaydet.Parameters.Add("@altGrupAdi", SqlDbType.NVarChar, 100).Value = cb_altgrup.Text;
                kaydet.Parameters.Add("@parcaStokAdi", SqlDbType.NVarChar, 100).Value = txt_stokAdi.Text;
                kaydet.Parameters.Add("@malzemeCinsi", SqlDbType.NVarChar, 100).Value = cb_malzeme.Text;
                kaydet.Parameters.Add("@uzunluk", SqlDbType.NVarChar, 50).Value = txt_uzunluk.Text;
                kaydet.Parameters.Add("@miktar", SqlDbType.NVarChar, 50).Value = txt_miktar.Text;
                kaydet.Parameters.Add("@ihtiyac", SqlDbType.NVarChar, 50).Value = txt_ihtiyac.Text;
                kaydet.Parameters.Add("@tedarikci", SqlDbType.NVarChar, 100).Value = txt_tedarik.Text;
                kaydet.Parameters.Add("@tarih", SqlDbType.Date).Value = dateTimePicker1.Value;
                kaydet.Parameters.Add("birim", SqlDbType.NVarChar, 10).Value = cb_birim.Text;
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


            }
            else
            {
                MessageBox.Show("kırmızı alanları gözden geçir");
            }
            listele_stok();
        }
        //GRİD CONTROL ÜZERİNE CİF TIKLIYARAK TEXTBOXLARA YAZDIRMAK
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            dateTimePicker1.Text = gridView1.GetFocusedRowCellValue("tarih").ToString();
            cb_proses.Text = gridView1.GetFocusedRowCellValue("prosesGrubu").ToString();
            cb_grup.Text = gridView1.GetFocusedRowCellValue("grupAdi").ToString();
            cb_altgrup.Text = gridView1.GetFocusedRowCellValue("altGrupAdi").ToString();
            cb_malzeme.Text = gridView1.GetFocusedRowCellValue("malzemeCinsi").ToString();
            txt_stokAdi.Text = gridView1.GetFocusedRowCellValue("parcaStokAdi").ToString();
            txt_uzunluk.Text = gridView1.GetFocusedRowCellValue("uzunluk").ToString();
            txt_miktar.Text = gridView1.GetFocusedRowCellValue("miktar").ToString();
            txt_ihtiyac.Text = gridView1.GetFocusedRowCellValue("ihtiyac").ToString();
            txt_tedarik.Text = gridView1.GetFocusedRowCellValue("tedarikci").ToString();
            cb_birim.Text = gridView1.GetFocusedRowCellValue("birim").ToString();
            textBox1.Text = gridView1.GetFocusedRowCellValue("id").ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (cb_proses.Text != "Seçiniz..." && cb_grup.Text != "Seçiniz..." &&
                cb_altgrup.Text != "Seçiniz..." && cb_malzeme.Text != "Seçiniz..." && cb_malzeme.Text != "" &&
                txt_stokAdi.Text != "" && txt_uzunluk.Text != "" && txt_miktar.Text != "" && cb_birim.Text != "" &&
                   txt_ihtiyac.Text != "" && txt_tedarik.Text != "")
            {


                SqlCommand guncellekomutu = new SqlCommand("update tbl_stokKarti set prosesGrubu=@prosesGrubu, grupAdi=@grupAdi, altGrupAdi=@altGrupAdi, parcaStokAdi=@parcaStokAdi, malzemeCinsi=@malzemeCinsi, uzunluk=@uzunluk, miktar=@miktar, ihtiyac=@ihtiyac, tedarikci=@tedarikci, tarih=@tarih, birim=@birim where id=@id", baglantım.baglanti());

                guncellekomutu.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
                guncellekomutu.Parameters.Add("@prosesGrubu", SqlDbType.NVarChar, 100).Value = cb_proses.Text;
                guncellekomutu.Parameters.Add("@grupAdi", SqlDbType.NVarChar, 100).Value = cb_grup.Text;
                guncellekomutu.Parameters.Add("@altGrupAdi", SqlDbType.NVarChar, 100).Value = cb_altgrup.Text;
                guncellekomutu.Parameters.Add("@parcaStokAdi", SqlDbType.NVarChar, 100).Value = txt_stokAdi.Text;
                guncellekomutu.Parameters.Add("@malzemeCinsi", SqlDbType.NVarChar, 100).Value = cb_malzeme.Text;
                guncellekomutu.Parameters.Add("@uzunluk", SqlDbType.NVarChar, 50).Value = txt_uzunluk.Text;
                guncellekomutu.Parameters.Add("@miktar", SqlDbType.Int).Value = txt_miktar.Text;
                guncellekomutu.Parameters.Add("@ihtiyac", SqlDbType.Int).Value = txt_ihtiyac.Text;
                guncellekomutu.Parameters.Add("@tedarikci", SqlDbType.NVarChar, 100).Value = txt_tedarik.Text;
                guncellekomutu.Parameters.Add("@tarih", SqlDbType.Date).Value = dateTimePicker1.Text;
                guncellekomutu.Parameters.Add("@birim", SqlDbType.NVarChar, 10).Value = cb_birim.Text;
                guncellekomutu.ExecuteNonQuery();

                listele_stok();
                MessageBox.Show("Başarılı bir şekilde güncellenmiştir.", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi BAŞARISIZDIR ! lütfen Boşlukları doldurunuz !", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // SİLME
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            int ID = 0;



            {
                bool kayit_arama_durumu = false;

                SqlCommand secmeSorgusu = new SqlCommand("Select *from tbl_stokKarti where id='" + textBox1.Text + "'", baglantım.baglanti());
                SqlDataReader kayitokuma = secmeSorgusu.ExecuteReader();
                while (kayitokuma.Read())
                {


                    kayit_arama_durumu = true;
                    SqlCommand silsorgusu = new SqlCommand("delete from tbl_stokKarti where id='" + textBox1.Text + "'", baglantım.baglanti());

                    silsorgusu.ExecuteNonQuery();
                    MessageBox.Show("Stok kaydı başarılı bir şekilde silinmiştir.", "STOK KONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    baglantım.baglanti().Close();

                    listele_stok();
                    txt_uzunluk.Clear();
                    txt_miktar.Clear();
                    txt_ihtiyac.Clear();
                    txt_stokAdi.Clear();
                    txt_tedarik.Clear();
                    cb_altgrup.Text = "Seçiniz..";
                    cb_proses.Text = "Seçiniz..";
                    cb_malzeme.Text = "Seçiniz..";
                    cb_grup.Text = "Seçiniz..";
                    break;
                }
            }
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
    }
}
