

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static object Game;

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
                    Console.WriteLine(exception.Message);
                }
            }


        }
        static void Run()
        {

            var option = GetInt("1.add gamer 2.attak");
            switch (option)
            {
                case 1:
                    {
                        var gamerType = GetInt("1.hero 2.enemy 3.other");
                        var gamerName = GetString("please enter name");
                        var gamerSpeed = GetInt("pleae enter speed");
                        var gamerPower = GetInt("please enter power");
                        Game.AddGamers(gamerName, gamerSpeed, gamerPower, gamerType);


                        break;

                    }
                case 2:
                    {

                        var attacker1 = GetString("enter name of attacker1");
                        var attacker2 = GetString("enter name of attacker2");
                        Game.Fight(attacker1, attacker2);


                        break;
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
    

