using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
   abstract class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary;
        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }


         public virtual void PrintDetails()
        {
            Console.WriteLine($"name is:{Name}id is{Id} salary is{Salary}");
        }
    }
}