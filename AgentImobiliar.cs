using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incercare1
{
    public class AgentImobiliar
    {
        private string nume;
        private string email;
        private string nrtelefon;
        public AgentImobiliar(string nume, string email, string nrtelefon)
        {
            this.nume = nume;
            this.email = email;
            this.nrtelefon = nrtelefon;
        }
        public string Nume
        {
            get { return nume; }
            set
            {
                nume = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
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

        public override string ToString()
        {
            return this.nume + " " + this.email + " " + this.nrtelefon;

        }
    }
}
