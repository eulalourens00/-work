using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перегрузка
{
    internal class MultArray
    {
        private int[,] array;
        public int Row {  get; private set; }
        public int Column { get; private set; }
        public MultArray(int row, int column)
        {
            Row = row;
            Column = column;
            array = new int[row, column];
        }
        public int this[int r, int c]
        {
            get { return array[r, c]; }
            set { array[r, c] = value; }
        }
    }

}
