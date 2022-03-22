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
    public partial class ekran_tasarım : Form
    {
        public ekran_tasarım()
        {
            InitializeComponent();
        }
        depoGoruntule form;
        public string t;
        GeriBildirim form1;

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (form == null || form.IsDisposed)
            {
                form = new depoGoruntule();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[form];
            }
        }

        private void ekran_tasarım_Load(object sender, EventArgs e)
        {
            Giris frms = new Giris();
            label1.Text = t.ToString();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (form1 == null || form1.IsDisposed)
            {
                form1 = new GeriBildirim();
                form1.MdiParent = this;
                form1.Show();
            }
            else
            {
                xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[form1];
            }
        }
    }
}
