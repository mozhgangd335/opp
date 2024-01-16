using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant
{
   public class Order
    {
         public List<Food> Foods { get; set; }
        public Order()
        {
            Foods = new List<Food>();
        }
        public void AddFood(Food food)
        {
            Foods.Add(food);
            Console.WriteLine($"add{food.FoodName}");
        }
            public void DeleteFood(Food food)
        {
            Foods.Remove(food);
            Console.WriteLine($"delete{food.FoodName}");

        }
        public void PrintOrder()
        {
            foreach(var item in Foods)
            {
                Console.WriteLine($"{item.FoodName},{item.FoodPrice}");
            }
        }
    }
}
