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

            /*
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
            */

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


            foreach (char t in text)
            {
                if (t == 'a')
                {
                    numberOfA++;
                }
            }
            Console.WriteLine(numberOfA);
            */

            /*
            //Exercise 7 Trim start
            string text = Console.ReadLine();
            string trimed = "";
            int firstLetterIndex = 0;
            int lastLetterIndex = 0;

            while (text[firstLetterIndex] == ' ')
            {
                firstLetterIndex++;
            }
            for (int i = firstLetterIndex; i < text.Length; i++)
            {
                trimed += text[i];
            }
            Console.WriteLine(trimed);
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

            //              ARRAYS

            /*
            //Exercise 1 Double each array value
            int[] numbers = { 5, 12, 4 };

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
                Console.WriteLine(numbers[i]);
            }
            */

            /*
            //Exercise 2 Change every other value to 0
            int[] numbers = { 5, 5, 5, 5, 5 };

            for (int i = 0; i < numbers.Length; i += 2)
            {
                numbers[i] = 0;
            }
            */

            /*
            //Exercise 3 Cap of integers
            int[] numbers = { 5, 12, -3, 7 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
                else if (numbers[i] > 10)
                {
                    numbers[i] = 10;
                }
            }
            */

            /*
            //Exercise 4 Greater than 10 result
            int[] numbers = { 5, 12, 7, 100 };
            int greater = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 10)
                {
                    greater++;
                }
            }
            Console.WriteLine(greater);
            */

            /*
            //Exercise 5 Repeat array
            int[] numbers = { 1, 2, 3 };
            int[] newNumbs = new int[6];
            int counter = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    newNumbs[counter] = numbers[j];
                    counter++;
                }
            }
            */

            /*
            //Exercise 6 Remove 0's from array
            int[] array1 = { 5, 0, 7, 0, 2 };
            int[] array2 = new int[3];
            int a2Counter = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != 0)
                {
                    array2[a2Counter] += array1[i];
                    a2Counter++;
                }
            }
            */
        }
    }
}
