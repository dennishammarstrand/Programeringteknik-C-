using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion1
{
    class Lektion1
    {
        static void Main(string[] args)
        {
            /*// Ask the user for input.
            Console.Write("Please enter distance of trip in kilometers: ");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            // Compute the right ticket price.
            int longThreshold = 10;
            int adultThreshold = 20;
            int price;
            if (distance < longThreshold && age < adultThreshold)
            {
                price = 2;
            }
            else if (distance < longThreshold)
            {
                price = 3;
            }
            else
            {
                price = 6;
            }
            // Output the price to the user.
            Console.WriteLine("This trip will cost $" + price);
            Console.ReadLine();
            */
            System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            /*
            // Input
            Console.Write("Please enter your weight: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Please enter your height: ");
            double height = double.Parse(Console.ReadLine());
            // Computation
            double bmi = weight / Math.Pow(height, 2);
            // Output
            Console.WriteLine("Your BMI is: " + bmi);
            Console.ReadLine();
            */

            /*
            //Exercise 1 Math presentations
            int b = 5 + 2 * 7;
            Console.WriteLine(b);

            int c = (10 + 2) / 3;
            Console.WriteLine(c);

            int d = (3 * 8) / (4 * 2);
            Console.WriteLine(d);
            */

            /*
            //Exercise 2 Net worth program
            Console.Write("Please enter your cash amount: ");
            int cash = int.Parse(Console.ReadLine());
            Console.Write("Please enter your bank account amount: ");
            int bank = int.Parse(Console.ReadLine());
            Console.WriteLine("Your have a total of $" + (cash+bank));
            Console.ReadLine();
            */

            /*
            //Exercise 3 Fahrenheit to Celcius program
            Console.Write("Please enter temprature in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 0.56;
            Console.Write("Temprature in Celcius: " + celsius);            
            Console.ReadLine(); 
            */

            /*
            //Exercise 4 Lowest value program
            Console.WriteLine("Please input three numbers.");
            Console.Write("Number 1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Number 2: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Number 3: ");
            int number3 = int.Parse(Console.ReadLine());
            int smallestnumber = Math.Min(Math.Min(number1, number2), number3);
            //int smallest = Math.Min(smallestnumber, number3);
            Console.Write("The smallest number is: " + smallestnumber);
            */

            /*
            //Exercise 5 Distance between coordinates
            Console.WriteLine("Please input x and y coordinates.");
            Console.Write("Coordinate x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Coordinate y1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Coordinate x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Coordinate y2: ");
            int y2 = int.Parse(Console.ReadLine());

            int xDistance = x2 - x1;
            int yDistance = y2 - y1;
            double distance = Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2));
            Console.Write("The distance between x and y is: " + distance);
            Console.ReadLine();
           */

            /*
            //Exercise 6 Candies for each child
            Console.Write("Number of children: ");
            int children = int.Parse(Console.ReadLine());
            Console.Write("Number of candies: ");
            int candies = int.Parse(Console.ReadLine());

            double candyPerChild = (double) candies / children;
            Console.Write("Candies per child: " + candyPerChild);
            Console.ReadLine();
            */

            /*
            //Exercise 7 Seconds converter
            Console.Write("Enter number of seconds: ");
            int time = int.Parse(Console.ReadLine());

            int seconds = time % 60;
            int minutes = (time / 60) % 60;
            int hours = time / (60 * 60);
            Console.Write("" + hours + "h, " + minutes + "m, " + seconds + "s, ");
            Console.ReadLine();
            */
        }
    }
}
