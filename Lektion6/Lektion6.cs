using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion6
{
    class Lektion6
    {
        static void Main(string[] args)
        {

            /*
            //Exercise 1 Repeat text
            string text = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string multiText = "";

            for (int i = 0; i < number; i++)
            {
                multiText += text;
            }
            Console.WriteLine(multiText);
            */

            /*
            //Exercise 2 Word reverse
            string text = Console.ReadLine();
            string reverse = "";

            foreach (char t in text)
            {
                reverse = t + reverse;
            }
            Console.WriteLine(reverse);
            */

            /*
            //Exercise 3 Password input correct
            string password = Console.ReadLine();

            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                Console.WriteLine("Correct password input!");
            }
            else
            {
                Console.WriteLine("Incorrect password input!");
            }
            */

            
            string text = Console.ReadLine();
            string reverse = "";
            string textTrim = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    textTrim += "";
                }
                else
                {
                    textTrim += text[i];
                }
            }
            foreach (char t in textTrim)
            {
                reverse = t + reverse;
            }
            if (textTrim == reverse)
            {
                Console.WriteLine("It's a palindrome!");
            }
            else
            {
                Console.WriteLine("It's not a palindrome!");
            }
            
        }
    }
}
