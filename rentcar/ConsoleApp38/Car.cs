using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public abstract class Car
    {


        public Car(int type, string carName, int pricerent, int capacity, int count)
        {
            Capacity = capacity;
            Count = count;
            Type = type;
            CarName = carName;
            PriceRent = pricerent;
            //Duration = new Duration(int number);

        }
        
        public int Type { get; set; }
        public string CarName { get; set; }
        //public int Id { get; set; }
        public int Count { get; set; }
      // public int Days { set; get; }
        public int Capacity { get; set; }
        public int PriceRent { get; set; }
        //public DateTime RentStart { get; set; } = DateTime.Now;
       // public Duration Duration { get; protected set; }
        public bool IsBackCar { get; set; } = false;


        public virtual void SetPrice(int rentprice)
        {
            if (rentprice < 0)
            {
                throw new Exception("The price cannot be less than zero");
            }

           PriceRent= rentprice;
        }
        public virtual void SetCount(int count)
        {
            if (count < 0)
            {
                throw new Exception("The count cannot be less than zero");
            }

            count = count;
        }
       
    } }
    

