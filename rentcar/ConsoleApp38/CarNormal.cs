using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class CarNormal : Car
    {
        public CarNormal(int type,string carName, int pricerent, int capacity, int count) : base( type,carName, pricerent, 4, count)
        {

        }
        public int Days { get; set; }
        public  int RentNormalCount{get;set;}
        public override void SetCount(int count)

        {
            if (count > 20)
            {
                throw new Exception("error");
            }
            base.SetCount(count);
        }

        //public void RentNormal()
        //{
        //    if (Count == 0||PriceRent<=0)
        //    {
        //        throw new Exception();
        //    }
           
        //        RentNormalCount++;
        //        var newCount = Count;
        //        SetCount(--newCount);
        //    PriceRent = PriceRent * Days;
            
                
        //    }
        }

          

        }
    
   


