using System;
using System.Collections.Generic;

namespace Arrays
{
    static class Program
    {
        static void Main()
        {
            string[] userInput = Console.ReadLine().Split();
            for (int i = 0; i < GetNewArray(userInput).Length; i++)
            {
                Console.Write(GetNewArray(userInput)[i]);
                Console.Write(" ");
            }
        }

        public static int GetFactorial(int number)
        {
            if (number == 0) return 1;

            return number * GetFactorial(number-1);
        }

        public static double RoundAndGetFractionalPart(double numberDouble)
        {
            return Math.Round((numberDouble - Math.Floor(numberDouble)), 2) * 100;
        }
        
        public static string[] GetNewArray(string[] userInput)
        {
            var list = new List<string>();
            for (int i = 0; i < userInput.Length; i++)
            {
                bool isInt = int.TryParse(userInput[i], out int numberInt);
                bool isDouble = double.TryParse(userInput[i], out double numberDouble);
                
                if (isInt)
                {
                    if (numberInt>0)
                    {
                        list.Add(GetFactorial(numberInt).ToString());
                    }
                    else
                    {
                        list.Add(numberInt.ToString());
                    }
                }

                else if (isDouble)
                {
                    if (numberDouble > 0)
                    {
                        list.Add(RoundAndGetFractionalPart(numberDouble).ToString());
                    }
                    else
                    {
                        list.Add((100 - RoundAndGetFractionalPart(numberDouble)).ToString());
                    }
                }

                else
                {
                    list.Add("NaN");
                }
            }

            string[] newArray = list.ToArray();
            return newArray;
        }
    }
}
