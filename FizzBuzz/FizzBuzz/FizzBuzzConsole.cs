using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzConsole : IDisplayFizzBuzz
    {
        private IFizzBuzzer _fb;

        public FizzBuzzConsole(IFizzBuzzer fb)
        {
            _fb = fb;
        }

        public void Display(int startNumber, int endNumber)
        {
            for (int number = startNumber; number <= endNumber; number ++)
            {
                Console.WriteLine(_fb.FizzBuzz(number));
            }
        }
    }
}
