using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        public static List<int> numsToPermute = new List<int>() { 1, 1, 3, 1, 1 };
        public static List<int> usedIndexes = new List<int>();
        public static void Permutate(int index)
        {
            if(index >= numsToPermute.Count)
            {
                Console.WriteLine(string.Join(" ", numsToPermute));
                return;
            }
            Permutate(index + 1);
            for (int i = index+1; i < numsToPermute.Count; i++)
            {
                Swap(index, i);
                Permutate(index + 1);
                Swap(index, i);
            }
        }

        public static void Swap(int first, int second)
        {
            var temp = numsToPermute[first];
            numsToPermute[first] = numsToPermute[second];
            numsToPermute[second] = temp;
        }


        static void Main()
        {
            Permutate(0);
        }

    }
}
