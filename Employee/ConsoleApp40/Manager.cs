using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Manager:Employee
    {
        public Manager(string name,int id,double salary,string department) : base(name, id, salary)
        {
            Department = department;
        }
        public  string Department { get; set; }
        public  override void PrintDetails()

        {
            Console.WriteLine($"name is:{Name},id is:{Id}, salary is:{Salary},department is:{Department}");


        }
    }
}
