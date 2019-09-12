using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopCreateClass_object_example
{
    public class A
    {
        public int x;
        public int y;
        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class program
    {      
        static void Main(string[] args)
        {
            A a = new A(20,10);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
