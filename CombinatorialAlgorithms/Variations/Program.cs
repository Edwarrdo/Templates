using System;
using System.Collections.Generic;

namespace Variations
{
    class Program
    {
        public static List<int> nums = new List<int>();
        public static List<int> numsToVariate = new List<int>() { 1, 2, 3, 4 };
        public static List<int> usedIndexes = new List<int>();
        public static int k = 2;
        public static void Gen(int index)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(" ", nums));
                return;
            }
            for (int i = 0; i < numsToVariate.Count; i++)
            {
                if(usedIndexes.Contains(i))
                {
                    continue;
                }
                //usedIndexes.Add(i);
                nums.Add(numsToVariate[i]);
                Gen(index + 1);
                //usedIndexes.Remove(i);
                nums.RemoveAt(nums.Count - 1);
            }
        }

        public static void Swap(int first, int second)
        {
            var temp = numsToVariate[first];
            numsToVariate[first] = numsToVariate[second];
            numsToVariate[second] = temp;
        }
        static void Main(string[] args)
        {
            Gen(0);
        }
    }
}
