using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incercare1
{
    [Serializable]
    public class Inchirieri
    {
        private string numepersoana;
        private string nrtelefon;
        private string codimobil;
        private DateTime datainceput;
        private DateTime datasfarsit;
        public Inchirieri(string numepersoana,string nrtelefon, string codimobil,DateTime datainceput
            ,DateTime datasfarsit)
        {
            this.numepersoana = numepersoana;
            this.nrtelefon = nrtelefon;
            this.codimobil = codimobil;
            this.datainceput = datainceput;
            this.datasfarsit = datasfarsit;
        }
        public string Numepersoana
        {
            get { return numepersoana; }
            set
            {
                numepersoana = value;
            }
        }
        public string Nrtelefon
        {
            get { return nrtelefon; }
            set
            {
                nrtelefon = value;
            }
        }
        public string Codimobil
        {
            get { return codimobil; }
            set
            {
                codimobil = value;
            }
        }


        public DateTime Datainceput
        {
            get { return datainceput; }
            set
            {
                datainceput = value;
            }
        }
        public DateTime Datasfarsit
        {
            get { return datasfarsit; }
            set
            {
                datasfarsit = value;
            }
        }
        public override string ToString()
        {

            return ("\nPersoana: " + this.numepersoana + "\t cu nr de telefon: " + this.nrtelefon.ToString() +
                "\t a inchiriat imobilul cu codul: " + this.codimobil.ToString()
                + "\t din data de: " + this.datainceput.ToString()
                + "\t pana in data de: " + this.datasfarsit.ToString());
        }
    }
}
