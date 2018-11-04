using System;

namespace Day_7_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //the size of the array
            string[] temp = Console.ReadLine().Split(" ");  //n space-separated ints

            int[] array = Array.ConvertAll(temp, Int32.Parse); //store the temp size into a new array

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
