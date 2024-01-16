using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Resturant
{
    internal class Program
    {
        private static List<Food> _Pizza = new List<Food>();
        private static List<Food> _Pasta = new List<Food>();
        public Typepizza typepizza { get; set; }
        static void Main(string[] args)

        {
            while (true)
            {
                var option = GetInt("1.add pizza\n2.add pasta\n3.show pizza\n4.show pasta");
                switch (option)
                {
                    case 1:
                        {
                            var PizzaName = GetString("please pizzaname:");
                            var Price = GetDouble("please enter price");
                            var type = GetInt("please choice your type:1.large2 2.mini 3.other");
                               

                            AddPizza(PizzaName, Price, type);
                          


                            break;
                        }
                    case 2:
                        {
                            var PastaName = GetString("please enter pasta name:");
                            var PastaPrice = GetDouble("enter price:");
                            var PastaType = GetInt("enter type of pasta:1.italian2.american3.mexican");

                            AddPasta(PastaName, PastaPrice, PastaType);

                            break;
                        }
                    case 3:
                        {
                            foreach (var pizza in _Pizza)
                            {
                                Console.WriteLine($"piza name is:{pizza.FoodName},pizza price is:{pizza.FoodPrice},pizza type is:{pizza.Type}");
                            }
                            break;
                        }
                    case 4:
                        {
                            foreach(var pasta in _Pasta)
                            {
                                Console.WriteLine($"pasta name is:{pasta.FoodName},pastaprice is{pasta.FoodPrice},pastatype is:{pasta.Type}");
                            }

                            break;
                        }
                    case 5:
                        {
                            Order order = new Order();
                          

                           
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

        static double GetDouble(string message)
        {
            Console.WriteLine(message);
            double value = double.Parse(Console.ReadLine());
            return value;
        }
        static int GetInt(string message)
        {
            Console.WriteLine(message);
            int value = int.Parse(Console.ReadLine());
            return value;
        }
        public static void AddPizza(string PizzaName, double Price, int typePizza)
        {

            var pizza = new Pizza(PizzaName, Price, typePizza);

            pizza.SetPrice(Price);
            _Pizza.Add(pizza);

        }
        public static void AddPasta(string pastaName, double Price, int pastatype)
        {

            var pasta = new Pasta(pastaName, Price, pastatype);

            pasta.SetPrice(Price);
            _Pasta.Add(pasta);

        }

        public void GetType(int type)
        {
            //


            if (type == 1)
            {
                typepizza = Typepizza.large;
            }
            else if (type == 2)
            {
                typepizza = Typepizza.mini;
            }

            else
            {
                typepizza = Typepizza.other;
            }

        }
    }
}
public enum Typepizza
{
    large,
    mini,
    other

}

