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
    public partial class Talep_onay_red : Form
    {
        public Talep_onay_red()
        {
            InitializeComponent();
        }
        sqlBaglantisi baglantim = new sqlBaglantisi();

        public string d;
        public int y;

        private void Talep_onay_red_Load(object sender, EventArgs e)
        {
            cmb_durum.Text = d.ToString();
            //txt_aciklama.Text = a.ToString();
            txt_ID.Text = y.ToString();


        }

        //kayıt
        private void btn_gonder_Click_1(object sender, EventArgs e)
        {//buranın kodu güncellle komutu ile revize edilecek.
         //id bulunacak sonra o idye göre işlm yağılacak.
         //eğer kaydet komutarı kullnıır ise tabloya yeni kayıt eklenir var olan kayıtlar etkilenmez.
         //önce güncelle komutu incelenmelidir? nasıl yaptımız hatırrlanmalıdır.
            if (cmb_durum.Text != "" && txt_aciklama.Text != "")
            {
                SqlCommand guncellekomutu = new SqlCommand("update StokTalebi set durumu=@durumu, acıklama=@acıklama where ID=@ID", baglantim.baglanti());
                guncellekomutu.Parameters.AddWithValue("@ID", Convert.ToInt32(txt_ID.Text));
                guncellekomutu.Parameters.Add("@durumu", SqlDbType.NVarChar, 10).Value = cmb_durum.Text;
                guncellekomutu.Parameters.Add("@acıklama", SqlDbType.NVarChar, 200).Value = txt_aciklama.Text;

                guncellekomutu.ExecuteNonQuery();
                MessageBox.Show("Yanıtınız kaydedilmiştir", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//ilk tırnak içi mesaj içeriği ikinci tırnak içi mesaj kutusunun başlığıdır.


            }
            if (cmb_durum.Text == "" || txt_aciklama.Text == "")
            {
                MessageBox.Show("Lütfen boşlukları doldurunuz !", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }

                        
    }
}
