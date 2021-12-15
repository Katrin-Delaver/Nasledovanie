using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    public class Abiturient : Human
    {
        int numberCoints;

        public Abiturient(int numberCoints, string fio, string dataOfBirth, string pol) :base(fio, dataOfBirth, pol)
        {
            this.NumberCoints = numberCoints;
        }

        public int NumberCoints { get => numberCoints; set => numberCoints = value; }
    }
}
