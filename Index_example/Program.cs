using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_example
{
    public class Student
    {
        private int[] _marks = new int[] { 40, 60, 70 };
        public int this[int i]
        {
            get
            {
                return _marks[i];

            }
            set
            {
                _marks[i] = value;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            
            Console.WriteLine(s[0] = 30);
            Console.ReadLine();
        }
    }
}
