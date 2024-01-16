using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
     class StudentUniversity:Student


    {
        public int Grade { get; set; }
        public StudentUniversity(string name,int id,int grade) : base(name, id)
        {
            Grade = grade;
        }
        public override void ShowDetail()

        {
            Console.WriteLine($"  garde:{Grade}");

            base.ShowDetail();
        }

    }
}
