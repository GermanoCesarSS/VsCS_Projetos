using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet[0]);
            int uni1 = int.Parse(vet[1]);
            double preco = double.Parse(vet[2], CultureInfo.InvariantCulture);


            string[] vet2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet2[0]);
            int uni2 = int.Parse(vet2[1]);
            double preco2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double total = uni1 * preco + uni2 * preco2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString(("F2"), CultureInfo.InvariantCulture));

        }
    }
}

