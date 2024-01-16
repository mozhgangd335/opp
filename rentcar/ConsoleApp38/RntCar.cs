using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public static class RntCar
    {
       
        private static List<Car> _Cars = new List<Car>();
        private static List<Customer> _Customers = new List<Customer>();

        public static void AddCar(int type,string name, int id, int capacity, int count, int price, int days)
        {
            if (type==1)
            {
                var vipcar = new CarVip(type,name, price, 8, count);
                vipcar.Count = count;
                vipcar.Capacity = 8;
                vipcar.PriceRent = price;
                vipcar.RentDays = days;
                //vipcar.Id = id;
                _Cars.Add(vipcar);
            }
            if (type==2)
            {
                var normalcar = new CarNormal(type,name, price, 4, count);

                normalcar.CarName = name;
                //normalcar.Id = id;
                normalcar.Capacity = 4;
                normalcar.PriceRent = price;
                normalcar.Days = days;
                _Cars.Add(normalcar);

            }

        }
        public static void AddCustomer(string customername)
        {
            var Customer = new Customer(customername);
            _Customers.Add(Customer);
        }

        public static void Rentcar(string carname, string customername)
        {
            var car = _Cars.Find(_ => _.CarName == carname);
            if (car is null)
            {
                throw new Exception("this car doesn't found");
            }

            var customer = _Customers.Find(_ => _.CustomerName == customername);


            var rentcar = car as RentedCars;

            rentcar.Rent();
            
            customer.SetRentCar(car);
            rentcar.CalRentPrice();

        }

      

        public static void ShowUser()
        {
            foreach (var user in _Customers)
            {
                Console.WriteLine($"username:{user.CustomerName}");
                foreach (var item in user.GetUserRentCars())
                {
                    Console.WriteLine($"username:{item.User} - namerentcar:{item.CarName} - timeofrent{item.Date}");
                }
            }
        }
            public static List<Car> Getcars()
            {
                return _Cars;
            }


            //public static List<Customer> Getcustomers()
            //{
            //    return _Customers;
            //}


        }
    }

