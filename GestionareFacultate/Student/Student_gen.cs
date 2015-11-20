using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Student
{
    public interface Istudenti {

    }
    public class Student_gen
    {
        
        public int nr_matricol { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string facultate { get; set; }
        public string specializare { get; set; }
        public int grupa{ get; set; }
        public string disc1 { get; set; }
        public string disc2 { get; set; }
        public string disc3 { get; set; }
        public string disc4 { get; set; }
        public double medie_gen { get; set; }
    }
    
}
