using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate.cs
{
    class Calculator:Ical

    {public Calculator(int number1, int number2)

        {
            Number1 = number1;
            Number2 = number2;
           
        }
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        
       
      public int Plus(int number1, int number2)
        {
            return number1 + number2;

        }

        public int Minus(int number1, int number2)
        {
         
             return number1 - number2; 
        }

        public int Multiple(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Divide(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new Exception("error");
            }
            return number1 / number2;
        }
    }
}
