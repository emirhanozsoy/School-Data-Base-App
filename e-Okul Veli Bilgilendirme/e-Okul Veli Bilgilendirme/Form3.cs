using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e_Okul_Veli_Bilgilendirme
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static public string kullanici;
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "admin") && (textBox3.Text == "123"))
            {
                kullanici = textBox2.Text;
                this.Visible = false;
                Form10 f2 = new Form10();
                f2.ShowDialog();
                this.Close();
            }
            if (label1.Text == textBox1.Text)
            {
                kullanici = textBox2.Text;
                this.Visible = false;    
                Form4 f2 = new Form4();
                f2.ShowDialog();  
                this.Close();
            }
      
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {

            Random next = new Random();
            label1.Text = (next.Next(9)).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanıcı Adı: Admin, Şifre:123");
        }



    }
}
