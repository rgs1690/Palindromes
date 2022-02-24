using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    public class IsItAPalindrome
    {
        public static bool PalindromeTester(string wordToTest)
        {   
            var removePuncuationString = new String(wordToTest.Where(c => !char.IsPunctuation(c)).ToArray());
            removePuncuationString = removePuncuationString.ToLower();
            char[] charArray = removePuncuationString.ToLower().ToCharArray();

            var reveredString = new String(charArray);
            Console.WriteLine(removePuncuationString);
            Console.WriteLine(reveredString);
            Console.WriteLine(wordToTest);

            if (removePuncuationString == reveredString)
            {
                return true;
            }
            return false;
        }
    }
}
