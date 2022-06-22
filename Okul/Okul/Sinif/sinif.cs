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

namespace Okul.Sinif
{
    public partial class sinif : Form
    {
        public string ServerAdress = @"DESKTOP-C0V3RSM\SQLEXPRESS";
        public string DataBaseName = "Okul";
        public SqlConnection kopru = new SqlConnection();

        public sinif()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string UpdateSinif = "Update Siniflar SET SinifAdi = " + textBox1.Text;
            UpdateSinif += "where SinifID ='" + label2.Text;
            string mesaj = yardim.crud(UpdateSinif, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void Listele()
        {
            kopru = yardim.baglan(ServerAdress, DataBaseName);
            string Sinifsorgu = "Select SinifID,SinifAdi from Siniflar";
            DataTable DtSinif = yardim.verioku(kopru, Sinifsorgu);

            if (DtSinif.Rows.Count > 0)
            {
                dataGridView1.DataSource = DtSinif;
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }
        }

        private void sinif_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'okulDataSet2.Siniflar' table. You can move, or remove it, as needed.
            this.siniflarTableAdapter.Fill(this.okulDataSet2.Siniflar);           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SaveSinif = "Insert Into Siniflar (SinifAdi) Values (" + textBox1.Text+")";
            string mesaj = yardim.crud(SaveSinif, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SilSinif = "Delete Siniflar where SinifID =" + label2.Text.ToString();
            string mesaj = yardim.crud(SilSinif, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int satir = dataGridView1.CurrentRow.Index;

            label2.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
        }
    }
}
