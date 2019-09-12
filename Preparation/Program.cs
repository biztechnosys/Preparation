using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation
{
    public class A
    {
        public int x = 10;
    }
    public class B:A
    {
        public int y = 20;
    }
    class Program
    {    
        static void Main(string[] args)
        {
            A a = new B();
           
            Console.WriteLine(a.x);
            B b = (B)a;
            Console.WriteLine(b.x);
            Console.ReadLine();

        }
    }
}
