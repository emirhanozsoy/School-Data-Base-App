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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\eokul.accdb");
        private void Form11_Load(object sender, EventArgs e)
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
            baglan.Close();
        }
        static public string tckimlik,ogrno;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (listView1.SelectedItems.Count > 0)
            {
                tckimlik = listView1.SelectedItems[0].SubItems[0].Text;
                ogrno = listView1.SelectedItems[0].SubItems[1].Text;
                this.Visible = false;    // first set the visibility of form1 to false
                Form5 f2 = new Form5();
                f2.ShowDialog();    // don't use f2.show();
                this.Close();
            }
        }
        }
    }

