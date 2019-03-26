using System;
using System.Collections.Generic;

namespace Combinations
{
    class Program
    {
        public static int k = 3;
        public static int n = 5;
        public static int[] arr = new int[k];

        public static void Gen(int index, int start)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }
            for (int i = start; i < n; i++)
            {
                arr[index] = i;
                Gen(index + 1, i + 1);
            }
        }
        
        static void Main(string[] args)
        {
            Gen(0, 0);
        }
    }
}
