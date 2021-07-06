using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incercare1
{
    [Serializable]
    public class Imobil
    {
        private static int contor;
        private readonly string cod;
        private string denumire;
        private string cartier;
        private int nrcamere;
        private int oferta;
        public string Cod { get { return cod; } }
        static Imobil()
        {
            contor = 0;
        }
        public Imobil()
        {
            ++contor;
            this.cod = contor.ToString();
            this.denumire = " ";
            this.cartier = " ";
            this.nrcamere = 0;
            this.oferta = 0;
        }

        public Imobil(string denumire, string cartier, int nrcamere, int oferta)
        {
            ++contor;
            if (oferta<4000)
            {
                this.cod += "INC";
            }
            else
                this.cod += "VANZ";
            this.cod += contor.ToString();
            this.denumire = denumire;
            this.cartier = cartier;
            this.nrcamere = nrcamere;
            this.oferta = oferta;
        } 
        public string Denumire
        {
            get { return denumire; }
            set
            {
                denumire = value;
            }
        }
        public string Cartier
        {
            get { return cartier; }
            set
            {
                cartier = value;
            }
        }
        public int Nrcamere
        {
            get { return nrcamere; }
            set
            {
                if (value >= 0)
                {
                    nrcamere = value;
                }
                else
                {
                    throw new InvalidOperationException("Numarul de camere nu poate fi negativ.");
                }
            }
        }

        public int Oferta
        {
            get { return oferta; }
            set
            {
                if (value > 0)
                {
                    oferta = value;
                }
                else
                {
                    throw new InvalidOperationException("Oferta nu poate sa fie <=0.");
                }
            }
        }
        public override string ToString()
        {

            return ("\nImobil: " + this.denumire + "cu codul"+ this.cod.ToString()+"\t cartier: " + this.cartier
                + "\t nr camere: " + this.nrcamere.ToString() + "\t pretul: " + this.oferta.ToString());

        }

    }
}
