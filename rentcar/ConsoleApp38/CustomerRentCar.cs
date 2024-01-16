using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class CustomerRentCar
    {
        public CustomerRentCar(Customer user, string carName)
        {
            User = user;
            CarName = carName;
            Date = DateTime.Now;
        }
        public Customer User { get; set; }
        public string CarName { get; set; }
        public DateTime Date { get; set; }
    }
}
