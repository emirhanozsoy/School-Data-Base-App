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
namespace e_Okul_Veli_Bilgilendirme
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\eokul.accdb");
        int ort;
        string sonuc;
        private void dveri_oku()
        {
            OleDbCommand veri = new OleDbCommand("select * from kimlik", baglan);
            OleDbDataReader oku = null;
            baglan.Open();
            oku = veri.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                pictureBox1.ImageLocation = (oku["resim"].ToString());
                ListViewItem kayit = new ListViewItem(oku["tckimlik"].ToString());
                kayit.SubItems.Add(oku["ogrno"].ToString());
                kayit.SubItems.Add(oku["adi"].ToString());
                kayit.SubItems.Add(oku["sadi"].ToString());
                kayit.SubItems.Add(oku["dyeri"].ToString());
                kayit.SubItems.Add(oku["dtarihi"].ToString());
                kayit.SubItems.Add(oku["sinif"].ToString());
                kayit.SubItems.Add(oku["anneadi"].ToString());
                kayit.SubItems.Add(oku["babaadi"].ToString());
                kayit.SubItems.Add(oku["tel"].ToString());
                kayit.SubItems.Add(oku["adres"].ToString());
                kayit.SubItems.Add(oku["resim"].ToString());
                listView1.Items.Add(kayit);
            }
            oku.Close();

            OleDbCommand veri1 = new OleDbCommand("select * from dersler", baglan);
            OleDbDataReader oku1 = null;

            oku1 = veri1.ExecuteReader();
            listView2.Items.Clear();
            while (oku1.Read())
            {
                ListViewItem kayit = new ListViewItem(oku1["tckimlikno"].ToString());
                kayit.SubItems.Add(oku1["ogrno"].ToString());
                kayit.SubItems.Add(oku1["dersadi"].ToString());
                kayit.SubItems.Add(oku1["oadi"].ToString());
                kayit.SubItems.Add(oku1["osadi"].ToString());
                kayit.SubItems.Add(oku1["yazili1"].ToString());
                kayit.SubItems.Add(oku1["yazili2"].ToString());
                kayit.SubItems.Add(oku1["yazili3"].ToString());
                kayit.SubItems.Add(oku1["sozlu1"].ToString());
                kayit.SubItems.Add(oku1["sozlu2"].ToString());
                kayit.SubItems.Add(oku1["ort"].ToString());
                kayit.SubItems.Add(oku1["sonuc"].ToString());
                listView2.Items.Add(kayit);
            }
            oku1.Close();
            baglan.Close();

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            OleDbCommand veri = new OleDbCommand("select * from kimlik", baglan);
            OleDbDataReader oku = null;
            baglan.Open();
            oku = veri.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                
                ListViewItem kayit = new ListViewItem(oku["tckimlik"].ToString());
                kayit.SubItems.Add(oku["ogrno"].ToString());
                kayit.SubItems.Add(oku["adi"].ToString());
                kayit.SubItems.Add(oku["sadi"].ToString());
                kayit.SubItems.Add(oku["dyeri"].ToString());
                kayit.SubItems.Add(oku["dtarihi"].ToString());
                kayit.SubItems.Add(oku["sinif"].ToString());
                kayit.SubItems.Add(oku["anneadi"].ToString());
                kayit.SubItems.Add(oku["babaadi"].ToString());
                kayit.SubItems.Add(oku["tel"].ToString());
                kayit.SubItems.Add(oku["adres"].ToString());
                kayit.SubItems.Add(oku["resim"].ToString());
                listView1.Items.Add(kayit);
            }
            oku.Close();

            OleDbCommand veri1 = new OleDbCommand("select * from dersler", baglan);
            OleDbDataReader oku1 = null;

            oku1 = veri1.ExecuteReader();
            listView2.Items.Clear();
            while (oku1.Read())
            {
                ListViewItem kayit = new ListViewItem(oku1["tckimlikno"].ToString());
                kayit.SubItems.Add(oku1["ogrno"].ToString());
                kayit.SubItems.Add(oku1["dersadi"].ToString());
                kayit.SubItems.Add(oku1["oadi"].ToString());
                kayit.SubItems.Add(oku1["osadi"].ToString());
                kayit.SubItems.Add(oku1["yazili1"].ToString());
                kayit.SubItems.Add(oku1["yazili2"].ToString());
                kayit.SubItems.Add(oku1["yazili3"].ToString());
                kayit.SubItems.Add(oku1["sozlu1"].ToString());
                kayit.SubItems.Add(oku1["sozlu2"].ToString());
                kayit.SubItems.Add(oku1["ort"].ToString());
                kayit.SubItems.Add(oku1["sonuc"].ToString());
                listView2.Items.Add(kayit);
            }
            oku1.Close();
            baglan.Close();


        }


        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView2.SelectedItems.Count > 0)
            {
                tckimlik.Text = listView2.SelectedItems[0].SubItems[0].Text;
                textBox13.Text = listView2.SelectedItems[0].SubItems[1].Text;
                textBox1.Text = listView2.SelectedItems[0].SubItems[2].Text;
                textBox2.Text = listView2.SelectedItems[0].SubItems[3].Text;
                textBox3.Text = listView2.SelectedItems[0].SubItems[4].Text;
                textBox4.Text = listView2.SelectedItems[0].SubItems[5].Text;
                textBox5.Text = listView2.SelectedItems[0].SubItems[6].Text;
                textBox6.Text = listView2.SelectedItems[0].SubItems[7].Text;
                textBox7.Text = listView2.SelectedItems[0].SubItems[8].Text;
                textBox8.Text = listView2.SelectedItems[0].SubItems[9].Text;
                textBox9.Text = listView2.SelectedItems[0].SubItems[10].Text;
                textBox10.Text = listView2.SelectedItems[0].SubItems[11].Text;
            }
        }


        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox12.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox11.Text = listView1.SelectedItems[0].SubItems[1].Text;
                adi.Text = listView1.SelectedItems[0].SubItems[2].Text;
                sadi.Text = listView1.SelectedItems[0].SubItems[3].Text;
                dyeri.Text = listView1.SelectedItems[0].SubItems[4].Text;
                dtarihi.Text = listView1.SelectedItems[0].SubItems[5].Text;
                sinif.Text = listView1.SelectedItems[0].SubItems[6].Text;
                anaadi.Text = listView1.SelectedItems[0].SubItems[7].Text;
                babaadi.Text = listView1.SelectedItems[0].SubItems[8].Text;
                tel.Text = listView1.SelectedItems[0].SubItems[9].Text;
                adres.Text = listView1.SelectedItems[0].SubItems[10].Text;
                textBox14.Text = listView1.SelectedItems[0].SubItems[11].Text;
                pictureBox1.ImageLocation = listView1.SelectedItems[0].SubItems[11].Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        string DosyaYolu, DosyaAdi = "";
        private void button1_Click(object sender, EventArgs e)
        {
                foreach (string i in openFileDialog1.FileName.Split('\\'))
                {
                    if (i.Contains(".jpg")) { DosyaAdi = i; }
                    else { DosyaYolu += i + "\\"; }
                }
            
            File.WriteAllBytes(DosyaAdi, File.ReadAllBytes(openFileDialog1.FileName));
            OleDbCommand guncelle1 = new OleDbCommand("update kimlik set ogrno=('" + textBox11.Text + "'),adi=('" + adi.Text + "'),sadi=('" + sadi.Text + "'),dyeri=('" + dyeri.Text + "'),dtarihi=('" + dtarihi.Text + "'),sinif=('" + sinif.Text + "'),anneadi=('" + anaadi.Text + "'),babaadi=('" + babaadi.Text + "'),adres=('" + adres.Text + "'),tel=('" + tel.Text + "'),resim=('" + DosyaAdi + "') where Tckimlik=('" + textBox12.Text + "')", baglan);
            baglan.Open();
            guncelle1.ExecuteNonQuery();
            baglan.Close();
            dveri_oku();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                ort = (int.Parse(textBox4.Text) + int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text)) / 4;
                if (ort > 45)
                {
                    sonuc = "Geçti";
                    textBox10.Text = sonuc;

                }
                else
                {
                    sonuc = "Kaldı";
                    textBox10.Text = sonuc;
                }
                textBox9.Text = ort.ToString();
            }
            else
            {
                ort = (int.Parse(textBox4.Text) + int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text)) / 5;
                if (ort > 45)
                {
                    sonuc = "Geçti";
                    textBox10.Text = sonuc;

                }
                else
                {
                    sonuc = "Kaldı";
                    textBox10.Text = sonuc;
                }
                textBox9.Text = ort.ToString();
            }
            OleDbCommand guncelle = new OleDbCommand("update dersler set dersadi=('" + textBox1.Text + "'),oadi=('" + textBox2.Text + "'),osadi=('" + textBox3.Text + "'),yazili1=('" + textBox4.Text + "'),yazili2=('" + textBox5.Text + "'),yazili3=('" + textBox6.Text + "'),sozlu1=('" + textBox7.Text + "'),sozlu2=('" + textBox8.Text + "'),ort=('" + ort.ToString() + "') where tckimlikno=('" + tckimlik.Text + "')", baglan);
            baglan.Open();
            guncelle.ExecuteNonQuery();
            baglan.Close();
            dveri_oku();

        }
        string resim;
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Aç";
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resim = openFileDialog1.FileName.ToString();
            }
            /*openFileDialog1.ShowDialog();
            textBox14.Text = openFileDialog1.FileName;
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;    // first set the visibility of form1 to false
            Form4 f2 = new Form4();
            f2.ShowDialog();    // don't use f2.show();
            this.Close();
        }



    }
}

