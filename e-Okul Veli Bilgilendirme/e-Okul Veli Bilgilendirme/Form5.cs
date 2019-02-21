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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\eokul.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            int ort = ((int.Parse(textBox4.Text)) + (int.Parse(textBox5.Text)) + (int.Parse(textBox6.Text)) + (int.Parse(textBox7.Text)) + (int.Parse(textBox7.Text))) / 5;
            if (ort > 45)
            {
                textBox10.Text = "Geçti";
            }
            else
            {
                textBox10.Text = "Kaldı";
            }
            baglan.Open();
            OleDbCommand kom = new OleDbCommand("INSERT INTO dersler (tckimlikno,dersadi,oadi,osadi,yazili1,yazili2,yazili3,sozlu1,sozlu2,ort,sonuc,ogrno) Values('" +
                textBox12.Text + "','" + textBox3.Text + "','" + textBox11.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + ort + "','" + textBox10.Text + "','" + textBox13.Text + "')", baglan);
            kom.ExecuteNonQuery();
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ort = ((int.Parse(textBox4.Text)) + (int.Parse(textBox5.Text)) + (int.Parse(textBox6.Text)) + (int.Parse(textBox7.Text)) + (int.Parse(textBox7.Text))) / 5;
            textBox9.Text = ort.ToString();
            if (ort > 45)
            {
                textBox10.Text = "Geçti";
            }
            else
            {
                textBox10.Text = "Kaldı";
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox12.Text = Form11.tckimlik;
            textBox13.Text = Form11.ogrno;
            textBox11.Text = Form4.adi;
            textBox1.Text = Form4.sadi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;    // first set the visibility of form1 to false
            Form4 f2 = new Form4();
            f2.ShowDialog();    // don't use f2.show();
            this.Close();
        }

      
    }
}
