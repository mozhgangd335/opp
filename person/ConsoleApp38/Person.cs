using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public class Person
    {
        public Person(string firstname,string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
     public string FirstName { get; set; }
        public string LastName { get; set; }

        public void GetFullName(string name, string family)
        {
            Console.WriteLine("FullName is:" +name + " " + family);
        }


    }
}
