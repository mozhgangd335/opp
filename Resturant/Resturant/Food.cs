using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant
{
    public abstract class Food
    {
        public Food(string name, double price,int type)
        {
            FoodName = name;
            FoodPrice = price;
            Type = type;
        }
            public int Type { get; set; }
        public string FoodName { get; set; }
        public double FoodPrice { get;private set; }
        public virtual void SetPrice(double price)
        {
            if (FoodPrice<=0)
            {
                throw new Exception("error");

            }FoodPrice = price;
        }

    }
    
}
