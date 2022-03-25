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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();

        }
        sqlBaglantisi baglantım = new sqlBaglantisi();

        public string yetki, kullaniciAdi;
        public string a;
        public string isim;

        // veritabanındaki birimlere göre ekranları açar
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txt_kullanıcıadı.Text != "" && txt_sifre.Text != "")
            {
                SqlCommand selectsorguiki = new SqlCommand("select *from Kullanıcılar where kullanıcıAdı='" + txt_kullanıcıadı.Text + "'", baglantım.baglanti());
                SqlDataReader kayitokumaiki = selectsorguiki.ExecuteReader();

                while (kayitokumaiki.Read())
                {
                    ekran_tasarım fr = new ekran_tasarım();

                    MessageBox.Show(txt_kullanıcıadı.Text);

                    //kullanıcı adını ekle_çıkar formuna yazdırmak için;
                    EKLE_CIKART.kullanıcıadi = txt_kullanıcıadı.Text;
                    //ekranlara kullanıcı adını yazar mal kabul
                    ekran_depo.kullanıcıadi = txt_kullanıcıadı.Text;


                    string gelen, gelen2;
                    gelen = kayitokumaiki.GetValue(4).ToString();
                    gelen2 = kayitokumaiki.GetValue(2).ToString();
                    if (gelen == "TASARIM")
                    {
                        ekran_tasarım frm1 = new ekran_tasarım();
                        yetki = gelen;
                        kullaniciAdi = gelen2;
                        isim = txt_kullanıcıadı.Text;
                        frm1.t = isim;
                        frm1.Show();

                    }
                    else if (gelen == "DEPO")
                    {
                        ekran_depo frm2 = new ekran_depo();
                        yetki = gelen;
                        kullaniciAdi = gelen2;
                        frm2.Show();

                    }
                    else
                    {
                        ekran frm3 = new ekran();
                        yetki = gelen;
                        kullaniciAdi = gelen2;
                        frm3.Show();

                    }

                }
            }
           else if (txt_kullanıcıadı.Text == "" || txt_sifre.Text == "")
            {
                MessageBox.Show("BOŞLUKLARI DOLDURUNUZ !");

            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE HATALI");
                txt_kullanıcıadı.Clear();
                txt_sifre.Clear();

            }

        }

        private void Giris_Load(object sender, EventArgs e)
        {
            

        }
        //enter tuşu ile giriş yapar formun keypriew ini true yapmalıyız önce
        private void Giris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                simpleButton1.PerformClick();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
