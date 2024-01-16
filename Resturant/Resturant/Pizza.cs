using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant
{
    public class Pizza : Food
    {
        public Pizza(string name, double price, int type) : base(name, price, type)
        {

        }
      
        public override void SetPrice(double price)

        {
            if (price > 500000)
            {
                throw new Exception("this price is unusual");
            }
            base.SetPrice(price);
        }
        }
    }

   
