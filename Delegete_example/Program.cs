using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegete_example
{
    class Program
    {
        public delegate void Print(int value);            
        static void Main(string[] args)
        {
            PrintHelper(PrintNumber, 10000);
            PrintHelper(PrintMoney, 20000);
            Console.ReadLine();
        }
        public static void PrintHelper(Print delegateFunc,int printNumber)
        {
            delegateFunc(printNumber);
        }
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number:{0}", num);
        }
        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money:{0}", money);
        }
    }
}
