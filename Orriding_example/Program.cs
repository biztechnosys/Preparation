using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orriding_example
{
    public class A
    {
        public virtual int m1(int a,int b)
        {
            return a + b;
        }
    }
    public class B:A
    {
        public override int m1(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            Console.WriteLine(b.m1(10, 5));
            A a = b;
            Console.WriteLine(b.m1(10, 5));
            Console.ReadLine();

        }
    }
}
