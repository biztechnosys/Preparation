using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_example
{
    public abstract class Vehicle
    {
        public abstract void display();
    }
    public class Car:Vehicle
    {
        public override void display()
        {
            Console.WriteLine("Car");
        }   
    }
    public class Motorcycle:Vehicle
    {
        public override void display()
        {
            Console.WriteLine("MotorCycle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v;
            v = new Car();
            v.display();
            v = new Motorcycle();
            v.display();
            Console.ReadLine();
        }
    }
}
