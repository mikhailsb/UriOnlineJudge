using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string Dados = Console.ReadLine();

            string []valor = Dados.Split();

            double pi = 3.14159;

            double triangulo = double.Parse(valor[0]) * double.Parse(valor[2]) / 2;
            double circulo = pi * Math.Pow(double.Parse(valor[2]), 2);
            double trapezio = ((double.Parse(valor[0]) + double.Parse(valor[1])) * double.Parse(valor[2])) / 2;
            double quadrado = double.Parse(valor[1]) * double.Parse(valor[1]);
            double retangulo = (double.Parse(valor[0]) * double.Parse(valor[1]));

            Console.WriteLine("TRIANGULO: {0}", triangulo.ToString("0.000"));
            Console.WriteLine("CIRCULO: {0}", circulo.ToString("0.000"));
            Console.WriteLine("TRAPEZIO: {0}", trapezio.ToString("0.000"));
            Console.WriteLine("QUADRADO: {0}", quadrado.ToString("0.000"));
            Console.WriteLine("RETANGULO: {0}", retangulo.ToString("0.000"));

        }
    }
}
