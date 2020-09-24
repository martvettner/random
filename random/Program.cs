using System;
using System.Diagnostics.CodeAnalysis;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int MyRandomNum = rnd.Next(1, 11);
            Console.WriteLine("what is your number form 1 to 10");
            int userguess = Int32.Parse(Console.ReadLine());

            if(MyRandomNum == userguess)
            {
                Console.WriteLine("congratulations! you have played me");

            }
            else
            {
                Console.WriteLine($"wrong. my random number is {MyRandomNum}");
            }



        }
    }
}
