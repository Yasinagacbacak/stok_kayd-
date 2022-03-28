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
         
            gridView1.Columns["marka"].Caption = "MARKA";

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



        private void gridControl1_Click(object sender, EventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        } 

        // gridview i boyar  rowstyleye gridiview in yıldırım işaretinde bulabilirsin

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            // GridView view = new GridView();
            if (gridView1.Columns.Count > 0)
            {
                if (e.RowHandle >= 0)
                {
                    //string kategori = view.GetRowCellDisplayText(e.RowHandle, view.Columns[5]);
                    string durum = gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns["durumu"]);
                    if (durum == "BEKLEMEDE")
                    {
                        e.Appearance.BackColor = Color.Yellow;
                       // e.Appearance.BackColor2 = Color.Yellow;
                    }
                    else if (durum == "RED")
                    {
                        e.Appearance.BackColor = Color.OrangeRed;
                        //e.Appearance.BackColor2 = Color.Yellow;
                    }
                    else if (durum == "KABUL")
                    {
                        e.Appearance.BackColor = Color.LightGreen;
                        //e.Appearance.BackColor2 = Color.Yellow;
                    }
                }
            }
        }

        private void StokTalepleri_Load(object sender, EventArgs e)
        {
            listele_talep();
        }

        private void StokTalepleri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                simpleButton1.PerformClick();
            }
        }
    }
}