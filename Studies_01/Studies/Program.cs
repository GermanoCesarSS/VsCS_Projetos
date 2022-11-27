using System;
using System.Globalization;

namespace Studies
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("20. Terreno");

            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * comprimento;
            double preco = area * precoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PREcO = " + preco.ToString("F2", CultureInfo.InvariantCulture));
            


            /*
            Console.WriteLine("19. Funções: \n Sqrt - raiz quadrada \n Pow - potencia \n Abs - valor absoluto");

            Console.WriteLine("Baskara");

            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double delta = Math.Pow(b, 2.0) - 4 * a * c;
            Console.WriteLine(delta.ToString("F2", CultureInfo.InvariantCulture));
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(x1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(x2.ToString("F2", CultureInfo.InvariantCulture));
            */
           
            /*
             Console.WriteLine("18. Chekilst");

            Console.WriteLine("Nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto você recebe?");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Escrevendo String e separando elas com o SPLIT
            Console.WriteLine("Escreva seu ultimo nome, idade e altura (na mesma linha");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //Saída
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));

            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
             int n1 = int.Parse(Console.ReadLine());
             char ch = char.Parse(Console.ReadLine());
             double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


             Console.WriteLine("Numero: " + n1);
             Console.WriteLine("Caracter: " + ch);
             Console.WriteLine("Numero com virgula: " + n2.ToString("F2", CultureInfo.InvariantCulture));


             string[] vet = Console.ReadLine().Split(' ');
             string nome = vet[0];
             char sexo = char.Parse(vet[1]);
             int idade = int.Parse(vet[2]);
             double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

             Console.WriteLine(nome + " " + sexo + " " + idade + " " + altura.ToString("F2", CultureInfo.InvariantCulture));
             */

            /*
             * Console.WriteLine("17. Split");

            //string frase = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("Parte 1: " + p1 + " Parte 2: " + p2 + " Parte 3: " + p3);
            */

        }
    }
}