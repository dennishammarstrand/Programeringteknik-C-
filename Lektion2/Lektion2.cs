using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            /*
            Console.Write("Please enter exam score: ");
            int score = int.Parse(Console.ReadLine());
            string grade;
            if (score < 50)
            {
                grade = "F";
            }
            else
            {
                if (score < 60)
                {
                    grade = "E";
                }
                else
                {
                    if (score < 70)
                    {
                        grade = "D";
                    }
                    else
                    {
                        grade = "C";
                    }
                }
            }
            */

            /*
            //Exercise 1 Correct password
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            string correctPassword = "secret123";

            if (password == correctPassword)
            {
                Console.Write("Access granted!");
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
            */

            /*
            //Exercise 2 Correct age
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.Write("Access granted!");
            }
            else
            {
                Console.Write("Access denied!");
            }
            */

            /*
            //Exercise 3 Allowed temprature
            Console.Write("Enter temprature in celsius: ");
            int temp = int.Parse(Console.ReadLine());

            string correctTemp;
            if (temp < 18)
            {
                correctTemp = "Temprature to low.";
            }
            else if (temp > 26)
            {
                correctTemp = "Temprature to high.";
            }
            else
            {
                correctTemp = "Accaptable temprature.";
            }
            Console.WriteLine(correctTemp);
            */

            /*
            //Exercise 4 President checkout 
            Console.Write("Enter birthcountry: ");
            string country = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter number of times elected: ");
            int elected = int.Parse(Console.ReadLine());
            Console.Write("Have you saved the world: ");
            string worldSaver = (Console.ReadLine());

            if (country == "United States" && age >= 35 && elected <= 1)
            {
                Console.Write("You can be president!");
            }
            else if (country == "United States" && age >= 35 && elected <= 1 || worldSaver == "Yes")
            {
                Console.Write("You saved the world! You can be president!");
            }
            else
            {
                Console.Write("Unfortunatley, you cannot be president.");
            }
            */

            /*
            //Exercise 5 Boolean expressions
            Console.Write("Yes or No?: ");
            string answear = Console.ReadLine();
            Console.Write("1 or 2: ");
            int number = int.Parse(Console.ReadLine());

            if (answear == "Yes" && number == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            */

            /*
            //Exercise 6 Decision flowchart
            Console.ForegroundColor = ConsoleColor.Green;
            for (; ; )
            {
                Console.WriteLine("Explore Sweden!");
                Console.Write("What do you want to see? ");
                string sightseeing = Console.ReadLine();


                if (sightseeing == "Forest")
                {
                    Console.WriteLine("Then you should go to Småland!");
                    Console.Write("Wanna go hiking when you visit here? ");
                    string hiking = Console.ReadLine();

                    if (hiking == "Yes")
                    {
                        Console.WriteLine("Then you should visit Johan for rentals!");
                    }
                    else
                    {
                        Console.Write("No worries have a nice day!");
                        Console.ReadKey();
                        break;
                    }
                }
                else if (sightseeing == "Mountains")
                {
                    Console.WriteLine("Then you should visit Lappland!");
                    Console.Write("Wanna go climbing when your here? ");
                    string climbing = Console.ReadLine();

                    if (climbing == "Yes")
                    {
                        Console.WriteLine("Then you should visit Alex for equipment!");
                    }
                    else
                    {
                        Console.Write("No worries have a nice day!");
                        break;
                    }
                }
                else if (sightseeing == "Cities")
                {
                    Console.WriteLine("Then you should go to Stockholm!");
                    Console.Write("Wanna eat at a famous restaurant when your here? ");
                    string restaurant = Console.ReadLine();

                    if (restaurant == "Yes")
                    {
                        Console.WriteLine("Then you should hit up Sara for reservations!");
                    }
                    else
                    {
                        Console.Write("No worries have a nice day!");
                        break;
                    }
                }
                else
                {
                    Console.Write("Invalid input.");                    
                }
                Console.ReadKey();
                Console.Clear();
            }
            */

            /*
            //Exercise 7 De Morgan Operator switch
            Console.Write("Enter x value: ");
            bool x = bool.Parse(Console.ReadLine());
            Console.Write("Enter y value: ");
            bool y = bool.Parse(Console.ReadLine());

            bool result = !x || !y;
            Console.Write(result);
            */
        }
    }
}
