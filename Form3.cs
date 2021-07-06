using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Incercare1
{
    public partial class Form3 : Form
    {
        List<Inchirieri> lista2;

        public Form3(List<Inchirieri> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Inchirieri i in lista2)
                textBox1.Text += i.ToString() + Environment.NewLine;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
                sw.WriteLine(textBox1.Text);
                sw.Close();
                textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            { StreamReader sr = new StreamReader(dlg.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            }

        private void btnSerializare_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
           // bf.Serialize(fs, textBox1.Text);
            bf.Serialize(fs,lista2);
            textBox1.Clear();
            fs.Close();
        }

        private void btnDeserializare_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            //string s = (string)bf.Deserialize(fs);//am facut cast la string pt ca in stanga aveam un string si in dreapta un object
            //textBox1.Text = s;
            textBox1.Clear();
             List<Inchirieri> lista3=(List<Inchirieri>)bf.Deserialize(fs);
            foreach(Inchirieri i in lista3)
            textBox1.Text += i.ToString() + Environment.NewLine;
            fs.Close();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form4 frm = new Form4();
            frm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.A)
            { button1.PerformClick(); }
            if (e.Control == true && e.KeyCode == Keys.S)
            { button2.PerformClick(); }
            if (e.Control == true && e.KeyCode == Keys.C)
            { button3.PerformClick(); }
            if (e.Control == true && e.KeyCode == Keys.D)
            { btnDeserializare.PerformClick(); }
        }
    }
}
