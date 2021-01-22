using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTrello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        public int maddesayisi = 0;
        public static int secilimaddeno = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            madde madde1 = new madde();
            panel2.Controls.Add(madde1);
            ControlExtension.Draggable(madde1, true);
            madde1.maddeno = maddesayisi;
            maddesayisi++;
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            madde.gerceklesensure[secilimaddeno] = textBox_gerceklesensure.Text;
            madde.isaciklamasi[secilimaddeno] = textBox_isaciklamasi.Text;
            madde.kartno[secilimaddeno] = textBox_kartno.Text;
            madde.notlar[secilimaddeno] = textBox_notlar.Text;
            madde.projeadi[secilimaddeno] = textBox_projeadi.Text;
            madde.tahminisure[secilimaddeno] = textBox_tahminisure.Text;
            madde.tarih[secilimaddeno] = textBox_tarih.Text;
            madde.teknikuzman[secilimaddeno] = textBox_teknikuzman.Text;

            textBox_gerceklesensure.Clear();
            textBox_isaciklamasi.Clear();
            textBox_kartno.Clear();
            textBox_notlar.Clear();
            textBox_projeadi.Clear();
            textBox_tahminisure.Clear();
            textBox_tarih.Clear();
            textBox_teknikuzman.Clear();

            panelsifirla();panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kartdoldur();
            panelsifirla();panel3.Visible = true;
        }

        private void kartdoldur()
        {
            if (madde.gerceklesensure[secilimaddeno] != null) textBox_gerceklesensure.Text = madde.gerceklesensure[secilimaddeno];
            if (madde.isaciklamasi[secilimaddeno] != null) textBox_isaciklamasi.Text = madde.isaciklamasi[secilimaddeno];
            if (madde.kartno[secilimaddeno] != null)textBox_kartno.Text = madde.kartno[secilimaddeno];
            if (madde.notlar[secilimaddeno] != null)textBox_notlar.Text = madde.notlar[secilimaddeno];
            if (madde.projeadi[secilimaddeno] != null)textBox_projeadi.Text = madde.projeadi[secilimaddeno];
            if (madde.tahminisure[secilimaddeno] != null)textBox_tahminisure.Text = madde.tahminisure[secilimaddeno];
            if (madde.tarih[secilimaddeno] != null)textBox_tarih.Text = madde.tarih[secilimaddeno];
            if (madde.teknikuzman[secilimaddeno] != null)textBox_teknikuzman.Text = madde.teknikuzman[secilimaddeno];
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelsifirla();panel1.Visible = true;
        }

        private void panelsifirla()
        {
            panel1.Visible = false;
            panel3.Visible = false;
        }
    }
}
