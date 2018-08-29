using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion4
{
    class Lektion4
    {
        static void Main(string[] args)
        {
            //string before = Console.ReadLine();
            //string after = "";
            //for (int i = 0; i < before.Length; i++)
            //{
            //    if (before[i] == '_')
            //    {
            //        after += ' ';
            //    }
            //    else
            //    {
            //        after += before[i];
            //    }
            //}

            //string text = Console.ReadLine();
            //int spaces = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == ' ')
            //    {
            //        spaces += 1;
            //    }
            //}
            //Console.WriteLine("Number of spaces: " + spaces);

            /*
            //Exercise 1 Last char deletion
            string cutLast = Console.ReadLine();
            string after = "";

            for (int i = 0; i < cutLast.Length; i++)
            {
                if (i == cutLast.Length - 1)
                {
                    after += "";
                }
                else
                {
                    after += cutLast[i];
                }
            }
            Console.WriteLine(after);
            */

            /*
            //Exercise 2 Hyphens 
            string text = Console.ReadLine();
            string hyphens = "";

            for (int i = 0; i < text.Length ; i++)
            {
                if (i < text.Length - 1)
                {
                    hyphens += text[i] + "-";
                }
                else
                {
                    hyphens += text[i];
                }
            }
            Console.WriteLine(hyphens);
            */

            /*
            //Exercise 3 Reverse string
            string text = Console.ReadLine();
            string reverse = "";

            foreach (char letter in text)
            {
                reverse = letter + reverse;
            }
            Console.WriteLine(reverse);
            */

            
            //Exercise 4 Removing vowels
            string text = Console.ReadLine();
            string vowels = "YyAaEeIiOoUu";
            string removedVowels = "";
            int hitVowel = 0;

            //foreach (char t in text)
            //{
            //    foreach (char v in vowels)
            //    {
            //        if (t == v)
            //        {
            //            hitVowel++;
            //        }
            //    }
            //    if (hitVowel > 0)
            //    {
            //        removedVowels = removedVowels + text[t];
            //    }
            //}


            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' ||
                        text[i] == 'u' || text[i] == 'y')
                {

                }
                else
                {
                    removedVowels = removedVowels + text[i];
                }
            }
            Console.WriteLine(removedVowels);


            /*
            //Exercise 5 Every other asterisk
            string text = Console.ReadLine();
            string asterisk = "";


            for (int i = 0; i < text.Length; i += 2)
            {
                if (i == i + 1)
                {
                    asterisk += '*';
                }
                else
                {
                    asterisk += text[i];
                    asterisk += '*';
                }
            }
            Console.WriteLine(asterisk);
            */

            /*
            //Exercise 6 Counting a's
            string text = Console.ReadLine();
            int numberOfA = 0;


            foreach (char n in text)
            {
                if (n == 'a')
                {
                    numberOfA += 1;
                }
            }
            Console.WriteLine(numberOfA);
            */

            /*
            //Exercise 9 Search for word in sentence
            string input = Console.ReadLine();
            string search = Console.ReadLine();
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < search.Length; j++)
                {
                    char temp = search[j];
                    result += temp;
                    if (result == search)
                    {
                        Console.WriteLine("True");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("False");
                        break;
                    }
                }
            }
            

            string name = Console.ReadLine();
            string contain = Console.ReadLine();
            bool nameContain = name.Contains(contain);

            Console.WriteLine(nameContain);
            */

            /*List<int> numbers = new List<int> { 9, 6, 5 };
            numbers.Add(8);
            numbers.Remove(6);
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
            */
        }
    }
}
