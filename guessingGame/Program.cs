using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int RandomNum = rnd.Next(1, 11);

            Console.WriteLine("what is my number?");
            int userGuess = Int32.Parse(Console.ReadLine());

            bool correctGuess = false;

            while (!correctGuess)
            {
                if(RandomNum == userGuess)
                {
                    Console.WriteLine("you won");
                    correctGuess = true;

                }
                else
                {
                    Console.WriteLine("what is your number?");
                    
                    userGuess = Int32.Parse(Console.ReadLine());
                }
               

            }

             
            





        }
    }
}
