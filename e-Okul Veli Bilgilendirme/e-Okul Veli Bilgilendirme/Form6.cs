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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        
        string DosyaYolu, DosyaAdi = "";
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\eokul.accdb");
        private void veri_kaydet()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string i in openFileDialog1.FileName.Split('\\'))
                {
                    if (i.Contains(".jpg")) { DosyaAdi = i; }
                    else { DosyaYolu += i + "\\"; }
                }
            }
                File.WriteAllBytes(DosyaAdi, File.ReadAllBytes(openFileDialog1.FileName));
            

                OleDbCommand kaydet = new OleDbCommand("insert into kimlik (Tckimlik,ogrno,adi,sadi,dyeri,dtarihi,sinif,anneadi,babaadi,tel,adres,resim) values('"
                    + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "', '" + textBox6.Text + "', '" +
                    textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "', '" + textBox11.Text + "', '" + DosyaAdi + "')", baglan);
                baglan.Open();
                kaydet.ExecuteNonQuery();
                baglan.Close();
                dveri_oku();
            

        }
        private void dveri_oku()
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
                listView1.Items.Add(kayit);
            }
            oku.Close();
            baglan.Close();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;    // first set the visibility of form1 to false
            Form5 f2 = new Form5();
            f2.ShowDialog();    // don't use f2.show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veri_kaydet();
        }

        private void Form6_Load(object sender, EventArgs e)
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
                listView1.Items.Add(kayit);
            }
            oku.Close();
            baglan.Close();
        }
        string resim;
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Aç";
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resim = openFileDialog1.FileName.ToString();
            }
            
            /*openFileDialog1.ShowDialog();
            textBox12.Text=openFileDialog1.FileName;
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            File.WriteAllBytes(textBox12.Text, File.ReadAllBytes(openFileDialog1.FileName));*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Sayısı "+listView1.Items.Count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;    // first set the visibility of form1 to false
            Form4 f2 = new Form4();
            f2.ShowDialog();    // don't use f2.show();
            this.Close();
        }

        }
 }

