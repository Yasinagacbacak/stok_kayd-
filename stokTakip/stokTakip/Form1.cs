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

            if (comboBox1.Text != "Seçiniz.." && textBox1.Text != "" && textBox2.Text != "")
            {


                if (comboBox1.Text == "ALT GRUP" && textBox1.Text != "" && textBox2.Text != "")
                {
                    SqlCommand komut = new SqlCommand("insert into AltGrup(AltGrup,Açıklama)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')", baglantım.baglanti());

                    komut.ExecuteNonQuery();
                    AltGrup();

                }


                if (comboBox1.Text == "GRUP" && textBox1.Text != "" && textBox2.Text != "")
                {
                    SqlCommand komut = new SqlCommand("insert into Grup(Grup,Açıklama)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')", baglantım.baglanti());

                    komut.ExecuteNonQuery();
                    Grup();
                }

                if (comboBox1.Text == "MALZEME CİNSİ" && textBox1.Text != "" && textBox2.Text != "")
                {
                    SqlCommand komut = new SqlCommand("insert into MalzemeCinsi(MalzemeCinsi,Açıklama)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')", baglantım.baglanti());

                    komut.ExecuteNonQuery();
                    MalzemeCinsi();

                }
                if (comboBox1.Text == "PROSES GRUBU" && textBox1.Text != "" && textBox2.Text != "")
                {
                    SqlCommand komut = new SqlCommand("insert into ProsesGrubu(ProsesGrubu,Açıklama)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')", baglantım.baglanti());

                    komut.ExecuteNonQuery();
                    ProsesGrubu();


                }
                MessageBox.Show("KAYDEDİLDİ");
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.Text = "Seçiniz..";

            }
            else if (comboBox1.Text == "" && textBox1.Text == "" && textBox2.Text == "")
            {

                MessageBox.Show("BOOOOŞŞŞŞŞ");

            }
            else
                MessageBox.Show("KAYIT GERÇEKLEŞTİRİLEMEDİ ! LÜTFEN BOŞ SATIRLARI DOLDURUNUZ");
        }
        //TEMİZLE BUTONU
        private void simpleButton3_Click(object sender, EventArgs e)
        {

            temizle();

        }
        public void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "Seçiniz..";
        }
        //listeleme  AltGrup();   Grup();   MalzmeCinsi();  ProsesGrubu(); şeklinde yazmalıyız kullanıcağımız yerde
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


        //GÜNCELLE BUTONU
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            {

                if (comboBox1.Text != "Seçiniz.." && textBox1.Text != "" && textBox2.Text != "")
                {


                    if (comboBox1.Text == "ALT GRUP" && textBox1.Text != "" && textBox2.Text != "")
                    {
                        SqlCommand guncellekomutu = new SqlCommand("update AltGrup set AltGrup=@AltGrup, Açıklama=@Açıklama where ID=@ID", baglantım.baglanti());

                        guncellekomutu.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox3.Text));
                        guncellekomutu.Parameters.Add("@AltGrup", SqlDbType.NVarChar, 50).Value = textBox1.Text;
                        guncellekomutu.Parameters.Add("@Açıklama", SqlDbType.NVarChar, 200).Value = textBox2.Text;

                        guncellekomutu.ExecuteNonQuery();
                        MessageBox.Show("Başarılı bir şekilde güncellenmiştir.", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//ilk tırnak içi mesaj içeriği ikinci tırnak içi mesaj kutusunun başlığıdır.

                        textBox1.Clear();
                        textBox2.Clear();
                        comboBox1.Text = "Seçiniz..";
                        AltGrup();

                    }


                    if (comboBox1.Text == "GRUP" && textBox1.Text != "" && textBox2.Text != "")
                    {
                        SqlCommand guncellekomutu1 = new SqlCommand("update Grup set Grup=@Grup, Açıklama=@Açıklama where ID=@ID", baglantım.baglanti());

                        guncellekomutu1.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox4.Text));
                        guncellekomutu1.Parameters.Add("@Grup", SqlDbType.NVarChar, 50).Value = textBox1.Text;
                        guncellekomutu1.Parameters.Add("@Açıklama", SqlDbType.NVarChar, 200).Value = textBox2.Text;

                        guncellekomutu1.ExecuteNonQuery();
                        MessageBox.Show("Başarılı bir şekilde güncellenmiştir.", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//ilk tırnak içi mesaj içeriği ikinci tırnak içi mesaj kutusunun başlığıdır.

                        temizle();
                    }

                    if (comboBox1.Text == "MALZEME CİNSİ" && textBox1.Text != "" && textBox2.Text != "")
                    {
                        SqlCommand guncellekomutu2 = new SqlCommand("update MalzemeCinsi set MalzemeCinsi=@MalzemeCinsi, Açıklama=@Açıklama where ID=@ID", baglantım.baglanti());

                        guncellekomutu2.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox5.Text));
                        guncellekomutu2.Parameters.Add("@MalzemeCinsi", SqlDbType.NVarChar, 50).Value = textBox1.Text;
                        guncellekomutu2.Parameters.Add("@Açıklama", SqlDbType.NVarChar, 200).Value = textBox2.Text;

                        guncellekomutu2.ExecuteNonQuery();
                        MessageBox.Show("Başarılı bir şekilde güncellenmiştir.", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//ilk tırnak içi mesaj içeriği ikinci tırnak içi mesaj kutusunun başlığıdır.

                        textBox1.Clear();
                        textBox2.Clear();
                        comboBox1.Text = "Seçiniz..";

                        MalzemeCinsi();

                    }
                    if (comboBox1.Text == "PROSES GRUBU" && textBox1.Text != "" && textBox2.Text != "")
                    {
                        SqlCommand guncellekomutu3 = new SqlCommand("update ProsesGrubu set ProsesGrubu=@ProsesGrubu, Açıklama=@Açıklama where ID=@ID", baglantım.baglanti());

                        guncellekomutu3.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox5.Text));
                        guncellekomutu3.Parameters.Add("@ProsesGrubu", SqlDbType.NVarChar, 50).Value = textBox1.Text;
                        guncellekomutu3.Parameters.Add("@Açıklama", SqlDbType.NVarChar, 200).Value = textBox2.Text;

                        guncellekomutu3.ExecuteNonQuery();
                        MessageBox.Show("Başarılı bir şekilde güncellenmiştir.", "Optimak stok takip uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//ilk tırnak içi mesaj içeriği ikinci tırnak içi mesaj kutusunun başlığıdır.

                        temizle();
                        ProsesGrubu();


                    }
                    MessageBox.Show("KAYDEDİLDİ");
                    textBox1.Clear();
                    textBox2.Clear();
                    comboBox1.Text = "Seçiniz..";

                }
                else if (comboBox1.Text == "" && textBox1.Text == "" && textBox2.Text == "")
                {

                    MessageBox.Show("LÜTFEN BOŞLUKLARI DOLDURUNUZ [!]");

                }
                else
                    MessageBox.Show("KAYIT GERÇEKLEŞTİRİLEMEDİ ! LÜTFEN BOŞ SATIRLARI DOLDURUNUZ");
            }
        }
        //          gridviewde yazanı cift tıkla texboxa yazdırmak
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            comboBox1.Text = "ALT GRUP";
            textBox1.Text = gridView1.GetFocusedRowCellValue("AltGrup").ToString();
            textBox2.Text = gridView1.GetFocusedRowCellValue("Açıklama").ToString();
            textBox3.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textBox7.Text = "ALT GRUP";

        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            comboBox1.Text = "GRUP";
            textBox1.Text = gridView2.GetFocusedRowCellValue("Grup").ToString();
            textBox2.Text = gridView2.GetFocusedRowCellValue("Açıklama").ToString();
            textBox4.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
            textBox7.Text = "GRUP";
        }

        private void gridControl3_DoubleClick(object sender, EventArgs e)
        {
            comboBox1.Text = "MALZEME CİNSİ";
            textBox1.Text = gridView3.GetFocusedRowCellValue("MalzemeCinsi").ToString();
            textBox2.Text = gridView3.GetFocusedRowCellValue("Açıklama").ToString();
            textBox5.Text = gridView3.GetFocusedRowCellValue("ID").ToString();
            textBox7.Text = "MALZEME CİNSİ";
        }

        private void gridControl4_DoubleClick(object sender, EventArgs e)
        {
            comboBox1.Text = "PROSES GRUBU";
            textBox1.Text = gridView4.GetFocusedRowCellValue("ProsesGrubu").ToString();
            textBox2.Text = gridView4.GetFocusedRowCellValue("Açıklama").ToString();
            textBox6.Text = gridView4.GetFocusedRowCellValue("ID").ToString();
            textBox7.Text = "PROSES GRUBU";
        }






        //           SİLME (ID ÜZERİNDEN TIKLIYARAK SİLME İŞLEMİ YAPAR)
        int ID = 0;
        private void simpleButton4_Click(object sender, EventArgs e)
        {

            bool kayit_arama_durumu = false;

            SqlCommand secmeSorgusu = new SqlCommand("Select *from AltGrup where ID='" + textBox3.Text + "'", baglantım.baglanti());
            SqlDataReader kayitokuma = secmeSorgusu.ExecuteReader();
            while (kayitokuma.Read())
            {


                kayit_arama_durumu = true;
                SqlCommand silsorgusu = new SqlCommand("delete from AltGrup where ID='" + textBox3.Text + "'", baglantım.baglanti());

                silsorgusu.ExecuteNonQuery();
                MessageBox.Show("Stok kaydı başarılı bir şekilde silinmiştir.", "STOK KONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                baglantım.baglanti().Close();

                AltGrup();
                temizle();
                break;
            }
            {

                bool kayit_arama_durumu1 = false;

                SqlCommand secmeSorgusu1 = new SqlCommand("Select *from Grup where ID='" + textBox4.Text + "'", baglantım.baglanti());
                SqlDataReader kayitokuma1 = secmeSorgusu1.ExecuteReader();
                while (kayitokuma1.Read())
                {


                    kayit_arama_durumu1 = true;
                    SqlCommand silsorgusu = new SqlCommand("delete from Grup where ID='" + textBox4.Text + "'", baglantım.baglanti());

                    silsorgusu.ExecuteNonQuery();
                    MessageBox.Show("Stok kaydı başarılı bir şekilde silinmiştir.", "STOK KONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    baglantım.baglanti().Close();

                    Grup();
                    temizle();
                    break;

                }
                {

                    bool kayit_arama_durumu2 = false;

                    SqlCommand secmeSorgusu2 = new SqlCommand("Select *from MalzemeCinsi where ID='" + textBox5.Text + "'", baglantım.baglanti());
                    SqlDataReader kayitokuma2 = secmeSorgusu2.ExecuteReader();
                    while (kayitokuma2.Read())
                    {


                        kayit_arama_durumu2 = true;
                        SqlCommand silsorgusu2 = new SqlCommand("delete from MalzemeCinsi where ID='" + textBox5.Text + "'", baglantım.baglanti());

                        silsorgusu2.ExecuteNonQuery();
                        MessageBox.Show("Stok kaydı başarılı bir şekilde silinmiştir.", "STOK KONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        baglantım.baglanti().Close();

                        MalzemeCinsi();
                        temizle();
                        break;

                    }
                    {

                        bool kayit_arama_durumu3 = false;

                        SqlCommand secmeSorgusu3 = new SqlCommand("Select *from ProsesGrubu where ID='" + textBox6.Text + "'", baglantım.baglanti());
                        SqlDataReader kayitokuma3 = secmeSorgusu3.ExecuteReader();
                        while (kayitokuma3.Read())
                        {


                            kayit_arama_durumu3 = true;
                            SqlCommand silsorgusu3 = new SqlCommand("delete from ProsesGrubu where ID='" + textBox6.Text + "'", baglantım.baglanti());

                            silsorgusu3.ExecuteNonQuery();
                            MessageBox.Show("Stok kaydı başarılı bir şekilde silinmiştir.", "STOK KONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            baglantım.baglanti().Close();

                            ProsesGrubu();
                            temizle();
                            break;

                        }
                    }
                }
            }
        }
    }

}

