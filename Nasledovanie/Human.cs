using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    public class Human
    {
        string fio;
        string dataOfBirth;
        string pol;

        public Human(string fio, string dataOfBirth, string pol)
        {
            this.Fio = fio;
            this.DataOfBirth = dataOfBirth;
            this.Pol = pol;
        }

        public string Fio { get => fio; set => fio = value; }
        public string DataOfBirth { get => dataOfBirth; set => dataOfBirth = value; }
        public string Pol { get => pol; set => pol = value; }
    }
}
