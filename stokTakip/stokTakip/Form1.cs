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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sqlBaglantisi baglantım = new sqlBaglantisi();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("PROSES GRUBU");
            comboBox1.Items.Add("GRUP");
            comboBox1.Items.Add("ALT GRUP");
            comboBox1.Items.Add("MALZEME CİNSİ");
            AltGrup();
            Grup();
            MalzemeCinsi();
            ProsesGrubu();



        }

        private void simpleButton1_Click(object sender, EventArgs e)
        //veritabanına kayıt işlemi
        {
            if (comboBox1.Text == "ALT GRUP")
            {
                SqlCommand komut = new SqlCommand("insert into AltGrup(AltGrup,Açıklama)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')", baglantım.baglanti());

                komut.ExecuteNonQuery();
            }
            if (comboBox1.Text == "GRUP")
            {
                SqlCommand komut = new SqlCommand("insert into Grup(Grup,Açıklama)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')", baglantım.baglanti());

                komut.ExecuteNonQuery();
            }
            if (comboBox1.Text == "MALZEME CİNSİ")
            {
                SqlCommand komut = new SqlCommand("insert into MalzemeCinsi(MalzemeCinsi,Açıklama)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')", baglantım.baglanti());

                komut.ExecuteNonQuery();
            }
            if (comboBox1.Text == "PROSES GRUBU")
            {
                SqlCommand komut = new SqlCommand("insert into ProsesGrubu(ProsesGrubu,Açıklama)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')", baglantım.baglanti());

                komut.ExecuteNonQuery();
            }
            MessageBox.Show("KAYDEDİLDİ");
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "Seçiniz..";


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "Seçiniz..";

        }
        public void AltGrup()
        {
            SqlCommand sorgu = new SqlCommand("select * from AltGrup", baglantım.baglanti());
            // gridview içerisinde gösterme

            SqlDataAdapter dak = new SqlDataAdapter(sorgu);
            DataTable dtk = new DataTable();
            dak.Fill(dtk);
            gridControl1.DataSource = dtk;
            gridView1.Columns["ID"].Visible = false;

            gridView1.Columns["AltGrup"].Caption = "ALT GRUP";
            gridView1.Columns["Açıklama"].Caption = "AÇIKLAMA";

            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;


        }
        public void Grup()
        {
            SqlCommand sorgu2 = new SqlCommand("select * from Grup", baglantım.baglanti());
            // sorgu_Kisi.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dak2 = new SqlDataAdapter(sorgu2);
            DataTable dtk2 = new DataTable();
            dak2.Fill(dtk2);
            gridControl2.DataSource = dtk2;
            gridView2.Columns["ID"].Visible = false;

            gridView2.Columns["Grup"].Caption = "GRUP";
            gridView2.Columns["Açıklama"].Caption = "AÇIKLAMA";

            gridView2.OptionsBehavior.Editable = false;
            gridView2.OptionsView.ShowAutoFilterRow = true;


        }

        public void MalzemeCinsi()
        {
            SqlCommand sorgu3 = new SqlCommand("select * from MalzemeCinsi", baglantım.baglanti());
            // sorgu_Kisi.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dak3 = new SqlDataAdapter(sorgu3);
            DataTable dtk3 = new DataTable();
            dak3.Fill(dtk3);
            gridControl3.DataSource = dtk3;
            gridView3.Columns["ID"].Visible = false;

            gridView3.Columns["MalzemeCinsi"].Caption = "MALZEME CİNSİ";
            gridView3.Columns["Açıklama"].Caption = "AÇIKLAMA";

            gridView3.OptionsBehavior.Editable = false;
            gridView3.OptionsView.ShowAutoFilterRow = true;

        }
        public void ProsesGrubu()
        {
            SqlCommand sorgu4 = new SqlCommand("select * from ProsesGrubu", baglantım.baglanti());
            // sorgu_Kisi.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dak4 = new SqlDataAdapter(sorgu4);
            DataTable dtk4 = new DataTable();
            dak4.Fill(dtk4);
            gridControl4.DataSource = dtk4;
            gridView4.Columns["ID"].Visible = false;

            gridView4.Columns["ProsesGrubu"].Caption = "PROSES GRUBU";
            gridView4.Columns["Açıklama"].Caption = "AÇIKLAMA";

            gridView4.OptionsBehavior.Editable = false;
            gridView4.OptionsView.ShowAutoFilterRow = true;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
          
        }
    }

}


