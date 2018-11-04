using System;

namespace Day_5_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int sum = n * i;
                Console.WriteLine($"{n} * {i} = {sum}" );
            }
        }
    }
}
