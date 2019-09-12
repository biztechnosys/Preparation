using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingMethod_example
{
    public class A
    {
        public void Show()
        {
            Console.WriteLine("This is base class method");
        }
    }
    public class B:A
    {
        public new void Show()
        {
            Console.WriteLine("This is deriven class method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Show();
            Console.ReadLine();
        }
    }
}
