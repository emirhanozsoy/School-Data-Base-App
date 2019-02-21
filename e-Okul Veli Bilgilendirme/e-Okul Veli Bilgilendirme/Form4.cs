using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace e_Okul_Veli_Bilgilendirme
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\eokul.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;    // first set the visibility of form1 to false
            Form6 f2 = new Form6();
            f2.ShowDialog();    // don't use f2.show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;    // first set the visibility of form1 to false
            Form11 f2 = new Form11();
            f2.ShowDialog();    // don't use f2.show();
            this.Close();
        }
        static public string adi, sadi;
        private void Form4_Load(object sender, EventArgs e)
        {
            
            OleDbCommand db_oku = new OleDbCommand("Select * from ogretmenler where kullaniciAdi =('" + Form3.kullanici + "') ", baglan);
            baglan.Open();
            OleDbDataReader Oku1;
            Oku1 = db_oku.ExecuteReader();
            while (Oku1.Read())
            {
                notifyIcon1.ShowBalloonTip(250, "Öğretmen Girişi Yapıldı", " Hoşgeldin " + Convert.ToString(Oku1["adi"])+ " " + Convert.ToString(Oku1["sadi"]), ToolTipIcon.Info);
                textBox1.Text= Convert.ToString(Oku1["adi"]);
                textBox2.Text = Convert.ToString(Oku1["sadi"]);
            }
            db_oku.Connection.Close();
            baglan.Close();
            adi = textBox1.Text;
            sadi = textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          Form7.ogrno = string.Format(Microsoft.VisualBasic.Interaction.InputBox("Bulmak İstediğiniz Öğrencinin Numarasını Giriniz"));
          this.Visible = false;    // first set the visibility of form1 to false
          Form7 f2 = new Form7();
          f2.ShowDialog();    // don't use f2.show();
          this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string a = string.Format(Microsoft.VisualBasic.Interaction.InputBox("Silmek İstediğiniz Öğrencinin Numarasını Giriniz"));

                OleDbCommand sil = new OleDbCommand("delete from kimlik where ogrno =('" + a + "')", baglan);
                baglan.Open();
                sil.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Veri Başarı İle Silindi");
            }
            catch
            {MessageBox.Show("Hata Oluştu Girdiğiniz Veriyi Kontrol Ediniz."); }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string a = string.Format(Microsoft.VisualBasic.Interaction.InputBox("Notunu Silmek istediğiniz Dersin Adını Giriniz"));
                OleDbCommand sil = new OleDbCommand("delete from dersler where dersadi =('" + a + "')", baglan);
                baglan.Open();
                sil.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Veri Başarı İle Silindi");

            }
            catch
            { MessageBox.Show("Hata Oluştu Girdiğiniz Veriyi Kontrol Ediniz."); }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;    // first set the visibility of form1 to false
            Form8 f2 = new Form8();
            f2.ShowDialog();    // don't use f2.show();
            this.Close();
        }
    }
}
