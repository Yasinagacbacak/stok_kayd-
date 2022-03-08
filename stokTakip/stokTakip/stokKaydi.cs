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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into StokKartı (ProsesGrubu,GrupAdı,AltGrupAdı,MalzemeCinsi,Uzunluk,Miktar,İhtiyaç,Tedarikçi,Tarih,ParçaStokAdı) values('" + comboBox2.Text.ToString() + "','" + comboBox4.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + dateTimePicker1.Text.ToString() + "','" + textBox4.Text.ToString() + "')", baglantım.baglanti());
            komut.ExecuteNonQuery();


        }

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

        private void stokKaydi_Load(object sender, EventArgs e)
        {

        }
    }
}
