using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class RentedCars : Car
    {
        public RentedCars(int type,string carName,int pricerent, int capacity, int count) : base(type,carName, pricerent, capacity, count)
        {

        }
        public int RentDays { get; set; }
        public int RentCount { get; private set; }
        public override void SetCount(int count)

        {
            if (count == 0)
            {
                Console.WriteLine("we dont have any car");
            }
            base.SetCount(count);
        }
        public void Rent()
        {
            if (Count == 0)
            {
                throw new Exception();
            }

            RentCount++;
            var newCount = Count;
            SetCount(--newCount);

        }
        public void CalRentPrice()

        {
            if (RentDays > 10)
            {
                PriceRent = PriceRent * 2;

                PriceRent = PriceRent * RentDays;

            }
            else
            {
                PriceRent = PriceRent * RentDays;
            }
        }
    }
}

