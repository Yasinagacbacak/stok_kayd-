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
        static public string kullanıcıadi;
        public string s, b;
        public int m;


        private void EKLE_CIKART_Load(object sender, EventArgs e)
        {
            depoGoruntule frm1 = new depoGoruntule();
          
            lbl_stokadi.Text = s.ToString();
            lbl_birim.Text = b.ToString();
            lbl_mevcut.Text = m.ToString();
            //kullanıcı adını yazdırmak için;
            lbl_talepeden.Text = kullanıcıadi;

          


        }
        // sadece rakam yazılabilir
        private void txt_ihtiyac_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void EKLE_CIKART_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btn_guncelle.PerformClick();
            }
        }

        private void txt_projeadi_TextChanged(object sender, EventArgs e)
        {
            txt_projeadi.Text = txt_projeadi.Text.ToUpper();
            txt_projeadi.SelectionStart = txt_projeadi.Text.Length;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            //VERİ TABANINA KAYDEDER
            if (txt_ihtiyac.Text != "" && txt_projeadi.Text != "")
            {
                SqlCommand kaydet = new SqlCommand("insert into StokTalebi(stokAdi,projeAdi,ihtiyac,birim," +
                    "durumu,tarih,talepEden) values (@stokAdi,@projeAdi,@ihtiyac,@birim," +
                    "@durumu,@tarih,@talepEden)", baglantim.baglanti());
                kaydet.Parameters.Add("@stokAdi", SqlDbType.NVarChar, 100).Value = lbl_stokadi.Text;
                kaydet.Parameters.Add("@projeAdi", SqlDbType.NVarChar, 50).Value = txt_projeadi.Text;
                kaydet.Parameters.Add("@ihtiyac", SqlDbType.Int).Value = txt_ihtiyac.Text;
                kaydet.Parameters.Add("@birim", SqlDbType.NVarChar, 50).Value = lbl_birim.Text;
                kaydet.Parameters.Add("@durumu", SqlDbType.NChar, 50).Value = "BEKLEMEDE";
                kaydet.Parameters.Add("@tarih", SqlDbType.Date).Value = dateTimePicker1.Value;
                kaydet.Parameters.Add("@talepEden", SqlDbType.NVarChar, 50).Value = lbl_talepeden.Text;

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
