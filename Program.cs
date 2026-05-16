using System;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracoes de variaveis
            bool estado = true;
            char genero = 'f';
            char genero2 = '\u0046';
            byte n1 = 23;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 21474836488;
            float n5 = 1.1f;
            double n6 = 44.1352132;
            string n7 = "caua";
            object n8 = "objeto caua";
            int n9 = int.MinValue;
            int n10 = int.MaxValue;
            decimal n11 = decimal.MaxValue;

            Console.WriteLine(n7 + " tem " + n1 + " anos e pesa " + n6.ToString("F2") + " kilos"); 
        }
    }
}