using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="HMertC" && textBox2.Text == "1234")
            {
                Form2 giris = new Form2();
                giris.Show();
                this.Hide();
            }
            if (textBox1.Text == "HMertC" && textBox2.Text != "1234")
            {
                MessageBox.Show("Şifre Yanlış");
            }
            if (textBox1.Text != "HMertC" && textBox2.Text == "1234")
            {
                MessageBox.Show("Kullanıcı Adı Yanlış");
            }
            if (textBox1.Text != "HMertC" && textBox2.Text != "1234")
            {
                MessageBox.Show("Hatalı Bilgiler Girdiniz");
            }


        }
    }
}
