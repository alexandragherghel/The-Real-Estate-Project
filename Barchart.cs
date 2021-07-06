using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace Incercare1
{
    public partial class Barchart : Form
    {
       
        
        //incarcam datele din fisier intr-un vector 
        double[] vect = new double[20];
        int nrElem = 0;
        bool vb = false;//dc vb e true inseamna ca am cel putin un element in vector
        const int marg = 20;
        Color culoare = Color.Blue;
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        public Barchart()
        {
            InitializeComponent();
        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<IndiceImobiliar> lista = new List<IndiceImobiliar>();
            lista.Add(new IndiceImobiliar("octombrie", 1373,2019));
            lista.Add(new IndiceImobiliar("noiembrie", 1387,2019));
            lista.Add(new IndiceImobiliar("decembrie", 1413,2019));
            lista.Add(new IndiceImobiliar("ianuarie", 1449,2020));
            lista.Add(new IndiceImobiliar("februarie", 1444,2020));
            lista.Add(new IndiceImobiliar("martie", 1395,2020));
            lista.Add(new IndiceImobiliar("aprilie",1423,2020));
           
            foreach(IndiceImobiliar ind in lista)
            {
                try
                {
                    vect[nrElem] = ind.Indice;
                    nrElem++;
                    vb = true;//am cel putin un element in vector
                }
                catch(Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            MessageBox.Show("Datele au fost incarcate");
            //apelez Invalidate ca sa declanseze evenimentul de paint 
            // Invalidate();
            panel1.Invalidate();
        }

        private void Barchart_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;
                //definesc coordonatele unui dreptunghi cadru rosu
                //scad margine ca sa nu fie chiar cat tot formularul
                Rectangle rec = new Rectangle(this.ClientRectangle.X + marg,
                    this.ClientRectangle.Y + 4 * marg,
                    this.ClientRectangle.Width - 2 * marg, this.ClientRectangle.Height - 5 * marg);
                //definesc instrumentul de scris
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rec);
                //impart latimea dreptunghiului mare la cate elemente
                //am si am grija sa mai las si un spatiu intre ele
                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                //determin elem maxim din vector
                double vMax = vect.Max();
                Brush br = new SolidBrush(culoare);
                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                     (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                    (int)latime,
                    (int)(vect[i] / vMax * rec.Height));
                    //valorile sa fie desenate deasupra dreptunghiurilor
                    g.DrawString(vect[i].ToString(), font, br,
                        new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y - font.Height)));
                }
                g.FillRectangles(br, recs);
                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y)),
                    new Point((int)(recs[i + 1].Location.X + latime / 2),
                (int)(recs[i + 1].Location.Y)));


            }
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                culoare = dlg.Color;
            //apelez invalidate ca sa relanseze evenimentul de paint
            //Invalidate();
            panel1.Invalidate();
        }

        private void save(Control c, string denumire)
        { //instantiez un bitmap care sa fie setat ca lungime si inaltime
          //pe baza controlului primit ca parametru
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y,
                c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(denumire);
            //dispose mi-o sterge din memorie in momentul in care am salvat-o pe disk
            img.Dispose();
        }
        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save(this, "PozaGrafic.bmp");
            save(panel1, "PozaGrafic.bmp");
            MessageBox.Show("S-a salvat");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;
                //definesc coordonatele unui dreptunghi cadru rosu
                //scad margine ca sa nu fie chiar cat tot formularul
                Rectangle rec = new Rectangle(panel1.ClientRectangle.X + marg,
                    panel1.ClientRectangle.Y + 2 * marg,
                    panel1.ClientRectangle.Width - 2 * marg, panel1.ClientRectangle.Height - 3 * marg);
                //definesc instrumentul de scris
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rec);
                //impart latimea dreptunghiului mare la cate elemente
                //am si am grija sa mai las si un spatiu intre ele
                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                //determin elem maxim din vector
                double vMax = vect.Max();
                Brush br = new SolidBrush(culoare);
                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                     (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                    (int)latime,
                    (int)(vect[i] / vMax * rec.Height));
                    //valorile sa fie desenate deasupra dreptunghiurilor
                    g.DrawString(vect[i].ToString(), font, br,
                        new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y - font.Height)));
                }
                g.FillRectangles(br, recs);
                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y)),
                    new Point((int)(recs[i + 1].Location.X + latime / 2),
                (int)(recs[i + 1].Location.Y)));

            }
        }
        //ne definim o functie de desenare
        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;

                Rectangle rec = new Rectangle(e.PageBounds.X + marg,
                    e.PageBounds.Y + 2 * marg,
                    e.PageBounds.Width - 2 * marg, e.PageBounds.Height - 3 * marg);

                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);

                double vMax = vect.Max();
                Brush br = new SolidBrush(culoare);
                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                     (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                    (int)latime,
                    (int)(vect[i] / vMax * rec.Height));
                    g.DrawString(vect[i].ToString(), font, br,
                        new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y - font.Height)));
                }
                g.FillRectangles(br, recs);
                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y)),
                    new Point((int)(recs[i + 1].Location.X + latime / 2),
                (int)(recs[i + 1].Location.Y)));

            }
        }
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            //setam functia de tratare a evenim print page
            pd.PrintPage += new PrintPageEventHandler(pdPrint);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();


        }
    }
}
