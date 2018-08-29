using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion5
{
    class Lektion5
    {
        static void Main(string[] args)
        {

            /*
            //Exercise 1 Classified location
            string inputText = Console.ReadLine();

            if (inputText.StartsWith("Classified:"))
            {
                inputText = inputText.Replace("Area 51", "[AN UNDISCLOSED LOCATION]");
                inputText = inputText.Replace("Classified:", "");
            }
            Console.WriteLine(inputText);
            */

            List<int> numbersSum = new List<int> { };

            while (true)
            {
                    int number = int.Parse(Console.ReadLine());
                    numbersSum.Add(number);
            }


        }
    }
}
