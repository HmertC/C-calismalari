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
    public partial class Hasta : Form
    {
        public string ServerAdress = @"DESKTOP-C0V3RSM\SQLEXPRESS";
        public string DataBaseName = "Okul";
        public SqlConnection kopru = new SqlConnection();

        public Hasta()
        {
            InitializeComponent();
        }

        private void Hasta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet.Doktor' table. You can move, or remove it, as needed.
            this.doktorTableAdapter.Fill(this.hastaneDataSet.Doktor);
            // TODO: This line of code loads data into the 'hastaneDataSet1.Hasta' table. You can move, or remove it, as needed.
            this.hastaTableAdapter.Fill(this.hastaneDataSet1.Hasta);

        }
      
        private void Listele()
        {
            kopru = yardim.baglan(ServerAdress, DataBaseName);
            string hastasorgu = "Select [HastaID],[HastaAdi],[HastaSoyadi],[DoktorID] from Hasta";
            DataTable Dthas = yardim.verioku(kopru, hastasorgu);
            if (Dthas.Rows.Count > 0)
            {
                dataGridView1.DataSource = Dthas;
            }
            else
            {
                MessageBox.Show("Kayıt Yok");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string uphasta = "Update Hasta SET HastaAdi = '" + textBox1.Text + "', HastaSoyadi ='" + textBox2.Text + "', DoktorID ='" + comboBox1.Text.ToString() + "'";
            string mesaj = yardim.crud(uphasta, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int satir = dataGridView1.CurrentRow.Index;

            label4.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string kayhas = "Insert Into Hasta (HastaAdi,HastaSoyadi,DoktorID) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text.ToString() + "')";
            string mesaj = yardim.crud(kayhas, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string silhasta = "Delete Hasta where HastaID = " + label4.Text.ToString();
            string mesaj = yardim.crud(silhasta, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }
    }
   
}
