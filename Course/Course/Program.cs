using System;

namespace Course
{
    internal class Program {
        static void Main(string[] args) {

            bool completo = false;
            char genero = 'M';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483647L;
            float n5 = 7.0f;
            double n6 = 8.0;
            string name = ("Bruno Santos");
            object obj1 = 4.5f;
            object obj2 = 5.6;
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            decimal n10 = decimal.MinValue;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(name);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
        }
    }
}