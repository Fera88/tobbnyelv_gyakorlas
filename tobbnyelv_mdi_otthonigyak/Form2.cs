using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tobbnyelv_mdi_otthonigyak
{
    public partial class Form2 : Form
    {
        public Form1 alapform;
        public Form2(Form1 fofo)
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToString();
            label2.Text = Form1.feliratok[1];
            label3.Text = Form1.feliratok[2];
            Text = Form1.ablak.ToString() + ". ablak";
            alapform = fofo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ablak--;
            alapform.statuszirass();
            Close();
        }
    }
}
