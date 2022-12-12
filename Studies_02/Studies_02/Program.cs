using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            double[] PC = new double[N];
            double[] PV = new double[N];



            for (int i = 0; i < N; i++)
            {
                String[] S = Console.ReadLine().Split(' ');
                PC[i] = double.Parse(S[1], CultureInfo.InvariantCulture);
                PV[i] = double.Parse(S[2], CultureInfo.InvariantCulture);
            }

            //lucro
            int contAbaixoDe10 = 0;
            int contEntre10E20 = 0;
            int contAcimaDe20 = 0;
            for (int i = 0; i < N; i++)
            {
                double lucro = PV[i] - PC[i];
                double por_lucro = lucro / PC[i] * 100.0;
                if (por_lucro < 10.0)
                {
                    contAbaixoDe10++;
                }
                else if (por_lucro <= 20.0)
                {
                    contEntre10E20++;
                }
                else
                {
                    contAcimaDe20++;
                }
            }

            Console.WriteLine("Lucro abaixo de 10%: " + contAbaixoDe10);
            Console.WriteLine("Lucro entre 10% e 20%: : " + contEntre10E20);
            Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);

            //valor total
            double soma = 0,
                   venda = 0;
            for (int i = 0; i < N; i++)
            {
                soma += PC[i];
                venda += PV[i];
            }

            Console.WriteLine("Valor total de compra: " + soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + venda.ToString("F2", CultureInfo.InvariantCulture));
            double lucro_total = venda - soma;
            Console.WriteLine("Lucro total: " + lucro_total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

