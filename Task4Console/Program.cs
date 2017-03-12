using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task4Logic;

namespace Task4Console
{
    class Program
    {
        static void TestPairOfString(string firstString, string secondString)
        {
            Console.WriteLine("The first string: ");
            Console.WriteLine(firstString);
            Console.WriteLine("The second string: ");
            Console.WriteLine(secondString);
            Console.WriteLine("Result: " + StringAlphabetizer.ConcatAndAlphabetize(firstString, secondString));
            Console.WriteLine("---");
        }

        static void Main(string[] args)
        {
            string[] stringArray = { "aaa", "bcv", "yhdgdfdffd", "nneeryyy", null, string.Empty, "a1", "NN" };
            for (int i = 0; i < stringArray.Length - 1; i += 2)
            {
                try
                {
                    TestPairOfString(stringArray[i], stringArray[i + 1]);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception " + e.Message);
                }
            }
        }
    }
}
