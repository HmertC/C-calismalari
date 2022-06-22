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

namespace Hastane
{
    public partial class Doktor : Form
    {
        public string ServerAdress = @"DESKTOP-C0V3RSM\SQLEXPRESS";
        public string DataBaseName = "Okul";
        public SqlConnection kopru = new SqlConnection();

        public Doktor()
        {
            InitializeComponent();
        }

        private void Doktor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet.Doktor' table. You can move, or remove it, as needed.
            this.doktorTableAdapter.Fill(this.hastaneDataSet.Doktor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kayeg = "Insert Into Doktor (DoktorAdi,DoktorSoyadi,DoktorBolum) Values ('" +textBox1.Text + "','" + textBox2.Text+ "','" + textBox3.Text+"')";
            string mesaj = yardim.crud(kayeg, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void Listele()
        {
            kopru = yardim.baglan(ServerAdress, DataBaseName);
            string doktorsorgu = "Select [DoktorID],[DoktorAdi],[DoktorSoyadi],[DoktorBolum] from Doktor";
            DataTable Dtdr = yardim.verioku(kopru, doktorsorgu);
            if (Dtdr.Rows.Count > 0)
            {
                dataGridView1.DataSource = Dtdr;
            }
            else
            {
                MessageBox.Show("Kayıt Yok");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string silegit = "Delete Doktor where DoktorID = " + label4.Text.ToString();
            string mesaj = yardim.crud(silegit, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string upegit = "Update Doktor SET DoktorAdi = '" + textBox1.Text + "', DoktorSoyadi ='" + textBox2.Text + "', DoktorBolum ='" + textBox3.Text +"'";
            string mesaj = yardim.crud(upegit, ServerAdress, DataBaseName);
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
        }
    }
}
