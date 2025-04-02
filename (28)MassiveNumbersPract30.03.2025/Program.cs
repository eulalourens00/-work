using System.Collections.Generic;
namespace _28_MassiveNumbersPract30._03._2025
{
    internal class Program
    {
        //1.
        static IList<int[]> MergeIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            var merged = new List<int[]>();
            var currentInterval = intervals[0];

            foreach (var interval in intervals)
            {
                if (interval[0] <= currentInterval[1])
                {
                    currentInterval[1] = Math.Max(currentInterval[1], interval[1]);
                }
                else
                {
                    merged.Add(currentInterval);
                    currentInterval = interval;
                }
            }
            merged.Add(currentInterval);
            return merged;
        }
        //2.
        static IList<IList<int>> Target(int[] Candidates, int target)
        {
            var result = new List<IList<int>>();
            Array.Sort(Candidates);
            Backtrack(result, new List<int>(), Candidates, target, 0);
            return result;
        }
        static void Backtrack(IList<IList<int>> result, IList<int> tempList, int[] candidates, int remain, int start)
        {
            if (remain == 0) 
            {
                result.Add(new List<int>(tempList));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1]) continue;

                tempList.Add(candidates[i]);
                Backtrack(result, tempList, candidates, remain - candidates[i], i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }

        //3.
        static bool FourStepen()
        {
            Console.Write("Enter a number: ");
            Int32.TryParse(Console.ReadLine(), out int value);
            int four = 1;
            while (true)
            {
                if(four == value) { Console.WriteLine("Great!"); return true; }
                else if(four > value) { Console.WriteLine("Unluck..."); return false; }
                four *= 4;
            }
        }

        //4.
        static void TimesheetD()
        {
            Console.Write("Days: ");
            Int32.TryParse(Console.ReadLine(), out int d);
            List<int> jobDifficulty = new List<int> { 1, 2, 3, 4, 5 };
            int n = jobDifficulty.Count;

            if (n < d)
            { Console.WriteLine(-1); return; }

            int[,] dp = new int[n + 1, d + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= d; j++)
                { dp[i, j] = int.MaxValue;}
            }

            dp[0, 0] = 0;

            for (int j = 1; j <= d; j++)
            {
                for (int i = j; i <= n; i++)
                {
                    int maxDifficulty = 0;
                    for (int k = i; k >= j; k--)
                    {
                        maxDifficulty = Math.Max(maxDifficulty, jobDifficulty[k - 1]);
                        dp[i, j] = Math.Min(dp[i, j], dp[k - 1, j - 1] + maxDifficulty);
                    }
                }
            }
            int result = dp[n, d];
            Console.WriteLine(result == int.MaxValue ? - 1 : result);
        }

        static void Main(string[] args)
        {
            //1.
            int[][] intervals = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 2, 6 },
                new int[] { 8, 10 },
                new int[] { 15, 18 }
            };
            var mergedIntervals = MergeIntervals(intervals);

            foreach (var interval in mergedIntervals)
            {  Console.WriteLine($"[{interval[0]}, {interval[1]}]"); }
            //2.
            int[] Candidates = new int[] { 10, 1, 2, 7, 6, 1, 5 };
            int target = 8;
            var targetCandidates = Target(Candidates, target);
            foreach (var candidate in targetCandidates) {
                Console.WriteLine($"[{string.Join(", ", candidate)}]");
            }
            //3.
            FourStepen();
            //4.
            TimesheetD();
        }
    }
}
