using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_example
{
    class Program
    {
        public int m1(int a, int b)
        {
            return a + b;
        }
        public string m1(string x, string y)
        {
            int res = Convert.ToInt32(x) - Convert.ToInt32(y);
            string res1 = Convert.ToString(res);
            return res1;
        }
        static void Main(string[] args)
        {
            Program Overloadingsa = new Program();
            Console.WriteLine(Overloadingsa.m1(10, 5));
            Console.ReadLine();
        }
    }
}
