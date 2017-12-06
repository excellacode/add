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
        //Added another method 12-6-17 (at 13:00)
        public float Multi(float m1, float m2)
        {
            return m1 * m2;
        }
    }
}