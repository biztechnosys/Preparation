using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_example
{
    public class A
    {
        public virtual int m1(int x,int y)
        {
            return x + y;
        }
    }
    public class B:A
    {
        public override int m1(int x, int y)
        {
            return x - y;
        }
    }
    public class C:B
    {
        public sealed int m1(int x,int y)
        {
            return x * y;
        }
    }
    public class D: C
    {
        public override int m1(int x, int y)
        {
            return x * y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
