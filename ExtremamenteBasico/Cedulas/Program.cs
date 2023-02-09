using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            int cedula100;
            int cedula50;
            int cedula20;
            int cedula10;
            int cedula5;
            int cedula2;
            int cedula1;
            int resto;

            cedula100 = valor / 100;
            resto = valor % 100;
            cedula50 = resto / 50;
            resto = resto % 50;
            cedula20 = resto / 20;
            resto = resto % 20;
            cedula10 = resto / 10;
            resto = resto % 10;
            cedula5 = resto / 5;
            resto = resto % 5;
            cedula2 = resto / 2;
            resto = resto % 2;
            cedula1 = resto / 1;
            resto = resto % 1;

            Console.WriteLine(valor);
            Console.WriteLine($"{cedula100} nota(s) de R$ 100,00");
            Console.WriteLine($"{cedula50} nota(s) de R$ 50,00");
            Console.WriteLine($"{cedula20} nota(s) de R$ 20,00");
            Console.WriteLine($"{cedula10} nota(s) de R$ 10,00");
            Console.WriteLine($"{cedula5} nota(s) de R$ 5,00");
            Console.WriteLine($"{cedula2} nota(s) de R$ 2,00");
            Console.WriteLine($"{cedula1} nota(s) de R$ 1,00");

            Console.ReadLine();

        }
    }
}
