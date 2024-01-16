using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant
{
    public class Pasta : Food
    {
        public Pasta(string name,double price,int type) : base(name,price,type)
        {
        }
      
        public override void SetPrice(double price)
        {
            if (price > 300000)
            {
                throw new Exception("this price is unusual");
            }
            base.SetPrice(price);
        }
    }
}
