using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
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
            var option = AddInt("1:add student 2:Show Student");
            switch (option)
            {
                case 1:
                    {
                        var type = AddInt("1_add student -  2_add universitystudentt - 3_guessstudent");
                        var name = AddString("enter name:");
                        var studentID = AddInt("enter studentid");
                        var course = AddString("enter your courser");
                        University.AddStudent(name,studentID,type,course);
                        break;
                    }
                case 2:
                    {
                        University.ShowStudent();
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

