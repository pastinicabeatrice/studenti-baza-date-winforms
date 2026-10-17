using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentiBazaDate
{
    public class Student
    {
        private int matricol;
        private string nume;
        private string facultate;
        private decimal medie;

        public Student(int matricol, string nume, string facultate, decimal medie)
        {
            this.matricol = matricol;
            this.nume = nume;
            this.facultate = facultate;
            this.medie = medie;
        }

        public int Matricol { get => matricol; set => matricol = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Facultate { get => facultate; set => facultate = value; }
        public decimal Medie { get => medie; set => medie = value; }
    }
}
