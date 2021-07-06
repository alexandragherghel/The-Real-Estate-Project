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
    public partial class Concurs : Form
    {
        public Concurs()
        {
            InitializeComponent();
            textBox1.Text = "FII CEL MAI CREATIV! \n Deseneaza cel mai potrivit logo pentru agentia noastra, iar noi te premiem cu o vaza cu care sa iti decorezi locuinta.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
