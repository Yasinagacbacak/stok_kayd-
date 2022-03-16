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
                comboBox2.Items.Add(dr["ProsesGrubu"]);
            }



            SqlCommand komut1 = new SqlCommand("select * from Grup", baglantım.baglanti());
            SqlDataReader dr1;
            dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox4.Items.Add(dr1[1].ToString());
            }
            SqlCommand komut2 = new SqlCommand("select * from AltGrup", baglantım.baglanti());
            SqlDataReader dr2;
            dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[1].ToString());//[1]=kacıncı sütün oldunu gösterir 0 dan başlar sütünlar
            }
            SqlCommand komut3 = new SqlCommand("select * from MalzemeCinsi", baglantım.baglanti());
            SqlDataReader dr3;
            dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox3.Items.Add(dr3[1].ToString());
            }
        }

        //SİLGİ
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "Seçiniz..";
            comboBox2.Text = "Seçiniz..";
            comboBox3.Text = "Seçiniz..";
            comboBox4.Text = "Seçiniz..";
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Seçiniz..." || comboBox4.Text == "Seçiniz..." || comboBox1.Text == "Seçiniz..." || comboBox3.Text == "Seçiniz...." || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("EKSİK BİLGİ GİRDİNİZ !");
            }
            else
            {//GİRİLEN BİLGİLERİ VERİ TABANINA KAYDEDER

                SqlCommand komut = new SqlCommand("insert into tbl_stokKarti " +
                    "(prosesGrubu,grupAdi,altGrupAdi,parcaStokAdi,malzemeCinsi,uzunluk,miktar,ihtiyac,tedarikci,tarih) values" +
                    "('" + comboBox2.Text+ "','" + comboBox4.Text+ "','" + comboBox1.Text + "','" + textBox4.Text + "','" + comboBox3.Text + "','" + textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text+ "','" + dateTimePicker1.Text + "')", baglantım.baglanti());
                komut.ExecuteNonQuery();
                MessageBox.Show("KAYIT OLUŞTURULDU");
                
            }
    
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

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
    }
}
