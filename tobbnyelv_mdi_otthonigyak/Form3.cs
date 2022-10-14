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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataSet1.WriteXml("FeliratElemek.XML");
            MessageBox.Show("Adatok elmentve! FeliratElemek.XML");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataSet1.ReadXml("FeliratElemek.XML");
        }
    }
}
