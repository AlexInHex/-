using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Delegate
{
    class PersonFactory
    {

        private static T CreatePerson<T>(int id, string name, int age)
            where T : Person, new() => new()
            {
                Id = id,
                Name = name,
                Age = age

            };

        public static Manager CreateManger(int id, string name, int age, int subordinatesNumder)
        {

            Manager manager = CreatePerson<Manager>(id, name, age);
            manager.SubordinatesNumder = subordinatesNumder;
            return manager;
        }

        public static Client CreateClient(int id, string name, int age, int cash)
        {
            Client client = CreatePerson<Client>(id, name, age);
            client.Cash = cash;
            return client;
        }

        public static Employee CreateEmployee(int id, string name, int age, int salary)
        {
            Employee employee = CreatePerson<Employee>(id, name, age);
            employee.Salary = salary;
            return employee;
        }
    }
}
