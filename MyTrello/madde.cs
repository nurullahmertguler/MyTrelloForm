using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTrello
{
    public partial class madde : UserControl
    {
        public int maddeno = 0;
        public static string[] projeadi = new string[30];
        public static string[] teknikuzman = new string[30];
        public static string[] tarih = new string[30];
        public static string[] kartno = new string[30];
        public static string[] tahminisure = new string[30];
        public static string[] gerceklesensure = new string[30];
        public static string[] isaciklamasi = new string[30];
        public static string[] notlar = new string[30];
        public madde()
        {
            InitializeComponent();
            ControlExtension.Draggable(this,true);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form1.secilimaddeno = maddeno; 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Visible=false;
        }
    }
}
