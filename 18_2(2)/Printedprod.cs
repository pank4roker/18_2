using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_2_2_
{
    abstract class Printedprod
    {
        string name;
        public string Name { get => name; set => name = value; }
        public abstract void Info();
        public abstract double Cost();

    }
}
