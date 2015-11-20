using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Collections;

namespace Student
{
   
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

    public interface Istudenti
    {
        ArrayList List { get; }
        void Adaugare(object entity);
        void Stergere(object entity);
        void Update(object entity);
        object IdentificareDupaNrMatrciol(Guid nr_matricol);
    }
    public class Studenti : Istudenti
    {
        public ArrayList List { get; private set; }
        public void Update(object entity)
        {
            throw new NotImplementedException();
        }


        public void Adaugare(object entity)
        {
            throw new NotImplementedException();
        }

        public void Stergere(object entity)
        {
            throw new NotImplementedException();
        }

        public object IdentificareDupaNrMatrciol(Guid nr_matricol)
        {
            throw new NotImplementedException();
        }
    }
    public class StudentiI : Istudenti
    {
        private readonly ArrayList _student;
        public StudentiI()
        {
            _student = new ArrayList();

        }

        public ArrayList List
        {
            get { return _student; }
        }

        public void Adaugare(object entity)
        {
            _student.Add(entity);
        }

        public void Stergere(object entity)
        {
            _student.Remove(entity);
        }

        public void Update(object entity)
        {
            var userIndex = _student.IndexOf(entity);
            var userToUpdate = _student[userIndex] as StudentiI;
            if (userToUpdate != null)
            {
                var newUser = (StudentiI)entity;
                userToUpdate.Nume = newUser.Nume;
                userToUpdate.Prenume = newUser.Prenume;
                userToUpdate.Adresa = newUser.Adresa;
                userToUpdate.Nr_matricol = newUser.Nr_matricol;
                userToUpdate.Disciplina1 = newUser.Disciplina1;
                userToUpdate.Disciplina2 = newUser.Disciplina2;
                userToUpdate.Disciplina3 = newUser.Disciplina3;
                userToUpdate.Disciplina4 = newUser.Disciplina4;
            }
            else
            {
                throw new Exception("User not found");
            }
        }

        public object IdentificareDupaNrMatrciol(Guid nr_matricol)
        {
            foreach (StudentiI user in _student)
            {
                if (user.NumarMatrciol == nr_matricol)
                {
                    return user;
                }
            }

            return null;
        }
    }



}
