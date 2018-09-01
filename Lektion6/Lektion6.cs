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

            /*
            //Exercise 4 Palindrome test
            string text = Console.ReadLine();
            string lower = text.ToLower();
            string reverse = "";
            string textTrim = "";

            for (int i = 0; i < lower.Length; i++)
            {
                if (lower[i] == ' ' || lower[i] == ',' || lower[i] == '!' || lower[i] == '?' || lower[i] == '.' || 
                        lower[i] == ':')
                {
                    textTrim += "";
                }
                else
                {
                    textTrim += lower[i];
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
            */

            /*
            //Exercise 5 Pangram test
            //"abcdefghijklmnopqrstuvwxyz"
            Console.Write("Enter your own alphabet: ");
            string yourAlpha = Console.ReadLine();
            Console.Write("Enter your sentence: ");
            string inputText = Console.ReadLine();
            string iLower = inputText.ToLower();
            List<char> az = yourAlpha.ToCharArray().ToList();

            foreach (char l in iLower)
            {
                for (int a = 0; a < az.Count; a++)
                {
                    if (l == az[a])
                    {
                        az.RemoveAt(a);
                    }
                }
            }
            if (!az.Any())
            {
                Console.WriteLine("Your sentence is a pangram!");
            }
            else
            {
                Console.WriteLine("Not pangram!");
            }
            */

            /*
            //Exercise 6 Censored word from sentence
            Console.WriteLine("Enter your sentence.");
            string sentence = Console.ReadLine();
            string lowerSentence = sentence.ToLower();
            Console.WriteLine("Enter censored words sepertades by a comma.");
            string censoredWords = Console.ReadLine();
            string lowerCensoredWords = censoredWords.ToLower();
            string asterisk = "";

            string[] censWord = lowerCensoredWords.Trim().Split(new Char[] { ',' , ' ' });


            foreach (string s in censWord)
            {
                asterisk = "";
                for (int i = 0; i < s.Length; i++)
                {
                    asterisk += "*";
                }
                if (lowerSentence.Contains(s))
                {
                    lowerSentence = lowerSentence.Replace(s, asterisk);
                }
            }
            Console.WriteLine(lowerSentence);
            */

            /*
            //Exercise 7 Domain name extraction
            string email = Console.ReadLine();
            string domain = "";
            string finalDomain = "";
            int atSign = 0;
            int lastComma = 0;

            while (email[atSign] != '@')
            {
                atSign++;
            }
            for (int i = atSign + 1; i < email.Length; i++)
            {
                domain += email[i];
            }
            while (domain[lastComma] != '.')
            {
                lastComma++;
            }
            for (int i = 0; i < lastComma; i++)
            {
                finalDomain += domain[i];
            }
            Console.WriteLine(finalDomain);
            */


        }
    }
}
