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
    }
}
