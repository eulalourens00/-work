using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28Pract_Classes_Interfaces
{
    public interface IRateAndCopy
    {
        double Rating {  get; }
        object DeepCopy();
    }
}
