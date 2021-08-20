using System;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            double y = double.Parse(Console.ReadLine());

            double saida = x / y;

            Console.WriteLine("{0} km/l", saida.ToString("0.000"));
        }
    }
}
