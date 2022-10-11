using System;

namespace Lab51
{
    class Program
    {
        static public void Main()
        {
            double LastNum = 0;
            while (true)
            {
                string str = Console.ReadLine();

                bool IsInt = int.TryParse(str, out int currentNumInt);
                bool IsDouble = double.TryParse(str, out double currentNumDouble);

                if (IsInt)
                {
                    Console.WriteLine(currentNumInt);
                    LastNum = currentNumInt;
                }
                else if (IsDouble)
                {
                    if (currentNumDouble == LastNum)
                        break;
                    else
                    {
                        LastNum = currentNumDouble;
                        continue;
                    }
                }
                else if (str == "q")
                    break;
                else
                    continue;
            }
        }
    }
}
