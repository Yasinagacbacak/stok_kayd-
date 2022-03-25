using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stokTakip
{
    public partial class ekran_depo : Form
    {
        public ekran_depo()
        {
            InitializeComponent();
        }
        public string t;
        static public string kullanıcıadi;


        //ekrandaki butona tıklandığında formu açar
        stokKaydi frm2;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new stokKaydi();
                frm2.MdiParent = this;
                frm2.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm2];
            }
        }
        ayarlar frm3;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new ayarlar();
                frm3.MdiParent = this;
                frm3.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm3];
            }
        }
        StokTalepleri frm4;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new StokTalepleri();
                frm4.MdiParent = this;
                frm4.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm4];
            }

        }

        private void ekran_malkabul_Load(object sender, EventArgs e)
        {
            label1.Text = kullanıcıadi;
        }
        urunCikisi frm5;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm4.IsDisposed)
            {
                frm5 = new urunCikisi();
                frm5.MdiParent = this;
                frm5.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm5];
            }
        }

        Tedarikçiler frm7;

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new Tedarikçiler();
                frm7.MdiParent = this;
                frm7.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm7];
            }
        }
    }
}
