using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class CarVip:Car

    {
        public CarVip(int type, string carName,int pricerent, int capacity,int count) : base(type,carName, pricerent, 8,count)
        {

        }
        
        public int RentDays { get; set; }
        public int RentCount { get; private set; }
        public override void SetCount(int count)
        {
            if (count > 100)
            {
                throw new Exception("error");
            }
            base.SetCount(count);
        }
            
        }
    }

