using System.Globalization;

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
            double n6 = 57.1352132;
            string n7 = "Maria";
            object n8 = "objeto caua";
            int n9 = int.MinValue;
            int n10 = int.MaxValue;
            decimal n11 = decimal.MaxValue;

            //concatenacao
            Console.WriteLine(n7 + " tem " + n1 + " anos e pesa " + n6.ToString("F2") + " kilos");
            //placeholder
            Console.WriteLine("{0} tem {1} anos e pesa {2:F2} kilos",n7,n1,n6);
            //Interpolacao
            Console.WriteLine($"{n7} tem {n1} anos e pesa {n6:F2} kilos");

            //Exercicio Aula 19
            string produto1 = "computador" , produto2 = "Mesa de escritorio";
            byte idade = 30;
            int codigo = 5290;
            char gen = 'M';
            double preco1 = 2100.0, preco2 = 650.60, medida = 53.234567;
            Console.WriteLine($"\n\nProdutos : \n{produto1},cujo preço é {preco1}\n{produto2},cujo preço é{preco2}");
            Console.WriteLine($"\nRegistro: {idade} anos de idade, código: {codigo}, e gênero: {gen}");
            Console.WriteLine($"Medida com oito casas decimais{medida}\nArredondado(três casas decimais) : {medida:F3}");
            Console.WriteLine($"Separaor decimal invariante culture: {medida.ToString("F3",CultureInfo.InvariantCulture)}");

            //Operadores de atribuição
            int a = 2;
            Console.WriteLine(a);
            a += 2; // a = a + 2
            Console.WriteLine(a);
            a -= 2; // a = a - 2
            Console.WriteLine(a);
            a *= 2; // a = a * 2
            Console.WriteLine(a);
            a /= 2; // a = a / 2
            Console.WriteLine(a);
            a %= 2; // a = a % 2
            Console.WriteLine(a);

            int b = 5;
            int bb = 10;
            bb = ++b ; // Pré-Incremento b+1 vai para bb
            Console.WriteLine(b);
            bb = --b; // Pré-Incremento b-1 vai para bb
            Console.WriteLine(b);
            bb = b++; // Pós-Incremento bb recebe b depois b recebe b+1
            Console.WriteLine(bb);
            bb = b--; // Pós-Incremento bb recebe b depois b recebe b-1
            Console.WriteLine(bb);

            //Concatenação cumulativa de string
            string c = "ABC";
            Console.WriteLine(c);
            c += "DEF";
            Console.WriteLine(c);
        }
    }
}