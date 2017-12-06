using System;

namespace theadd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Result :");
            Method m = new Method();
            int a = m.Add(8, 12);
            Console.WriteLine(a);
            Console.Read();
        }
    }
    class Method
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}