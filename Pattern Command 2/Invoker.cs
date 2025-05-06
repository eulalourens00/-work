using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Command_2
{
    public class Invoker
    {
        protected Command _command;

        public void SetCommand(Command command)
        { _command = command;}

        public void Run()
        {
            Console.WriteLine("Invoker: Run(прибегаем)");
            _command?.Execute();
        }

        public void Cancel()
        {
            Console.WriteLine("Invoker: Cancel(убегаем) gogogog");
            _command?.Undo();
        }
    }
}
