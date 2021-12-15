using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    public class Student : Abiturient
    {
        int kyrs;
        string team;
        string facultet;

        public Student(int kyrs, string team, string facultet, int numberCoints, string fio, string dataOfBirth, string pol): base(numberCoints, fio, dataOfBirth, pol)
        {
            this.Kyrs = kyrs;
            this.Team = team;
            this.Facultet = facultet;
        }

        public int Kyrs { get => kyrs; set => kyrs = value; }
        public string Team { get => team; set => team = value; }
        public string Facultet { get => facultet; set => facultet = value; }
    }
}
