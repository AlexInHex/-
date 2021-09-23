using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Delegate
{
    class Manager : Person
    {
        public int SubordinatesNumder { get; set; }
        public Manager(int id, string name, int age, int subordinatesNumber) : base(id, name, age)
        {
            SubordinatesNumder = subordinatesNumber;
        }
    }
}
