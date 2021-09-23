using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Delegate
{
    class Employee : Person
    {
        public int Salary { get; set; }
        public Employee(int id, string name, int age, int salary) : base(id, name, age)
        {
            Salary = salary;
        }

    }
}
