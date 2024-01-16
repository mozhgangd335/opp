using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Customer
    {
        private List<CustomerRentCar> _userRentCars = new List<CustomerRentCar>();
        public Customer(string customername)
        {
            CustomerName = customername;
            _userRentCars = new List<CustomerRentCar>();
        }
        public string CustomerName { get; set; }

        public void SetRentCar(Car car)
        {
            _userRentCars.Add(new CustomerRentCar(this, car.CarName));
        }
        public List<CustomerRentCar> GetUserRentCars()
        {
            return _userRentCars;
        }

    }
}
