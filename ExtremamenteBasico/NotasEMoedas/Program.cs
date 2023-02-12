using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasEMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal entrada = Convert.ToDecimal(Console.ReadLine().ToString().Replace('.',','));

            Console.WriteLine(entrada);

            int nota100 = (int) entrada / 100;
            decimal resto = entrada % 100;
            int nota50 = (int)resto / 50;
            resto = resto % 50;
            int nota20 = (int)resto / 20;
            resto = resto % 20;
            int nota10 = (int)resto / 10;
            resto = resto % 10;
            int nota5 = (int)resto / 5;
            resto = resto % 5;
            int nota2 = (int)resto / 2;
            resto = resto % 2;
            int moeda1 = Convert.ToInt32(Math.Floor(resto / 1.0m));
            resto = resto % 1.0m;
            int moeda50 = Convert.ToInt32(Math.Floor(resto / 0.50m));
            resto = resto % 0.50m;
            int moeda25 = Convert.ToInt32(Math.Floor(resto / 0.25m));
            resto = resto % 0.25m;
            int moeda10 = Convert.ToInt32(Math.Floor(resto / 0.10m));
            resto = resto % 0.10m;
            int moeda05 = Convert.ToInt32(Math.Floor(resto / 0.05m));
            resto = resto % 0.05m;
            int moeda01 = Convert.ToInt32(Math.Floor(resto / 0.01m));

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
            Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
            Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
            Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
            Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
            Console.WriteLine($"{nota2} nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{moeda1} nota(s) de R$ 1.00");
            Console.WriteLine($"{moeda50} nota(s) de R$ 0.50");
            Console.WriteLine($"{moeda25} nota(s) de R$ 0.25");
            Console.WriteLine($"{moeda10} nota(s) de R$ 0.10");
            Console.WriteLine($"{moeda05} nota(s) de R$ 0.05");
            Console.WriteLine($"{moeda01} nota(s) de R$ 0.01");

            Console.ReadLine();
        }
    }
}
