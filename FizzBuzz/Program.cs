using System;

namespace fizzbuzz
{
    public class Program
    {

        public static string FizzBuzz(int num)
        {
            if (num == 0) { return "null"; }
            string result = (num % 3 == 0 && num % 5 == 0)? "fizzbuzz": (num % 3 == 0)? "fizz": (num % 5 == 0)? "buzz": "null";
            Console.WriteLine(result);
            return result;
        }


        public static void Main(string[] args)
        {
            FizzBuzz(3);
            FizzBuzz(5);
            FizzBuzz(15);
            FizzBuzz(-5);
            FizzBuzz(0);
        }


    }
}
