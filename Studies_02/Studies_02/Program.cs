using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int dias, horas, min, seg,
                dias2, horas2, min2, seg2,
                w, x, y, z, resto;

            string[] vet = Console.ReadLine().Split(' ');
            dias = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            horas = int.Parse(vet[0]);
            min = int.Parse(vet[2]);
            seg = int.Parse(vet[4]);

            vet = Console.ReadLine().Split(' ');
            dias2 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            horas2 = int.Parse(vet[0]);
            min2 = int.Parse(vet[2]);
            seg2 = int.Parse(vet[4]);

            int inicio = (dias - 1) * 24 * 60 * 60 + horas * 60 * 60 + min * 60 + seg;
            int fim = (dias2 - 1) * 24 * 60 * 60 + horas2 * 60 * 60 + min2 * 60 + seg2;

            int duracao = fim - inicio;

            w = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            x = resto / (60 * 60);
            resto = resto % (60 * 60);
            y = resto / 60;
            z = resto % 60;

            Console.WriteLine(w + " dia(s)");
            Console.WriteLine(x + " hora(s)");
            Console.WriteLine(y + " minuto(s)");
            Console.WriteLine(z + " segundo(s)");

        }
    }
}

