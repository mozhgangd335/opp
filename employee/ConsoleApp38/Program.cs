using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    { private static List<Employee> Managers = new List<Employee>();

        static void Main(string[] args)

        {
            
            while (true)
            {
                var option = GetInt("1.add manager\n2.show manager");
                switch (option)
                {
                    case 1:
                        {

                            var Name = GetString("please enter your name:");
                            var Id = GetInt("please enter your id");
                            var Salary = GetInt("please enter salary:");
                            //var Department = GetString("please enter your department:");
                            var manager = new Manager(Name, Id,Salary);
                            Managers.Add(manager);
                            break;
                        }
                    case 2:
                        {
                            foreach (var employee in Managers)
                            {
                                employee.PrintDetails(employee.Name, employee.EmployeeId,employee._Salary);
                               

                            }
                            break;
                            

                        }
                    default:
                        {
                            throw new Exception("you can,t choose another choice");
                        }
                }
            }
        }

            public static void Employee(string name, int id, int salary)
            {

            }

            static string GetString(string message)
            {
                Console.WriteLine(message);
                string value = Console.ReadLine();
                return value;
            }

            static int GetInt(string message)
            {
                Console.WriteLine(message);
                int value = int.Parse(Console.ReadLine());
                return value;
            }
        }
    } 