using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26Pract_29._03._2025
{
    //1.
    internal class IntervalSet
    {
        private int[][] _intervals;

        public IntervalSet(int[][] intervals)
        { _intervals = intervals; }

        public int MinSetSize()
        {
            Array.Sort(_intervals, (a, b) => a[0].CompareTo(b[0]));

            int count = 0;
            int lastEnd = -1;

            foreach (var interval in _intervals)
            {
                int start = interval[0];
                int end = interval[1];

                if (start > lastEnd)
                {
                    count += 2;
                    lastEnd = end;
                }
                else
                {
                    if (lastEnd < end)
                    {
                        count += 1;
                        lastEnd = end;
                    }
                }
            }
            return count;
        }
    }

    //2.
    internal class MinimalDiap
    {
        private int[][] _intervals;

        public MinimalDiap(int[][] intervals)
        { _intervals = intervals; }

        public void MinimalMaxValue()
        {
            Array.Sort(_intervals, (a, b) => a[0].CompareTo(b[0]));

            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (var interval in _intervals)
            {
                if (interval[0] < min) { min = interval[0]; }
                if (interval[1] > max) { max = interval[1]; }
            }

            Console.WriteLine($"Max of this - {max} \nMin of this - {min}");
        }
    }
}
