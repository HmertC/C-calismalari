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

namespace Okul.Maas
{
    public partial class maas : Form
    {
        public string ServerAdress = @"DESKTOP-C0V3RSM\SQLEXPRESS";
        public string DataBaseName = "Okul";
        public SqlConnection kopru = new SqlConnection();

        public maas()
        {
            InitializeComponent();
        }

        private void maas_Load(object sender, EventArgs e)
        {
            //Bu alan Tablo Açıldığı an var olan bilgiler grid içine listelenecektir        
            this.maasTableAdapter.Fill(this.okulDataSet1.Maas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 0;
            int sayi2 = 67;
            int sonuc = 0;
            int sonuc2 = 0;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sonuc = (sayi1 * sayi2)/100 ;
            textBox2.Text = sonuc.ToString();
            sonuc2 = (sayi1 - sonuc);
            textBox3.Text = sonuc2.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Yeni veri girildiği zaman sql e kayıt atanacak
            string Kaydet = "Insert Into Maas (MaasToplam,MaasOde,MaasKalan) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString()+ "')";
            string mesaj = yardim.crud(Kaydet, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void Listele()
        {
            kopru = yardim.baglan(ServerAdress, DataBaseName);
            string maasSorgu = "Select MaasID,MaasToplam,MaasOde,MaasKalan from Maas";
            DataTable DtMaas = yardim.verioku(kopru, maasSorgu);

            if (DtMaas.Rows.Count > 0)
            {
                dataGridView1.DataSource = DtMaas;
            }
            else
            {
                MessageBox.Show("Kayıtlı Maaş Yok");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sil = "Delete Maas where MaasID =" + label4.Text;
            string mesaj = yardim.crud(sil, ServerAdress, DataBaseName);
            MessageBox.Show(mesaj);
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Upmaas = "Update Maas SET MaasToplam ='" + textBox1.Text + "', MaasOde ='" + textBox2.Text + "', MaasKalan = '" + textBox3.Text + "'";
            Upmaas += "where MaasID =" + label4.Text;
            string mesaj = yardim.crud(Upmaas, ServerAdress, DataBaseName);
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
