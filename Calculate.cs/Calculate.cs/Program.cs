using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate.cs
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                int menu = GetInt("1.sum\n2.minus\n3.divid\n4.multiple");

                switch (menu)
                {
                    case 1:
                        {

                            var number1 = GetInt("please enter number1");
                            var number2 = GetInt("please enter number2");
                            
                            var cal = new Calculator(number1, number2);
                            cal.Plus(number1, number2);
                            Console.WriteLine($"plus is:{cal.Plus(number1, number2)}");

                          

                            break;
                        }
                    case 2:
                        {


                            var number1 = GetInt("please enter number1");
                            var number2 = GetInt("please enter number2");

                            var cal = new Calculator(number1, number2);
                            cal.Minus(number1, number2);
                            Console.WriteLine($"minus is:{cal.Minus(number1, number2)}");

                            break;
                        }

                    case 3: {


                            var number1 = GetInt("please enter number1");
                            var number2 = GetInt("please enter number2");

                            var cal = new Calculator(number1, number2);
                            cal.Divide(number1, number2);
                            Console.WriteLine($"divid id is:{cal.Divide(number1, number2)}");


                            break;

                        }
                    case 4:
                        {

                            var number1 = GetInt("please enter number1");
                            var number2 = GetInt("please enter number2");

                            var cal = new Calculator(number1, number2);
                            cal.Multiple(number1, number2);
                            Console.WriteLine($"multiple is:{cal.Multiple(number1, number2)}");

                            break;

                        }

                }


            }


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
