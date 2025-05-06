using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Command_2
{
    abstract public class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}
