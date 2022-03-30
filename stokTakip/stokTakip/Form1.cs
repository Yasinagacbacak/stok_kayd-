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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime saatgiris = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime saatcikis = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan sonuc = saatcikis - saatgiris;
            textBox1.Text = sonuc.TotalMinutes.ToString();
            // label1.Text=textBox1.Text*textBox2.Text
            //textBox2.Text = textBox1.Text;
            
            
        }
    }
}
