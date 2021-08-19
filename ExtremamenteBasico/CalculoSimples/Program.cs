using System;

namespace CalculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada1 = Console.ReadLine();

            string entrada2 = Console.ReadLine();

            string[] valores1 = entrada1.Split(" ");

            string[] valores2 = entrada2.Split(" ");

            double calculo = (double.Parse(valores1[1]) * double.Parse(valores1[2])) + (double.Parse(valores2[1]) * double.Parse(valores2[2]));

            Console.WriteLine("VALOR A PAGAR: R$ {0}", calculo.ToString("0.00"));
        }
    }
}
