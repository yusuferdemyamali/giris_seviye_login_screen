using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginscreenodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sistem kayıt = new Sistem();
            kayıt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string kadi = textBox1.Text;
            string sifre = textBox2.Text;
            if (kadi == "admin" && sifre == "admin")

            {
                string mesaj = "Giriş Başarılı";
                string baslik = "Gir Hadi İçeri";
                MessageBox.Show(mesaj, baslik);
                Sistem frm1 = new Sistem();
                frm1.ShowDialog();
            }
            else
                MessageBox.Show("Bilgiler Yanlış");
            


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string sifre = textBox2.Text;
        }
    }
}
