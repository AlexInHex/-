using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Delegate
{
    abstract class Person
    {
        private int id;
        private string name;
        private int age;

        public int Id { get; private set; }
        public int Name { get; private set; }
        public int Age { get; private set; }

        public Person(int Id, string Name, int Age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
