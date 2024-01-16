using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
   
    class Program
    {
        private static string name;

        static void Main(string[] args)

        {
            List<Person> persons = new List<Person>();
            while (true)
            {
                var option = GetInt("1.add person\n2.show persons");
                switch (option)
                {
                    case 1:
                        {
                            var FirstName = GetString("enter your firstname");
                            var LastName = GetString("enter your LastName");
                            var person = new Person(FirstName, LastName);
                            persons.Add(person);
                            
                            break;
                        }
                    case 2:
                        {
                            foreach (var item in persons)
                            {
                                item.GetFullName(item.FirstName, item.LastName);
                            }
                            break;
                        }
                }
            } 
    } public static string GetString(string message)
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
    } }
