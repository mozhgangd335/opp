using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
   abstract class Student:Istudents
    {


        public string _Name { get; set; }
      public int _StudentID { get; set; }
        public Student(string name,int id)
        {
            _Name = name;
            _StudentID = id;

        }
    
    
        public virtual void ShowDetail()
        {
            Console.WriteLine($"Student name:{_Name} - studentID:{_StudentID}");
        }

       
    }
}

    
