using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using Student.Exceptii;

namespace Student
{
    public class NumarMatricol
    {
        private string _numar;
        public string Numar { get { return _numar; } }

        public NumarMatricol(string numar)
        {
            Contract.Requires<ArgumentNullException>(numar != null, "text");
            Contract.Requires<EmptyString>(!string.IsNullOrEmpty(numar), "text");
            Contract.Requires<ArgumentException>(numar.Length == 6, "Numarul matricol are exact 6 caractere.");

            _numar = numar;
        }


        #region override object
        public override string ToString()
        {
            return Numar;
        }

        public override bool Equals(object obj)
        {
            var nume = (NumarMatricol)obj;
            return Numar.Equals(nume.Numar);
        }

        public override int GetHashCode()
        {
            return Numar.GetHashCode();
        }
        #endregion
    }
}
