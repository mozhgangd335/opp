using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class GuestStudents:Student
    {
        public GuestStudents(string name, int id) : base(name, id) {

        }
        public string Course { get; set; }

        public override void ShowDetail()
        {
            Console.WriteLine($"  curse:{Course}");
            base.ShowDetail();
        }


    }
}
