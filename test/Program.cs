using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        //static void Main(string[] args)
        //{

            static void Main(string[] args)
            {
                int[] Numbers = { 1, 3, 4, 6, 8, 10, 20 };
                List<int> oddNumbers = new List<int> { };
                foreach (int number in Numbers)
                {
                    if (number % 2 == 1)
                    {
                        oddNumbers.Add(number);
                    }
                }
                int countOdd = oddNumbers.Count();
                int sumOdd = oddNumbers.Sum();
                int averageOdd = (sumOdd / countOdd);
                Console.WriteLine("The average of the odd numbers in the array: " + averageOdd);
            }



            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Welcome to vowel count.");
            //    List<int> vowelA = new List<int> { };
            //    List<int> vowelE = new List<int> { };
            //    List<int> vowelI = new List<int> { };
            //    List<int> vowelO = new List<int> { };
            //    List<int> vowelU = new List<int> { };
            //    char[] letterCheck;
            //    int i = 1;
            //    int countA = 0;
            //    int countE = 0;
            //    int countI = 0;
            //    int countO = 0;
            //    int countU = 0;
            //    Console.WriteLine("Please enter a word or sentence: ");
            //    string Input = Console.ReadLine().ToLower();
            //    letterCheck = Input.ToArray();
            //    foreach (char letter in letterCheck)
            //    {
            //        if (letter == 'a')
            //        {
            //            vowelA.Add(i);
            //        }
            //        else if (letter == 'e')
            //        {
            //            vowelE.Add(i);
            //        }
            //        else if (letter == 'i')
            //        {
            //            vowelI.Add(i);
            //        }
            //        else if (letter == 'o')
            //        {
            //            vowelO.Add(i);
            //        }
            //        else if (letter == 'u')
            //        {
            //            vowelI.Add(i);
            //        }

            //    }
            //    countA = vowelA.Count();
            //    countE = vowelE.Count();
            //    countI = vowelI.Count();
            //    countO = vowelO.Count();
            //    countU = vowelU.Count();
            //    Console.WriteLine("The total of each vowerl is a:" + countA + ", e:" + countE + ", i:" + countI + ", o:" + countO + ", u:" + countU);
            //}
        //}
    }
}
