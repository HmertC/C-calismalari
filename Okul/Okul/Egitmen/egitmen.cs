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

namespace Okul.Egitmen
{
    public partial class egitmen : Form
    {
        public string ServerAdress = @"DESKTOP-C0V3RSM\SQLEXPRESS";
        public string DataBaseName = "Okul";
        public SqlConnection kopru = new SqlConnection();

        public egitmen()
        {
            InitializeComponent();
        }

        private void egitmen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'okulDataSet2.Siniflar' table. You can move, or remove it, as needed.
            this.siniflarTableAdapter.Fill(this.okulDataSet2.Siniflar);
            // TODO: This line of code loads data into the 'okulDataSet1.Maas' table. You can move, or remove it, as needed.
            this.maasTableAdapter.Fill(this.okulDataSet1.Maas);
            // TODO: This line of code loads data into the 'okulDataSet3.Egitmen' table. You can move, or remove it, as needed.
            this.egitmenTableAdapter.Fill(this.okulDataSet3.Egitmen);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kayeg = "Insert Into Egitmen (EgitmenTC,EgitmenAdi,EgitmenSoyadi,Telefon,MaasID,SinifID) Values ('" + textBox1.Text + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString()+ "','"+textBox4.Text+"','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "')";
            string mesaj = yardim.crud(kayeg, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void Listele()
        {
            kopru = yardim.baglan(ServerAdress, DataBaseName);
            string egitsorgu = "Select [EgitmenID],[EgitmenTC],[EgitmenAdi],[EgitmenSoyadi],[Telefon],[MaasID],[SinifID] from Egitmen";
            DataTable DtEgit = yardim.verioku(kopru, egitsorgu);
            if (DtEgit.Rows.Count > 0)
            {
                dataGridView1.DataSource = DtEgit;
            }
            else
            {
                MessageBox.Show("Kayıt Yok");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string upegit = "Update Egitmen SET EgitmenTC = " + textBox1.Text + ", EgitmenAdi =" +textBox2.Text + ", EgitmenSoyadi =" + textBox3.Text + ", Telefon =" + textBox4.Text + ", MaasID = '" + comboBox1.Text + "', SinifID ='" + comboBox2.Text + "'";
            string mesaj = yardim.crud(upegit, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string silegit = "Delete Egitmen where EgitmenID = " + label7.Text.ToString();
            string mesaj = yardim.crud(silegit, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int satir = dataGridView1.CurrentRow.Index;

            label7.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[satir].Cells[5].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[satir].Cells[6].Value.ToString();
        }
    }
}
