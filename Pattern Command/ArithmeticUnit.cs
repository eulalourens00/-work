using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Command
{
    class ArithmeticUnit
    {
        public int Register { get; set; }

        public void Run(char operationCode, int operand)
        {
            switch (operationCode)
            {
                case '+':
                    {
                        Register += operand;
                        break;
                    }
                case '-':
                    {
                        Register -= operand;
                        break;
                    }
                case '*':
                    {
                        Register *= operand;
                        break;
                    }
                case '/':
                    {
                        if (operand == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        Register /= operand;
                        break;
                    }
            }
        }
    }
}
