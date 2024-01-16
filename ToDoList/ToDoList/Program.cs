using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Run();
                }
                catch (Exception exception)
                {
                    ShowError(exception.Message);
                }
            }
        }
        static void Run()
        {
            var option = AddInt("1:add duty \n2:Show duty");
            switch (option)
            {
                case 1:
                    {

                        var type = AddInt("1_personalduty -  2_jobduty");



                        var DutyName = AddString("name of duty");
                        var hour = AddInt("hours need for duty");
                        var priority = AddInt("Priority of duty:");
                        var days = AddInt("days need to duty:");
                        var datetime = DateTime.Now;

                        Duty.ADDTasks(type, DutyName, priority,datetime, hour);

                        break;
                    }
                case 2:
                    {

                        Duty.ShowTasks();
                        break;
                    }
                default:
                    break;
            }

        }
        public static int AddInt(string messege)
        {
            int getIntegerValue;
            bool result;
            do
            {
                Console.WriteLine(messege);
                result = int.TryParse(Console.ReadLine(), out getIntegerValue);
            } while (!result);
            return getIntegerValue;
        }
        static void ShowError(string error)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine(error);
            Console.WriteLine("-------------------");
        }
        public static string AddString(string messege)
        {
            string result;
            do
            {
                Console.WriteLine(messege);
                result = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(result));
            return result;
        }


    }
    }

