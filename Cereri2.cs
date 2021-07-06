using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Incercare1
{
    public partial class Cereri2 : Form
    {
        OleDbConnection con;
        public Cereri2()
        {
            InitializeComponent();
            con = new OleDbConnection();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Alexandra\Documents\Incercare1\Database21.accdb";
            con.Open();
            tbNrCamere.KeyPress += new KeyPressEventHandler(tbNrCamere_KeyPress);
        }

        private void Cereri2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
                MessageBox.Show("Conexiune inchisa");
            }
        }

        private void Cereri2_Load(object sender, EventArgs e)
        {
            OleDbCommand cmd_sel = new OleDbCommand("select * from Cereri",con);
            OleDbDataReader rd = cmd_sel.ExecuteReader();
            for (int i = 0; i < rd.FieldCount; i++)
                gv.Columns.Add("c"+i.ToString(), rd.GetName(i));
            gv.Columns[0].Width = 180;//largesc prima coloana,implicit este 100
            Fill();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti numele!");
            else
                if (tbImobil.Text == "")
                errorProvider1.SetError(tbImobil, "Introduceti imobilul!");

            else
                        if (tbNrCamere.Text == "")
                errorProvider1.SetError(tbNrCamere, "Introduceti nr de camere!");
            else
                        if (tbCartier.Text == "")
                errorProvider1.SetError(tbCartier, "Introduceti Cartierul!");
            else
            if (codImobil1.CodSelectat().Substring(0, 4) != "VANZ")
            {
                errorProvider1.SetError(codImobil1, "Codul nu este valid");

            }
         
            else
                    try
                    {
                        string sinserare = "insert into Cereri values('" + tbNume.Text +
                            "' , '" + tbImobil.Text + "' , '" + tbCartier.Text + "' , " +
                            Convert.ToInt32(tbNrCamere.Text) + " , '" + codImobil1.CodSelectat() + "')";
                        OleDbCommand cmd_ins = new OleDbCommand();
                        cmd_ins.CommandText = sinserare;
                        cmd_ins.Connection = con;
                        int nrt = cmd_ins.ExecuteNonQuery();
                        if (nrt != 0)
                            MessageBox.Show("inserate" + nrt + "tupluri");
                        Fill();
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
        void Fill()
        {
            gv.Rows.Clear();
            OleDbCommand cmd_sel = new OleDbCommand("select * from Cereri", con);
            OleDbDataReader rd = cmd_sel.ExecuteReader();
            while(rd.Read())
            {
                object[] vob = new object[rd.FieldCount];
                for(int i=0;i<rd.FieldCount;i++)
                {
                    vob[i] = rd.GetValue(i);
                }
                gv.Rows.Add(vob);
            }

        }

        private void tbNrCamere_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '3') 
            {
                e.Handled = false; 
            }
            else
            {
                e.Handled = true; 
            }
        }
    }
}
