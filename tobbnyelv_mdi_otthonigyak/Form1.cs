using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Globalization;

namespace tobbnyelv_mdi_otthonigyak
{
    public partial class Form1 : Form
    {
        public static int ablak = 0;
        public static string[] feliratok = new string[1000];
        //
        public Form1()
        {
            InitializeComponent();
            statuszirass();
            Text += " --Verzió: 1.2";
            toolStripComboBox1.SelectedIndex = Properties.Settings.Default.ANyelv;
            nyelvbetolt();
            nyelvvalszt();
        }

        public void nyelvvalszt()
        {
            if (toolStripComboBox1.SelectedIndex == 1)
            {
                megnyitásToolStripMenuItem.Text = "Open";
                fájlToolStripMenuItem.Text = "File";
                kilépésToolStripMenuItem.Text = "Exit";
                beállításokToolStripMenuItem.Text = "Settings";
                nyelviTáblákKezeléseToolStripMenuItem.Text = "Language table maintenance";
                feliratElemekToolStripMenuItem.Text = "Subtitle elements";
                névjegyToolStripMenuItem.Text = "About";
               




            }
            if (toolStripComboBox1.SelectedIndex == 2)
            {
                megnyitásToolStripMenuItem.Text = "Offen";
                fájlToolStripMenuItem.Text = "File";
                kilépésToolStripMenuItem.Text = "Ausgang";
                beállításokToolStripMenuItem.Text = "Einstellungen";
                nyelviTáblákKezeléseToolStripMenuItem.Text = "Sprache Tisch Wartung";
                feliratElemekToolStripMenuItem.Text = "Untertitel Elemente";
                névjegyToolStripMenuItem.Text = "Über";
            }
            else
                toolStripComboBox1.SelectedIndex = Properties.Settings.Default.ANyelv;
            
        }

        private void nyelvbetolt()
        {
            for (int i = 0; i < feliratok.Length; i++)
            {
                feliratok[i] = "";
            }
            int melyik = Properties.Settings.Default.ANyelv;
            string mezonev = "";
            switch (melyik)
            {
                case 0: mezonev= "Magyar";break;
                case 1: mezonev ="Angol";break;
                case 2: mezonev = "Nemet";break;
                default:
                    mezonev = "Magyar";
                    break;
            }
            int helye = 0;
            feliratok[0] = mezonev;
            XmlReader olvaso = XmlReader.Create("FeliratElemek.XML");
            while (olvaso.Read())
            {
                if (olvaso.IsStartElement())
                {
                    if (olvaso.Name == "Sorszam") helye = Convert.ToInt16(olvaso.ReadString());
                    if (olvaso.Name == mezonev) feliratok[helye] = olvaso.ReadString();
                }
            }
        }

        public void statuszirass()
        {
            if (ablak == 0)
            {
                toolStripStatusLabel1.Text = "Nincs nyitott ablak";
            }
            else
                toolStripStatusLabel1.Text = "Nyitott ablakok száma " + ablak.ToString();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ablak++;
            statuszirass();
            Form2 ff = new Form2(this);
            ff.MdiParent = this;
            ff.Show();
        }

        private void nyelviTáblákKezeléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ff = new Form3();
            ff.MdiParent = this;
            ff.Show();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ANyelv != toolStripComboBox1.SelectedIndex)
            {
                Properties.Settings.Default.ANyelv = toolStripComboBox1.SelectedIndex;
                Properties.Settings.Default.Save();
                nyelvbetolt();
                MessageBox.Show("Kérem indítsa újra a programot a változáshoz!", "FIGYELEM!", MessageBoxButtons.OK);
            }
            

        }

        private void feliratElemekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 ff = new Form4();
            ff.MdiParent = this;
            ff.Show();
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.MdiParent = this;
            ab.Show();
        }
    }
}
