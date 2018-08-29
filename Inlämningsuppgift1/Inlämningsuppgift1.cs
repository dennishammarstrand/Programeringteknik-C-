using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift1
{
    class Inlämningsuppgift1
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.GetEncoding("ISO-8859-1");

            string inputText = Console.ReadLine();
            string swedishL = "ÅåÄäÖö";
            string danishL = "ÅåÆæØø";
            int countSwLetters = 0;
            int countDaLetters = 0;
            string translated = "";
            int åCounter = 0;
            int äCounter = 0;
            int öCounter = 0;

            foreach (char i in inputText)
            {
                foreach (char s in swedishL)
                {
                    if (i == s)
                    {
                        countSwLetters++;
                    }
                }
            }
            foreach (char å in inputText)
            {
                if (å == 'Å' || å == 'å')
                {
                    åCounter++;
                }
            }
            foreach (char ä in inputText)
            {
                if (ä == 'Ä' || ä == 'ä')
                {
                    äCounter++;
                }
            }
            foreach (char ö in inputText)
            {
                if (ö == 'Ö' || ö == 'ö')
                {
                    öCounter++;
                }
            }
            foreach (char i in inputText)
            {
                foreach (char d in danishL)
                {
                    if (i == d)
                    {
                        countDaLetters++;
                    }
                }
            }
            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] == 'Å' || inputText[i] == 'å' || inputText[i] == 'Ä' || inputText[i] == 'ä')
                {
                    translated += 'a';
                }
                else if (inputText[i] == 'Ö' || inputText[i] == 'ö')
                {
                    translated += 'o';
                }
                else
                {
                    translated += inputText[i];
                }
            }
            if (countSwLetters > 0 && countSwLetters >= countDaLetters)
            {
                Console.WriteLine("Texten verkar vara på svenska!");
                Console.WriteLine("Antal svenska bokstäver: " + countSwLetters);
            }
            else if (countDaLetters > countSwLetters)
            {
                Console.WriteLine("Texten verkar vara på danska!");
                Console.WriteLine("Antal danska bokstäver: " + countDaLetters);
            }
            else
            {
                Console.WriteLine("Texten verkar inte vara på svenska!");
                Console.WriteLine("Antal svenska bokstäver: " + countSwLetters);
            }
            Console.WriteLine("Antal Å: " + åCounter);
            Console.WriteLine("Antal Ä: " + äCounter);
            Console.WriteLine("Antal Ö: " + öCounter);
            Console.WriteLine("Texten utan svenska bokstäver: " + translated);
        }
    }
}
