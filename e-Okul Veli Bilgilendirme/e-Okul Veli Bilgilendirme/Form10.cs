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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\eokul.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                OleDbCommand kaydet = new OleDbCommand("insert into ogretmenler (KullaniciAdi,sifre,Adi,sadi) values('"
                   + textBox1.Text + "','" + textBox2.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "')", baglan);
                baglan.Open();
                kaydet.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarı İle Eklendi");

                this.Visible = false;    // first set the visibility of form1 to false
                Form3 f2 = new Form3();
                f2.ShowDialog();    // don't use f2.show();
                this.Close();
            
            }
        }


    }
}
