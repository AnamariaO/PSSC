using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;


namespace Secretariat
{
    class AdresaStudent
    {
        private string adresa;

        public string Adresa { get { return adresa; } }

        public AdresaStudent(string adresaS)
        {
            Contract.Requires<ArgumentNullException>(adresaS != null, "text");
            adresa = adresaS;
        }

        public override string ToString()
        {
            return Adresa;
        }

        public override bool Equals(object obj)
        {
            var nume = (AdresaStudent)obj;
            return Adresa.Equals(nume.Adresa);
        }

        public override int GetHashCode()
        {
            return Adresa.GetHashCode();
        }
    }
}
