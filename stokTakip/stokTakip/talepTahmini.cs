using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using System.Data.SqlClient;

namespace stokTakip
{
    public partial class talepTahmini : Form
    {
        public talepTahmini()
        {
            InitializeComponent();
        }
        sqlBaglantisi baglantim = new sqlBaglantisi();


        // STOKTAKİ TÜM KAYITLARDAN BU AYKİLERİN ORTALMASINI GÖSTERİR
        public void listele()
        {
            SqlCommand sorgu = new SqlCommand("select parcaStokAdi,avg(miktar) as 'ORTALAMA' from tbl_stokKarti where MONTH(tarih)=MONTH(GETDATE()) group by parcaStokAdi", baglantim.baglanti());

            SqlDataAdapter dak = new SqlDataAdapter(sorgu);
            DataTable dtk = new DataTable();
            dak.Fill(dtk);
            gridControl1.DataSource = dtk;




        }

        public void listele2()
        {

            SqlCommand sorgu1 = new SqlCommand("select parcaStokAdi,sum(miktar) as 'TOPLAM' from tbl_stokKarti where MONTH(tarih)=MONTH(GETDATE()) group by parcaStokAdi", baglantim.baglanti());

            SqlDataAdapter dak1 = new SqlDataAdapter(sorgu1);
            DataTable dtk1 = new DataTable();
            dak1.Fill(dtk1);
            gridControl2.DataSource = dtk1;


        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridControl2_Load(object sender, EventArgs e)
        {
            listele2();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // PDF EXCEL WORD FORMATINA CEVİRME

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|.xls|Excel (2010) (.xlsx)|.xlsx |RichText File (.rtf)|.rtf |Pdf File (.pdf)|.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControl1.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl1.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl1.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl1.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl1.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl1.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "Dosya açılamadı." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "Dosya kaydedilemedi." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {


                saveDialog.Filter = "Excel (2003)(.xls)|.xls|Excel (2010) (.xlsx)|.xlsx |RichText File (.rtf)|.rtf |Pdf File (.pdf)|.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControl2.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl2.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl2.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl2.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl2.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl2.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "Dosya açılamadı." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "Dosya kaydedilemedi." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }


}