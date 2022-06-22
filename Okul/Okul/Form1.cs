using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci.ogrenci ogrenci = new Ogrenci.ogrenci();
            ogrenci.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Maas.maas maas = new Maas.maas();
            maas.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sinif.sinif sinif = new Sinif.sinif();
            sinif.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Egitmen.egitmen egitmen = new Egitmen.egitmen();
            egitmen.Show();
            this.Hide();
        }
    }
}
