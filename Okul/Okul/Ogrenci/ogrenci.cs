using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul.Ogrenci
{
    public partial class ogrenci : Form
    {
        public string ServerAdress = @"DESKTOP-C0V3RSM\SQLEXPRESS";
        public string DataBaseName = "Okul";
        public SqlConnection kopru = new SqlConnection();

        public ogrenci()
        {
            InitializeComponent();
        }

        private void ogrenci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'okulDataSet3.Egitmen' table. You can move, or remove it, as needed.
            this.egitmenTableAdapter.Fill(this.okulDataSet3.Egitmen);
            // TODO: This line of code loads data into the 'okulDataSet2.Siniflar' table. You can move, or remove it, as needed.
            this.siniflarTableAdapter.Fill(this.okulDataSet2.Siniflar);
            // TODO: This line of code loads data into the 'okulDataSet.Ogrenciler' table. You can move, or remove it, as needed.
            this.ogrencilerTableAdapter.Fill(this.okulDataSet.Ogrenciler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kayog = "Insert Into Ogrenciler (OgrenciTC,OgrenciAdi,OgrenciSoyadi,SinifID,EgitmenID) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + comboBox1.Text.ToString()+ "','" + comboBox2.Text.ToString()+ "')";
            string mesaj = yardim.crud(kayog, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void Listele()
        {
            kopru = yardim.baglan(ServerAdress, DataBaseName);
            string sorgu = "Select [OgrenciNo],[OgrenciTC],[OgrenciAdi],[OgrenciSoyadi],[SinifID],[EgitmenID] from Ogrenciler";
            DataTable Dtogrenc = yardim.verioku(kopru, sorgu);

            if (Dtogrenc.Rows.Count > 0)
            {
                dataGridView1.DataSource = Dtogrenc;
            }
            else
            {
                MessageBox.Show("Kayıt Yok ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Upogren = "Update Ogrenciler Set OgrenciTC =" + textBox1.Text + ", OgrenciAdi =" + textBox2.Text + ", OgrenciSoyadi =" + textBox3.Text + ", SinifID = '" + comboBox1.Text.ToString() + "',EgitmenID ='" + comboBox2.Text.ToString()+"'";
            string mesaj = yardim.crud(Upogren, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string delogren = "Delete Ogrenciler where OgrenciNo =" + label4.Text;
            string mesaj = yardim.crud(delogren, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int satir = dataGridView1.CurrentRow.Index;

            label4.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[satir].Cells[5].Value.ToString();
        }
    }
}
