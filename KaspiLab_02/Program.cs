using System;

namespace KaspiLab_02
{
    class Program
    {

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        static void Main(string[] args)
        {
            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            for (int j = 0; j < num.Length; j++)
            {
                if (!IsOdd(num[j]))
                {
                    Console.WriteLine(num[j] + " chetnoe");
                }
                if (IsPrime(num[j]))
                {
                    Console.WriteLine(num[j] + " prostoe");
                }
                sum += num[j];
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
