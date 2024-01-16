using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            var Name = GetString("please enter your name:");
            var Id = GetInt("enter your id:");
            var Salary = GetDouble("enter your salary");
            var department = GetString("enter your department:");
            Manager manager = new Manager(Name, Id, Salary,department);
            manager.PrintDetails();
            Console.ReadKey();
        }

        

        public static string GetString(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();
            return value;
        }
        public static int GetInt(string message)
        {
            Console.WriteLine(message);
            var value = int.Parse(Console.ReadLine());
            return value;
        }
        public static double GetDouble(string message)
        {
            Console.WriteLine(message);
            var value = double.Parse(Console.ReadLine());
            return value;
        }

    }
}