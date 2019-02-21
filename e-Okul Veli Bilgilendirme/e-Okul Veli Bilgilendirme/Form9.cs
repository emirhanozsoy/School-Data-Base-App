using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace e_Okul_Veli_Bilgilendirme
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void Form9_Load(object sender, EventArgs e)
        {
           
            timer1.Start();
            pictureBox1.Image = Image.FromFile("signbot.gif");
            SoundPlayer player = new SoundPlayer();
            string path = "Game Of Thrones _Official_ Show Open (HBO)_3.wav"; // Müzik adresi
            player.SoundLocation = path;
            player.Play(); //play i
            
            
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
           

            
            progressBar1.Increment(5);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Visible = false;    // first set the visibility of form1 to false
                Form1 f2 = new Form1();
                f2.ShowDialog();    // don't use f2.show();
                this.Close();
           
            }
           

        }
        /*string a = " Bu program Emirhan Özsoy Tarafından Yapılmıştır. Tüm Hakları Emirhan Özsoy'a aittir.               ";
        private void timer2_Tick(object sender, EventArgs e)
        {
            a = a.Substring(1) + a.Substring(0, 1);
            label1.Text = a;
        }*/

    

       
    }
}
