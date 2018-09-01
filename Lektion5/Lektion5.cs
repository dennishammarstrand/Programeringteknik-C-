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

            /*
            //Exercise 2 Sum inputed numbers
            List<int> numbers = new List<int> { };

            while (true)
            {
                string text = Console.ReadLine();
                bool enterKey = text == "";

                if (!enterKey)
                {
                    int number = int.Parse(text);
                    numbers.Add(number);
                }
                else
                {
                    break;
                }
            }
            int total = numbers.Sum();
            Console.WriteLine(total);
            */
            
            Dictionary<string, int> words = new Dictionary<string, int>();
            string text = Console.ReadLine();
            string lText = text.ToLower();

            string[] split = lText.Split(new Char[] { ' ', ',', '.', ':', '?' });

            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    if (words.ContainsKey(s))
                    {
                        words[s] = words[s] + 1;
                    }
                    else
                    {
                        words[s] = 1;
                    }
                }
            }
            foreach (KeyValuePair<string, int> pair in words)
            {
                if (pair.Value == words.Values.Max())
                {
                    Console.WriteLine("The most frequent word is: " + pair.Key );
                }
            }
        }
    }
}
