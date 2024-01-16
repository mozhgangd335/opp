using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38 { 

      public abstract class Employee
    {
        protected Employee(string name,int id,int salary)
        {
            Name = name;
            EmployeeId = id;
            _Salary = salary;
        
        }
        public int _Salary { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
      
        
        public virtual void PrintDetails(string name,int id,int salary)
        {
        

        }
    }
}
