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
    public partial class OferteInchiriere : Form
    {
        public OferteInchiriere()
        {
            InitializeComponent();
            PopuleazaListView1();
        }
        public void PopuleazaListView1()
        {

            List<Imobil> grup = new List<Imobil>();
            grup.Add(new Imobil("Apartament", "Zona Herastrau", 2, 1000));
            grup.Add(new Imobil("Apartament", "Dorobanti", 3, 800));
            grup.Add(new Imobil("Apartament", "1 Mai", 3, 835));
            grup.Add(new Imobil("Apartament", "Aviatiei", 3, 600));
            grup.Add(new Imobil("Apartament", "Zona Herastrau", 2, 990));
            grup.Add(new Imobil("Garsoniera", "Titan", 1, 275));
            grup.Add(new Imobil("Garsoniera", "Vitan", 1, 525));


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

