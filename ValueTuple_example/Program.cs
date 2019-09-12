using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTuple_example
{
    class Program
    {

        static void Main(string[] args)
        {
            DisplayTuple(1, "Bill", "Gates");
            Console.ReadLine();
        }

        private static void DisplayTuple(int v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        static void DisplayTuple(int v, string v1, (int, string, string) person)
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");
        }
    }
}
