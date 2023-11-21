using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaneV1_1575
{
    public partial class Form1 : Form
    {
        Hasta hasta =new Hasta();
        int sayac = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         Hasta hasta1 = new Hasta();

            hasta1.ad = "Raito";
            hasta1.soyad = "Quaresma";
            hasta1.tel = "12345678901";
            hasta1.kronikhastalik = false;
            hasta1.kangurubu = "B-";
            hasta1.dtarih = new DateTime(2008, 07, 08);


        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            sayac++;
            lbKontrol.Items.Add(sayac + ".HASTA");

         hasta.ad=txtAd.Text;
            lbKontrol.Items.Add(hasta.ad);
         hasta.soyad = txtSoyad.Text;
            lbKontrol.Items.Add(hasta.soyad);
         hasta.dtarih = dateTimePicker1.Value;
            lbKontrol.Items.Add(hasta.dtarih);
         hasta.kronikhastalik = rbEvet.Checked ;
            lbKontrol.Items.Add(hasta.kronikhastalik);
         hasta.kangurubu = cbKangrb.Text;
            lbKontrol.Items.Add(hasta.kangurubu);
         hasta.tcno = txtTc.Text;
            lbKontrol.Items.Add(hasta.tcno);
            if (rbEvet.Checked)
            {
                hasta.kronikhastalik = true;
            }
            else
            {
                hasta.kronikhastalik = false;  
            }
            txtAd.Clear();
            txtSoyad.Clear();
            txtTc.Clear();
            txtTelefon.Clear();
            cbKangrb.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BİLGİLERİNİZ KAYIT EDİLMİŞTİR");
        }
    }
}
