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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\eokul.accdb");
        static public string ogrno;
        private void Form7_Load(object sender, EventArgs e)
        {
            textBox2.Text = ogrno;
            baglan.Open();
            OleDbCommand veri = new OleDbCommand("select * from dersler where ogrno=('" + ogrno + "')", baglan);
            veri.ExecuteNonQuery();
            OleDbDataReader oku = null;
            oku = veri.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem kayit = new ListViewItem(oku["ogrno"].ToString());
                kayit.SubItems.Add(oku["tckimlikno"].ToString());
                kayit.SubItems.Add(oku["dersadi"].ToString());
                kayit.SubItems.Add(oku["oadi"].ToString());
                kayit.SubItems.Add(oku["osadi"].ToString());
                kayit.SubItems.Add(oku["yazili1"].ToString());
                kayit.SubItems.Add(oku["yazili2"].ToString());
                kayit.SubItems.Add(oku["yazili3"].ToString());
                kayit.SubItems.Add(oku["sozlu1"].ToString());
                kayit.SubItems.Add(oku["sozlu2"].ToString());
                kayit.SubItems.Add(oku["ort"].ToString());

                kayit.SubItems.Add(oku["sonuc"].ToString());
                listView1.Items.Add(kayit);
            }
            oku.Close();


            OleDbCommand db_oku = new OleDbCommand("Select * from kimlik where ogrno=('" + ogrno + "')", baglan);
            OleDbDataReader Oku1 = null;
            Oku1 = db_oku.ExecuteReader();
            while (Oku1.Read())
            {
                textBox1.Text = Convert.ToString(Oku1["tckimlik"]);
                adi.Text = Convert.ToString(Oku1["adi"]);
                sadi.Text = Convert.ToString(Oku1["sadi"]);
                dyeri.Text = Convert.ToString(Oku1["dyeri"]);
                dtarihi.Text = Convert.ToString(Oku1["sinif"]);
                sinif.Text = Convert.ToString(Oku1["sinif"]);
                anaadi.Text = Convert.ToString(Oku1["anneadi"]);
                babaadi.Text = Convert.ToString(Oku1["babaadi"]);
                adres.Text = Convert.ToString(Oku1["adres"]);
                tel.Text = Convert.ToString(Oku1["tel"]);
                pictureBox1.ImageLocation = (Oku1["resim"].ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            }
            db_oku.Connection.Close();
            baglan.Close();
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
