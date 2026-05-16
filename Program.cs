using System;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool estado = true;
            char genero = 'f';
            char genero2 = '\u0046';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 21474836488;
            float n5 = 1.1f;
            double n6 = 1.1;
            string n7 = "caua";
            object n8 = "caua objeto";
            int n9 = int.MinValue;
            int n10 = int.MaxValue;
            decimal n11 = decimal.MaxValue;

            Console.WriteLine(estado);
            Console.WriteLine(genero);
            Console.WriteLine(genero2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4); 
            Console.WriteLine(n5); 
            Console.WriteLine(n6); 
            Console.WriteLine(n7); 
            Console.WriteLine(n8); 
            Console.WriteLine(n9); 
            Console.WriteLine(n10); 
            Console.WriteLine(n11); 

        }
    }
}