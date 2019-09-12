using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_example
{
    public class Patient
    {
        private string _name;
        private int _age;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();          
            Console.WriteLine(p.Name = "Ajaz");
            Console.WriteLine(p.Age = 50);
            Console.ReadLine();
        }
    }
}
