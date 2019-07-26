using System;

namespace Delegates
{
    delegate int Del();

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Del del = new Del(Fun1);
            del += Fun2;
            del += Fun3;

            Console.WriteLine(del());

        }

        public static int Fun1()
        {
            return 1;
        }
        public static int Fun2()
        {
            return 2;
        }
        public static int Fun3()
        {
            return 3;
        }

    }
}
