using System;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());

            double pi = 3.14159;

            double VOLUME = (4 / 3.0) * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = {0}", VOLUME.ToString("0.000"));

        }
    }
}
