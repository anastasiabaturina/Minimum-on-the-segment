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
            for (var i = 0; i < n - k + 1; i++)
            {
                var subarray = new int[k];
                Array.Copy(array, i, subarray, 0, k);
                Console.WriteLine(subarray.Min());
            }
        }
    }
}
