using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
   public class Manager : Employee
    {
        public string Department { get; set; }
        public Manager(string name, int id,int salary) : base(name, id,salary)

        {
            
        }


        public override void PrintDetails(string name, int id,int salary)

        {
            if (id <= 0)
            {
                throw new Exception("this id is invalid");
               
            }
            Console.WriteLine($"name:{ name},\nid:{id},\nsalary{salary}");
            base.PrintDetails(name, id,salary);
        }
        
       
            
        }

    }
    






  
