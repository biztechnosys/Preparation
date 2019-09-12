using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonly_example
{
    public class Readonlyexample
    {
        readonly int x;
        readonly string name = "Ajaz";
        public Readonlyexample(string Name)
        {
            x = 20;
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Readonlyexample e = new Readonlyexample("ABC");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
