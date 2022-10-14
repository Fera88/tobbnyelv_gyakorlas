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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label1.Text = Form1.feliratok[0];
            for (int i = 0; i < Form1.feliratok.Length; i++)
            {
                if (Form1.feliratok[i].Length > 0) listBox1.Items.Add(Form1.feliratok[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
