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
            string inputText = Console.ReadLine();
            string isSwedish = "";
            int swedishLetters = 0;

            for (int i = 0; i < inputText.Length - 1; i++)
            {
                if (inputText[i] == 'Å' || inputText[i] == 'å' || inputText[i] == 'Ä' || inputText[i] == 'ä' ||
                        inputText[i] == 'Ö' || inputText[i] == 'ö')
                {
                    isSwedish = "Texten verkar vara på svenska";
                    swedishLetters++;
                }
            }
            Console.WriteLine(isSwedish);
            Console.WriteLine("Antal svenska bokstäver: " + swedishLetters);
        }
    }
}
