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
using System.IO;



namespace stokTakip
{
    public partial class StokTalepleri : Form
    {
        public StokTalepleri()
        {
            InitializeComponent();
        }
        sqlBaglantisi baglantim = new sqlBaglantisi();


        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;

        //listele
        public void listele_talep()
        {
            SqlCommand sorgu = new SqlCommand("select * from StokTalebi", baglantim.baglanti());


            SqlDataAdapter dak = new SqlDataAdapter(sorgu);
            DataTable dtk = new DataTable();
            dak.Fill(dtk);
            gridControl1.DataSource = dtk;
            gridView1.Columns["ID"].Visible = false;

            gridView1.Columns["stokAdi"].Caption = "PARÇA STOK ADI";
            gridView1.Columns["projeAdi"].Caption = "PROJE ADI";
            gridView1.Columns["ihtiyac"].Caption = "İHTİYAÇ";
            gridView1.Columns["talepEden"].Caption = "TALEP EDEN";
            gridView1.Columns["durumu"].Caption = "DURUMU";

            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            listele_talep();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Talep_onay_red yeni = new Talep_onay_red();
            yeni.d = gridView1.GetFocusedRowCellValue("durumu").ToString();

            yeni.y = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            yeni.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listele_talep();
        }
        //        gridview i BOYAR
        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {


        }
        // ID YE GÖRE TEK TIKLA VERİTABANINDAN SİLME
        private void simpleButton2_Click(object sender, EventArgs e)
        {

            
            listele_talep();
            if (txt_id.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz satırı tekrar seçiniz");
            }
            else
            {
              //  txt_id.Text = gridView1.GetFocusedRowCellValue("ID").ToString();

                SqlCommand silsorgusu = new SqlCommand("delete from StokTalebi where ID='" + txt_id.Text + "'", baglantim.baglanti());

                silsorgusu.ExecuteNonQuery();
                MessageBox.Show("Stok kaydı başarılı bir şekilde silinmiştir.", "STOK KONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                baglantim.baglanti().Close();
                txt_id.Text = "";
            }
            
            listele_talep();
        }

        //void KayıtSil(int ID)
        //{
        //    string sql = "DELETE FROM StokTalebi WHERE ID=@ID";
        //    komut = new SqlCommand(sql, con);
        //    komut.Parameters.AddWithValue("@ID", ID);
        //    con.Open();
        //    komut.ExecuteNonQuery();
        //    con.Close();
        //}

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }
    }
}