using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Delegate
{
    class Client : Person
    {
        public int Cash { get; set; }
        public Client(int id ,string name, int age, int cash) : base (id, name, age)
        {
            Cash = cash;
        }
    }
}
