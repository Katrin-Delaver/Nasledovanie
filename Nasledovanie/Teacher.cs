using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    public class Teacher : Human
    {
        string position;
        string kafedra;

        public Teacher(string position, string kafedra, string fio, string dataOfBirth, string pol): base(fio, dataOfBirth, pol)
        {
            this.Position = position;
            this.Kafedra = kafedra;
        }

        public string Position { get => position; set => position = value; }
        public string Kafedra { get => kafedra; set => kafedra = value; }
    }
}
