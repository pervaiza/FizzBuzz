using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer : IFizzBuzzer
    {
        public string FizzBuzz(int number)
        {
            string result = string.Empty;

            if (number % 3 == 0)
            {
                result += "Fizz";
            }

            if (number % 5 == 0)
            {
                result += "Buzz";
            }

            if (result == string.Empty)
            {
                result = number.ToString();
            }

            return result;
        }
    }
}
