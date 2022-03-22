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
    public partial class EKLE_CIKART : Form
    {
        public EKLE_CIKART()
        {
            InitializeComponent();
        }
        sqlBaglantisi baglantim = new sqlBaglantisi();

        public string s, b;
        public int m;


        private void EKLE_CIKART_Load(object sender, EventArgs e)
        {
            depoGoruntule frm1 = new depoGoruntule();
            //frm1.stokadi = lbl_stokadi.Text;
            //frm1.birim = lbl_birim.Text;
            //frm1.miktar = int.Parse(txt_mevcut.Text);
            lbl_stokadi.Text = s.ToString();
            lbl_birim.Text = b.ToString();
            lbl_mevcut.Text = m.ToString();
            //lbl_birim.Text = frm1.birim;
            //txt_mevcut.Text = frm1.miktar.ToString();


        }
        // sadece rakam yazılabilir
        private void txt_ihtiyac_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            //VERİ TABANINA KAYDEDER
            if (txt_ihtiyac.Text != "" && txt_projeadi.Text != "")
            {
                SqlCommand kaydet = new SqlCommand("insert into StokTalebi(stokAdi,projeAdi,ihtiyac,birim," +
                    "durumu,tarih) values (@stokAdi,@projeAdi,@ihtiyac,@birim," +
                    "@durumu,@tarih)", baglantim.baglanti());
                kaydet.Parameters.Add("@stokAdi", SqlDbType.NVarChar, 100).Value = lbl_stokadi.Text;
                kaydet.Parameters.Add("@projeAdi", SqlDbType.NVarChar, 50).Value = txt_projeadi.Text;
                kaydet.Parameters.Add("@ihtiyac", SqlDbType.Int).Value = txt_ihtiyac.Text;
                kaydet.Parameters.Add("@birim", SqlDbType.NVarChar, 50).Value = lbl_birim.Text;
                kaydet.Parameters.Add("@durumu", SqlDbType.NChar, 50).Value = "Beklemede";
                kaydet.Parameters.Add("@tarih", SqlDbType.Date).Value = dateTimePicker1.Value;

                try
                {
                    kaydet.ExecuteNonQuery();
                    MessageBox.Show("Talep oluşturulmuştur.", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("hata");
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Lütfen boşlukları doldurunuz ! ", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
                     
            
        }

    }
}
