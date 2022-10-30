using System;

namespace Lab52
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите число: ");
            int sum = 0;
            string userInput = Console.ReadLine();
            if (IsInt(userInput))
            {
                foreach (char c in userInput)
                    sum += Convert.ToInt32(c.ToString());
                Console.WriteLine(sum);
            }
            else Console.WriteLine("Введенная строка не является числом");
        }

        public static bool IsInt(string userInput)
        {
            foreach (char c in userInput)
            {
                if ((c < '0') || (c > '9'))
                    return false;
            }

            return true;
        }
    }
}
