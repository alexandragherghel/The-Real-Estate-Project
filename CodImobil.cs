using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incercare1
{
    public partial class CodImobil : UserControl
    {
        public CodImobil()
        {
            InitializeComponent();
        }
        public string CodSelectat()
        {
                return cbCod.SelectedItem.ToString();
            
        }
        private void CodImobil_Load(object sender, EventArgs e)
        {
            List<String> list = new List<String>();
            list.Add("VANZ1");
            list.Add("VANZ2");
            list.Add("VANZ3");
            list.Add("VANZ4");
            list.Add("VANZ5");
            list.Add("VANZ6");
            list.Add("VANZ7");
            list.Add("INC8");
            list.Add("INC9");
            list.Add("INC10");
            list.Add("INC11");
            list.Add("INC12");
            list.Add("INC13");
            list.Add("INC14");
            cbCod.DataSource = list;
        }
    }
}
