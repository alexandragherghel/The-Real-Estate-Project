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
    public partial class TipurideCladiri : Form
    {
        public TipurideCladiri()
        {
            InitializeComponent();
        }

        private void TipurideCladiri_Load(object sender, EventArgs e)
        {
            pb4.AllowDrop = true;//permite drop in pictureBox4
        }

        private void pb4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pb4_DragDrop(object sender, DragEventArgs e)
        {
            pb4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pb3_MouseDown_1(object sender, MouseEventArgs e)
        {
            pb3.DoDragDrop(pb3.Image, DragDropEffects.Copy);
        }

        private void pb2_MouseDown(object sender, MouseEventArgs e)
        {
            pb2.DoDragDrop(pb2.Image, DragDropEffects.Copy);
        }

        private void pb1_MouseDown(object sender, MouseEventArgs e)
        {
            pb1.DoDragDrop(pb1.Image, DragDropEffects.Copy);
        }
    }
}
