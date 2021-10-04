using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            int endNumber = 100;

            IFizzBuzzer fb = new FizzBuzzer();
            IDisplayFizzBuzz displayFizz = new FizzBuzzConsole(fb);
            displayFizz.Display(startNumber, endNumber);

            Console.Read();
        }
    }
}
