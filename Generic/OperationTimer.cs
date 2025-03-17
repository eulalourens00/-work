using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal sealed class OperationTimer: IDisposable
    {
        long _startTime;
        string _text;
        int _collectionCount;

        public OperationTimer(string text)
        {
            PrepareForOperation();
            _text = text;
            _collectionCount = GC.CollectionCount(0);

            _startTime = Stopwatch.GetTimestamp();

        }
        public void Dispose() {
            Console.WriteLine($"{_text}\t{(Stopwatch.GetTimestamp() - _startTime) / (double)Stopwatch.Frequency:0.00} seconds (trash)" +
                $"{GC.CollectionCount(0) - _collectionCount}");
        }
        public void PrepareForOperation()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
