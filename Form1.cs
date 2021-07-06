using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incercare1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cereri2 f2 = new Cereri2();
            f2.ShowDialog();
        }

        private void echipaNoastraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Echipa ech = new Echipa();
            ech.ShowDialog();
        }

        private void inchirieriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }

        private void vanzariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipurideCladiri frm = new TipurideCladiri();
            frm.Show();
        }

        private void deVanzareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OferteVanzare frm = new OferteVanzare();
            frm.Show();
        }

        private void deInchiriatToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            OferteInchiriere frm = new OferteInchiriere();
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Barchart frm = new Barchart();
                frm.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cursbnr.ro/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bancatransilvania.ro/pentru-tine/credite/credite-pentru-investitii-imobiliare/prima-casa/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://calendarro.com/");
        }

        private void detaliiConcursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Concurs frm = new Concurs();
            frm.Show();
        }
    }
}
