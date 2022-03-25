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
    public partial class ekran : Form
    {
        public ekran()
        {
            InitializeComponent();
        }

        depoGoruntule frm1;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new depoGoruntule();
                frm1.MdiParent = this;
                frm1.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm1];
            }
        }
        stokKaydi frm2;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
        private void barButtonitem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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

        }
        Hesap_olustur frm5;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                if (frm5 == null || frm5.IsDisposed)
                {
                    frm5 = new Hesap_olustur();
                    frm5.MdiParent = this;
                    frm5.Show();
                }
                else
                {
                    xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm5];
                }
            }
        }
        urunCikisi frm6;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new urunCikisi();
                frm6.MdiParent = this;
                frm6.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[frm6];
            }
        }
        Tedarikçiler frm7;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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