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
    public partial class Hesap_olustur : Form
    {
        public Hesap_olustur()
        {
            InitializeComponent();
        }
        sqlBaglantisi baglantim = new sqlBaglantisi();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            {
                //VERİ TABANINA KAYDEDER
                if (txt_adsoyad.Text != "" && txt_kullanıcıadı.Text != "" && txt_sıfre.Text !="" && txt_sıfretekrar.Text !="" && cmb_birim.Text !=""&& txt_sıfretekrar.Text==txt_sıfre.Text)
                {
                    SqlCommand kaydet = new SqlCommand("insert into Kullanıcılar(adSoyad,kullanıcıAdı,sifre,birim) values (@adSoyad,@sifre,@kullanıcıAdı,@birim)", baglantim.baglanti());
                    kaydet.Parameters.Add("@adSoyad", SqlDbType.NVarChar, 50).Value = txt_adsoyad.Text;
                    kaydet.Parameters.Add("@kullanıcıAdı", SqlDbType.NVarChar, 50).Value = txt_kullanıcıadı.Text;
                    kaydet.Parameters.Add("@sifre", SqlDbType.NVarChar,20).Value = txt_sıfre.Text;
                    kaydet.Parameters.Add("@birim", SqlDbType.NVarChar, 20).Value = cmb_birim.Text;

        
                    try
                    {
                        kaydet.ExecuteNonQuery();
                        MessageBox.Show("Hesap oluşturulmuştur.", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("hata");
                        throw;
                    }
                }
                else if (txt_sıfre.Text != txt_sıfretekrar.Text)
                {
                    MessageBox.Show("Şifrenizi kontrol ediniz", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    MessageBox.Show("Lütfen boşlukları doldurunuz ! ", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }



            }
        }
    }
}
