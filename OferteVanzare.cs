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
    public partial class OferteVanzare : Form
    {
        public OferteVanzare()
        {
            InitializeComponent();
            PopuleazaListView1();
        }
        public void PopuleazaListView1()
        {
            
            List<Imobil> grup = new List<Imobil>();
            grup.Add(new Imobil("Apartament", "Berceni",2, 37400));
            grup.Add(new Imobil("Apartament", "Drumul Taberei", 2, 39900));
            grup.Add(new Imobil("Apartament", "Pantelimon", 2, 78000));
            grup.Add(new Imobil("Apartament", "Pipera", 3, 118500));
            grup.Add(new Imobil("Apartament", "Titan", 3, 117000));
            grup.Add(new Imobil("Garsoniera", "Militari", 1, 27500));
            grup.Add(new Imobil("Apartament", "Titan", 3, 115000));
            

            foreach (Imobil inregistrare in grup)
            {
                ListViewItem rand = new ListViewItem();
                rand.Text = inregistrare.Denumire;
                rand.SubItems.Add(inregistrare.Cod.ToString());
                rand.SubItems.Add(inregistrare.Cartier);
                rand.SubItems.Add(inregistrare.Nrcamere.ToString());
                rand.SubItems.Add(inregistrare.Oferta.ToString());
                listView1.Items.Add(rand);

            }
        }
    }
}
