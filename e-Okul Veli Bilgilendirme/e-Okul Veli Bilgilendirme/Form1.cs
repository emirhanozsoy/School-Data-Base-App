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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random next = new Random();
            label1.Text = (next.Next(9)).ToString();
        }
        static public double tckimlikno, ogrno;
        private void button1_Click(object sender, EventArgs e)
        {
            tckimlikno = double.Parse(textBox2.Text);
            ogrno = int.Parse(textBox3.Text);
           if (label1.Text == textBox1.Text)
            {
                Form2.ogrno = textBox3.Text;
                this.Visible = false;    // first set the visibility of form1 to false
                Form2 f2 = new Form2();
                f2.ShowDialog();    // don't use f2.show();
                this.Close();
            }
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Visible = false;    // first set the visibility of form1 to false
            Form3 f2 = new Form3();
            f2.ShowDialog();    // don't use f2.show();
            this.Close();
        }

    }
}
