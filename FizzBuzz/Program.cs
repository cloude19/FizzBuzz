using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Play Fizz Buzz! \n");
            FizzBuzz(100, new int[] {3,5},false);
        }

        /// <summary>
        /// Start FizzBuzz game with the Max value determening the last value in the game.
        /// Play: determines if the game is being played or if a list is just being generatd.
        /// Default Starting value is 0
        /// </summary>
        /// <param name="Max"></param>
        /// <param name="Play"></param>
        static void FizzBuzz(int Max, int[] Multiples ,bool Play)
        {
            int multiOne = Multiples[0];
            int multiTwo = Multiples[1];

            if (Play == false)
            {
                for (int x = 1; x < Max + 1; x++)
                {
                   int remainderOne = x % multiOne;
                   int remainderTwo = x % multiTwo;

                    if(remainderOne == 0 && remainderTwo == 0) //<- check this first
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if(remainderOne == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if(remainderTwo == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(x);
                    }
                }
            }

        }
    }
}
