using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Musteri_Giris
{
    public partial class Form1 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-C0V3RSM\\SQLEXPRESS;Initial Catalog=Müsteriler;Integrated Security=True");

        private void verilericagir()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand emir = new SqlCommand("Select MusteriID,MusteriAdi,MusteriSoyadi,Telefon,Mail from Musteri",baglan);
            SqlDataReader oku = emir.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem getir = new ListViewItem();
                getir.Text = oku["MusteriID"].ToString();
                getir.SubItems.Add(oku["MusteriAdi"].ToString());
                getir.SubItems.Add(oku["MusteriSoyadi"].ToString());
                getir.SubItems.Add(oku["Telefon"].ToString());
                getir.SubItems.Add(oku["Mail"].ToString());
                listView1.Items.Add(getir);
            }
            baglan.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilericagir();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand kayit = new SqlCommand("Insert into Musteri (MusteriAdi,MusteriSoyadi,Telefon,Mail) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", baglan);
            kayit.ExecuteNonQuery();
            baglan.Close();
            verilericagir();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            
        }
        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sil = new SqlCommand ("Delete from Musteri where MusteriID = (" + id+")",baglan);
            sil.ExecuteNonQuery();
            baglan.Close();
            verilericagir();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            label5.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id;
            baglan.Open();
            SqlCommand guncel = new SqlCommand("Update Musteri Set  MusteriAdi ='" + textBox1.Text + "', MusteriSoyadi = '" + textBox2.Text + "', Telefon = '" + textBox3.Text + "', Mail = '" + textBox4.Text+ "' where MusteriID = " + label5.Text + "", baglan);
            guncel.ExecuteNonQuery();
            baglan.Close();
            verilericagir();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
    } 
}
