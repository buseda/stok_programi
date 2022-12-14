using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace stok_programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");
        public OleDbConnection bag1 = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");
        public DataTable tablo = new DataTable();
        public DataTable tablo1 = new DataTable();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public OleDbCommand kmt = new OleDbCommand();
        int id;

        public void listele()
        {
            tablo.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select id,stokAdi,stokModeli,stokSeriNo,stokAdedi,stokTarih,kayitYapan,urunYeri From stokbil", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            bag.Close();
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //datagridview1'deki tüm satırı seç
                dataGridView1.Columns[0].HeaderText = "KAYIT NO";
                dataGridView1.Columns[1].HeaderText = "STOK ADI";
                //sütunlardaki textleri değiştirme
                dataGridView1.Columns[2].HeaderText = "STOK MODELİ";
                dataGridView1.Columns[3].HeaderText = "STOK SERİNO";
                dataGridView1.Columns[4].HeaderText = "STOK ADEDİ";
                dataGridView1.Columns[5].HeaderText = "STOK TARİH";
                dataGridView1.Columns[6].HeaderText = "KAYIT YAPAN";
                dataGridView1.Columns[7].HeaderText = "ÜRÜN YERİ";
                dataGridView1.Columns[0].Width = 120;
                //sütunların genişliğini belirleme
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[3].Width = 80;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 120;
                dataGridView1.Columns[6].Width = 100;
                dataGridView1.Columns[7].Width = 120;
            }
            catch 
            {
             
            }  
        }

        public void arası()
        {
            tablo1.Clear();
            bag1.Open();
            OleDbDataAdapter adtr1 = new OleDbDataAdapter("select urunId, id, personelAdi, alinanUrun, urunModeli, stokSeriNo, stokAdedi From personel", bag1);
            adtr1.Fill(tablo1);
            dataGridView2.DataSource = tablo1;
            adtr1.Dispose();
            bag1.Close();
            try
            {
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //datagridview2'deki tüm satırı seç
                dataGridView2.Columns[0].HeaderText = "KAYIT NO";
                dataGridView2.Columns[1].HeaderText = "PERSONEL ID";
                dataGridView2.Columns[2].HeaderText = "PERSONEL ADI";
                //sütunlardaki textleri değiştirme
                dataGridView2.Columns[3].HeaderText = "ALINAN ÜRÜN";
                dataGridView2.Columns[4].HeaderText = "ÜRÜN MODELİ";
                dataGridView2.Columns[5].HeaderText = "SERİ NO";
                dataGridView2.Columns[6].HeaderText = "STOK ADEDİ";
                dataGridView2.Columns[0].Width = 120;
                //sütunların genişliğini belirleme
                dataGridView2.Columns[1].Width = 120;
                dataGridView2.Columns[2].Width = 120;
                dataGridView2.Columns[3].Width = 120;
                dataGridView2.Columns[4].Width = 120;
                dataGridView2.Columns[5].Width = 120;
                dataGridView2.Columns[6].Width = 120;
            }
            catch
            {

            }
        }

        public void listele2()
        {
            tablo1.Clear();
            bag.Open();
            OleDbDataAdapter adtr1 = new OleDbDataAdapter("select urunId, id, personelAdi, alinanUrun, urunModeli, stokSeriNo, stokAdedi From personel", bag);
            adtr1.Fill(tablo1);
            dataGridView2.DataSource = tablo1;
            adtr1.Dispose();
            bag.Close();
            try
            {
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //datagridview2'deki tüm satırı seç
                dataGridView2.Columns[0].HeaderText = "KAYIT NO";
                dataGridView2.Columns[1].HeaderText = "PERSONEL ID";
                dataGridView2.Columns[2].HeaderText = "PERSONEL ADI";
                //sütunlardaki textleri değiştirme
                dataGridView2.Columns[3].HeaderText = "ALINAN ÜRÜN";
                dataGridView2.Columns[4].HeaderText = "ÜRÜN MODELİ";
                dataGridView2.Columns[5].HeaderText = "SERİ NO";
                dataGridView2.Columns[6].HeaderText = "STOK ADEDİ";
                dataGridView2.Columns[0].Width = 120;
                //sütunların genişliğini belirleme
                dataGridView2.Columns[1].Width = 120;
                dataGridView2.Columns[2].Width = 120;
                dataGridView2.Columns[3].Width = 120;
                dataGridView2.Columns[4].Width = 120;
                dataGridView2.Columns[5].Width = 120;
                dataGridView2.Columns[6].Width = 120;
            }
            catch
            {

            }
        }

        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox17.Clear();
        }

        public void clear1()
        {
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            listele2();
        }
        
        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == "") errorProvider1.SetError(textBox1, "Boş geçilmez");
                else errorProvider1.SetError(textBox1, "");
                if (textBox2.Text.Trim() == "") errorProvider1.SetError(textBox2, "Boş geçilmez");
                else errorProvider1.SetError(textBox2, "");
                if (textBox3.Text.Trim() == "") errorProvider1.SetError(textBox3, "Boş geçilmez");
                else errorProvider1.SetError(textBox3, "");
                if (textBox4.Text.Trim() == "") errorProvider1.SetError(textBox4, "Boş geçilmez");
                else errorProvider1.SetError(textBox4, "");
                if (textBox5.Text.Trim() == "") errorProvider1.SetError(textBox5, "Boş geçilmez");
                else errorProvider1.SetError(textBox5, "");
                if (textBox9.Text.Trim() == "") errorProvider1.SetError(textBox9, "Boş geçilmez");
                else errorProvider1.SetError(textBox9, "");
                if (textBox8.Text.Trim() == "") errorProvider1.SetError(textBox8, "Boş geçilmez");
                else errorProvider1.SetError(textBox8, "");

                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox5.Text.Trim() != "")
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "INSERT INTO stokbil(stokAdi,stokModeli,stokSeriNo,stokAdedi,stokTarih,kayitYapan,urunYeri) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox8.Text + "','" + textBox5.Text  + "','" + textBox9.Text  + "') ";
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
                    }
                    listele();
                    clear();
                }
              
            }
            catch 
            {
                MessageBox.Show("Kayıtlı Seri No !");
                bag.Close();           
            }           
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox17.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


            try
           {
                kmt = new OleDbCommand("select * from stokbil where stokSeriNo='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'", bag);
                bag.Open();
                OleDbDataReader oku = kmt.ExecuteReader();
                oku.Read();
                if (oku.HasRows)
                {
                    id=Convert.ToInt32(oku[0].ToString());
                }
                bag.Close();
           }
            catch
           {
                bag.Close();
           }
        }

        private void btnStokSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes && dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim() != "")
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "DELETE from stokbil WHERE id = " + Convert.ToInt32(textBox17.Text); 
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                    listele();
                    clear();
                    clear1();
                }
            }
            catch
            {
             
            }
        }

        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox5.Text.Trim() != "")
                {
                    string sorgu = "UPDATE stokbil SET stokAdi='" + textBox1.Text + "',stokModeli='" + textBox2.Text + "',stokSeriNo='" + textBox3.Text + "',stokAdedi='" + textBox4.Text + "',stokTarih='" + textBox8.Text + "',kayitYapan='" + textBox5.Text + "' ,urunYeri='" + textBox9.Text + "' WHERE id = "+ Convert.ToInt32(textBox17.Text);
                    OleDbCommand kmt = new OleDbCommand(sorgu,bag);
                    bag.Open();
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                    listele();
                    MessageBox.Show("Güncelleme İşlemi Tamamlandı !","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Boş Alan Bırakmayınız !");
                }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From stokbil", bag);
            if (textBox6.Text.Trim() == "")
            {
                tablo.Clear();
                kmt.Connection = bag;
                kmt.CommandText = "Select * from stokbil";
                adtr.SelectCommand = kmt;
                adtr.Fill(tablo);
            }
            if (Convert.ToBoolean(bag.State) == false)
            {
                bag.Open();
            }
            if (textBox6.Text.Trim() != "")
            {
                adtr.SelectCommand.CommandText = " Select * From stokbil" + " where(stokAdi like '%" + textBox6.Text + "%' )";
                tablo.Clear();
                adtr.Fill(tablo);
                bag.Close();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From stokbil", bag);
            if (textBox7.Text.Trim() == "")
            {
                tablo.Clear();
                kmt.Connection = bag;
                kmt.CommandText = "Select * from stokbil";
                adtr.SelectCommand = kmt;
                adtr.Fill(tablo);
            }
            if (Convert.ToBoolean(bag.State) == false)
            {
                bag.Open();
            }
            if (textBox7.Text.Trim() != "")
            {
                adtr.SelectCommand.CommandText = " Select * From stokbil" + " where(stokModeli like '%" + textBox7.Text + "%' )";
                tablo.Clear();
                adtr.Fill(tablo);
                bag.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                if (textBox10.Text.Trim() == "") errorProvider1.SetError(textBox10, "Boş geçilmez");
                else errorProvider1.SetError(textBox10, "");
                if (textBox11.Text.Trim() == "") errorProvider1.SetError(textBox11, "Boş geçilmez");
                else errorProvider1.SetError(textBox11, "");
                if (textBox12.Text.Trim() == "") errorProvider1.SetError(textBox12, "Boş geçilmez");
                else errorProvider1.SetError(textBox12, "");
                if (textBox13.Text.Trim() == "") errorProvider1.SetError(textBox13, "Boş geçilmez");
                else errorProvider1.SetError(textBox13, "");
                if (textBox14.Text.Trim() == "") errorProvider1.SetError(textBox14, "Boş geçilmez");
                else errorProvider1.SetError(textBox14, "");
                if (textBox15.Text.Trim() == "") errorProvider1.SetError(textBox15, "Boş geçilmez");
                else errorProvider1.SetError(textBox15, "");
                

                if (textBox10.Text.Trim() != "" && textBox11.Text.Trim() != "" && textBox12.Text.Trim() != "" && textBox13.Text.Trim() != "" && textBox14.Text.Trim() != "")
                {
                if (Convert.ToInt32(textBox14.Text) > Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value))
                {
                    MessageBox.Show("Stok adedi 0'dan az olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                     else
                     {
                          bag.Open();
                          kmt.Connection = bag;
                          kmt.CommandText = "INSERT INTO personel(id, personelAdi, alinanUrun, urunModeli, stokSeriNo, stokAdedi) VALUES ('" + Convert.ToInt32(textBox15.Text) + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + Convert.ToInt32(textBox13.Text) + "','" + Convert.ToInt32(textBox14.Text) + "')";
                          kmt.ExecuteNonQuery();
                          kmt.CommandText = "UPDATE stokbil SET stokAdedi = stokAdedi - " + Convert.ToInt32(textBox14.Text) + " WHERE stokAdedi = " + dataGridView1.CurrentRow.Cells[4].Value;
                          kmt.ExecuteNonQuery();
                          kmt.Dispose();
                          bag.Close();
                        for (int i = 0; i < this.Controls.Count; i++)
                        {
                           if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
                        }
                        listele2();
                        listele();
                        clear1();
                     }
                }          
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox16.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox15.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox10.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox11.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox12.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox13.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBox14.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes && textBox10.Text.Trim() != "" && textBox11.Text.Trim() != "" && textBox12.Text.Trim() != "" && textBox13.Text.Trim() != "" && textBox14.Text.Trim() != "" && textBox15.Text.Trim() != "")
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "DELETE from personel WHERE urunId = " + Convert.ToInt32(textBox16.Text);
                    kmt.ExecuteNonQuery();
                    kmt.CommandText = "UPDATE stokbil SET stokAdedi = stokAdedi + " + Convert.ToInt32(textBox14.Text) + " WHERE id = " + textBox17.Text;
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                    listele2();
                    listele();
                    clear1();
                }
                else if (cevap == DialogResult.No)
                {

                }
                else
                {
                    MessageBox.Show("Personel ve ürün bilgilerini eksiksiz giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox10.Text.Trim() != "" && textBox11.Text.Trim() != "" && textBox12.Text.Trim() != "" && textBox13.Text.Trim() != "" && textBox14.Text.Trim() != "" && textBox14.Text.Trim() != "")
            {
                string sorgu = "UPDATE personel SET id='" + textBox15.Text + "', personelAdi='" + textBox10.Text + "', alinanUrun='" + textBox11.Text + "',urunModeli='" + textBox12.Text + "',stokSeriNo='" + textBox13.Text + "',stokAdedi='" + textBox14.Text + "' WHERE urunId = " + Convert.ToInt32(textBox16.Text);
                OleDbCommand kmt = new OleDbCommand(sorgu, bag);
                bag.Open();
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                bag.Close();
                listele();
                listele2();
                MessageBox.Show("Güncelleme İşlemi Tamamlandı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız !");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}