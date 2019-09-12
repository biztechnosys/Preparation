using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceType_example
{
    public class A
    {
        public int x = 10;
        public string y = "Palle";
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.x);
            Console.WriteLine(a.y);
            Console.ReadLine();
        }
    }
}
