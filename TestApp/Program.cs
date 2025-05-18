using System;

namespace Test
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start");

            A a1 = new A() { ID = 2 };
            B b1 = new B(a1) { Number = 3 };
            Console.WriteLine(b1.ToString());

            Console.ReadLine();
        }
    }
}
