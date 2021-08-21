using System;

namespace DistanciaEntreDoisPontos
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();

            string []strX = x.Split();
            string []strY = y.Split();

            double []p1 = { double.Parse(strX[0]), double.Parse(strX[1]) };
            double []p2 = { double.Parse(strY[0]), double.Parse(strY[1]) };

            double distancia = Math.Sqrt(Math.Pow((p2[0] - p1[0]), 2) + Math.Pow((p2[1] - p1[1]), 2));

            Console.WriteLine(distancia.ToString("0.0000"));
        }
    }
}
