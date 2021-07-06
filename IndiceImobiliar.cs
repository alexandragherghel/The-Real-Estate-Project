using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incercare1
{
    class IndiceImobiliar
    {
        private string luna;
        private double indice;
        private int an;
        public IndiceImobiliar(string luna, double indice,int an)
        {
            this.luna = luna;
            this.indice = indice;
            this.an = an;
        }
        public string Luna
        {
            get { return luna; }
            set
            {
               luna = value;
            }
        }
        public double Indice
        {
            get { return indice; }
            set
            {
                indice = value;
            }
        }
    }
}
