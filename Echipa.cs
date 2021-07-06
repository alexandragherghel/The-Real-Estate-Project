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
    public partial class Echipa : Form
    {
        public Echipa()
        {
            InitializeComponent();
            PopuleazaListView1();
        }

        public void PopuleazaListView1()
        {
            AgentImobiliar ag = new AgentImobiliar("Anastasia", "an@yahoo.com", "0788895568");
            List<AgentImobiliar> grup = new List<AgentImobiliar>();
            grup.Add(ag);
            grup.Add(new AgentImobiliar("Victor", "vi@yahoo.com", "0742345876"));
            grup.Add(new AgentImobiliar("Ciprian", "ci@yahoo.com", "0745367281"));
            grup.Add(new AgentImobiliar("Francesca", "vi@yahoo.com", "0732111234"));
            grup.Add(new AgentImobiliar("Sebastian", "se@yahoo.com", "0733345645"));
            grup.Add(new AgentImobiliar("Claudia", "cl@yahoo.com", "0788906543"));

            foreach (AgentImobiliar inregistrare in grup)
            {
                ListViewItem rand = new ListViewItem();
                rand.Text = inregistrare.Nume;
                //rand.SubItems.Add(ag.Nume);
                rand.SubItems.Add(inregistrare.Email);
                rand.SubItems.Add(inregistrare.Nrtelefon);


                listView1.Items.Add(rand);

            }
        }
            private void pictureBox4_Click(object sender, EventArgs e)
            {

            }
        
    } 
}
