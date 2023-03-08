using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302213121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bil1 = 0;
        int bil2 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            Button btnA = (Button)sender;
            TextUtama.Text = TextUtama.Text + btnA.Text;
        }
        int i = 1;
        private void btntambah_Click(object sender, EventArgs e)
        {
            if(bil1 == 0)
            {
                while (i >= i + 1)
                {
                    bil1 = TextUtama.Text.Length - i;
                    i++;
                }
            }
            TextUtama.Text = "";
        }
        private void btnsamadengan_Click(object sender, EventArgs e)
        {
            if(bil2 == 0) {
                bil2 = TextUtama.Text.Length;
            
            }
            TextUtama.Text = "" + (bil1 + bil2);
            bil1 = bil1 + bil2;
            bil2 = 0;
        }
    }
}
