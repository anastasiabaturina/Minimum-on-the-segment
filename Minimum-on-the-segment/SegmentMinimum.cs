using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Minimum_on_the_segment
{
    public class SegmentMinimum
    {
        public static void FindMinimumOnRange(int n, int k, int[] array)
        {
            List<int[]> subarrays = new List<int[]>();

            for (int i = 0; i < array.Length - k + 1; i++)
            {
                int[] subarray = new int[k];
                Array.Copy(array, i, subarray, 0, k);
                subarrays.Add(subarray);
            }

            foreach (int[] num in subarrays)
            {
                Console.WriteLine(num.Min());
            }
        }
    }
}
