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
            List<int[]> numbers = new List<int[]>();

            for (int i = 0; i < array.Length - k + 1; i++)
            {
                int[] number = new int[k];
                Array.Copy(array, i, number, 0, k);
                numbers.Add(number);
            }

            foreach (int[] num in numbers)
            {
                Console.WriteLine(num.Min());
            }
        }
    }
}
