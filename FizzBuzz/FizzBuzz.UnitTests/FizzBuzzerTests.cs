using System;
using Xunit;

namespace FizzBuzz.UnitTests
{
    public class FizzBuzzerTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void FizzBuzzer_GivenInt_Return_String(int number, string expected)
        {
            IFizzBuzzer fb = new FizzBuzzer();
            string actual = fb.FizzBuzz(number);
            Assert.Equal(expected, actual);
        }
    }
}
