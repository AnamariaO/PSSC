using Student;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Secretariat
{
    public class secretariat
    {

        private List<Student_gen> date_student;
        public ReadOnlyCollection<Student_gen> Valori { get { return date_student.AsReadOnly(); } }


        public void introducere_date()
        {
            date_student = new List<Student_gen>();
        }
        
    }
    
}
