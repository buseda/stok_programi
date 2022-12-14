using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace stok_programi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void kulad_Click(object sender, EventArgs e)
        {

        }
        
        private void giris_Click(object sender, EventArgs e)
        {
        
            Form1 form1gecis = new Form1();
            string kulad;
            string sifre;
            kulad = textBox1.Text;
            sifre = textBox2.Text;
            if (kulad == "admin" && sifre == "1234")
            {
       
                form1gecis.Show();
                this.Hide();
            }
            else
            {
                string message = "Kullanıcı Adı veya Şifreniz Yanlış!";
                MessageBox.Show(message);
            }





        }
    }
}
