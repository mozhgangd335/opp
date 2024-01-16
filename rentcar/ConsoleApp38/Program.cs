using System;
using ConsoleApp38;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int menu = GetInt("1.add car\n2.show cars\n3.add customer\n4.rent car\n5.showuserrentcar");
                switch (menu)
                {
                    case 1:
                        {
                            var type = GetInt("1.vipcar2.normalcar");
                            var namecar = GetString("enter car name:");
                            var Id = GetInt("enter carid:");
                            var Count = GetInt("enter count:");
                            var Capacity = GetInt("enter capacity");
                            var Price = GetInt("enter price");
                            var Days = GetInt("enter days for rent:");


                            RntCar.AddCar(type, namecar, Id, Capacity, Count, Price, Days);

                            break;
                        }

                    case 2:
                        {
                            foreach (var car in RntCar.Getcars())
                            {
                                Console.Write($"carname:{car.CarName},capacity is:{car.Capacity},count:{car.Count},price:{car.PriceRent},type:{car.Type}");
                            }

                            break;

                        }
                    case 3:
                        {

                            var customerName = GetString("enter customername");
                            RntCar.AddCustomer(customerName);

                            break;
                        }
                    case 4:
                        {
                            var customerName = GetString("customername:");
                            var carName = GetString("carname:");

                            RntCar.Rentcar(carName, customerName);
                            break;


                        }
                    case 5:
                        {

                            RntCar.ShowUser();
                            break;

                        }
                    default:
                        break;
                }
            }
        }
        static string GetString(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();
            return value;
        }

        static int GetInt(string message)
        {
            Console.WriteLine(message);
            int value = int.Parse(Console.ReadLine());
            return value;
        }
    }
}
