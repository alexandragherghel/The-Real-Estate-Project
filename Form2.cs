using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Incercare1
{
    public partial class Form2 : Form
    {
        List<Inchirieri> listaImob = new List<Inchirieri>();
        public Form2()
        {
            InitializeComponent();
        }
      
        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "")
                errorProvider1.SetError(tb1, "Introduceti numele!");
            else
                if (tb2.Text == "")
                errorProvider1.SetError(tb2, "Introduceti nr de telefon!");
         
            else
                        if (tb4.Text == "")
                errorProvider1.SetError(tb4, "Introduceti data de inceput!");
            else
                        if (tb5.Text == "")
                errorProvider1.SetError(tb4, "Introduceti data de sfarsit!");
            else
            if (tb2.Text.Substring(0, 2) != "07")
            {
                errorProvider1.SetError(tb2, "Nu este un nr de mobil valid");

            }
            else
            if (codImobil1.CodSelectat().Substring(0, 3) != "INC")
            {
                errorProvider1.SetError(codImobil1, "Codul nu este valid");

            }
            else
            if (tb2.Text.Length != 10)
            {
                errorProvider1.SetError(tb2, "Nu este un nr de mobil valid");

            }
            else
            if(Convert.ToDateTime(tb5.Text)<Convert.ToDateTime(tb4.Text))
            {
                errorProvider1.SetError(tb5, "Nu este un interval de timp valid");
            }
            else
            {
                try
                {
                    string numepersoana = tb1.Text;
                    string codimobil = codImobil1.CodSelectat();
                    string nrtelefon = tb2.Text;
                    DateTime datainceput = Convert.ToDateTime(tb4.Text);
                    DateTime datasfarsit = Convert.ToDateTime(tb5.Text);
                    Inchirieri i = new Inchirieri(numepersoana, nrtelefon, codimobil, datainceput, datasfarsit);
                    listaImob.Add(i);
                    MessageBox.Show(i.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    errorProvider1.Clear();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(listaImob);
            frm.Show();
        }
    }
}
