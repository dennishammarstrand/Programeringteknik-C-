using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lektion3
{
    class Lektion3
    {
        static void Main(string[] args)
        {
            //int max = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int counter = 1;
            //while (counter <= max)
            //{
            //    Console.WriteLine("Iteration " + counter);
            //    sum += counter;
            //    counter += 1;
            //}

            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.WriteLine("Pair: " + i + " and " + j);
            //    }
            //}

            /*
            //Exercise 1 Integers between
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = x;

            while (sum >= x && sum <= y)
            {
                Console.WriteLine(sum);
                sum++;
            }
            */

            /*
            //Exercise 1 Space launch
            Console.WriteLine("Length of countdown?: ");
            int x = int.Parse(Console.ReadLine());

            for (int y = x; y >= 1; y--)
            {
                Console.WriteLine(y);
                Thread.Sleep(1000);
            }
            Console.WriteLine("takeoff!");
            */

            /*
            //Exercise 2 Factorial integer
            Console.WriteLine("Input integer: ");
            int x = int.Parse(Console.ReadLine());
            int sum = x;

            for (int i = 1; i < x; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine(sum);
            */

            /*
            //Exercise 3 Sum of even and odd numbers
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= number; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            */

            /*
            //Exercise 4 Fizzbuzz
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            */

            /*
            //Exercise 5 Dice possibilities
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Console.WriteLine("(" + i + "," + j + ")");
                }
            }
            */
            /*
            //Exercise 5.2
            Console.WriteLine("Enter desired dice sum: ");
            int sum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if ((i + j) >= sum)
                    {
                        Console.WriteLine("(" + i + "," + j + ")");
                    }
                }
            }
            */
            /*
            //Exercise 5.3
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Console.WriteLine("(" + i + "," + j + ")");
                }
            }
            */
            /*
            //Exercise 5.4
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    for (int k = 1; k <= 6; k++)
                    {
                        Console.WriteLine("(" + i + "," + j + "," + k + ")");
                    }
                }
            }
            */
            
            /*
            //Exercise 6 Wheat and chessboard problem
            int sum = 1;
            for (int i = 1; i <= 24; i++)
            {
                Console.WriteLine(sum);
                sum *= 2;
            }
            */
        }
    }
}
