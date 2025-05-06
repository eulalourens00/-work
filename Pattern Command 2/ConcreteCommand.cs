using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Command_2
{
    public class ConcreteCommand: Command
    {
        protected Receiver _reciever;
        public ConcreteCommand(Receiver receiver)
        {  _reciever = receiver; }

        public override void Execute()
        {
            Console.WriteLine("ConcreteCommand: Execute(выполняем)");
            _reciever.Operation();
        }

        public override void Undo()
        { Console.WriteLine("ConcreteCommand: Undo(убегаем) bubububub"); }
    }
}
