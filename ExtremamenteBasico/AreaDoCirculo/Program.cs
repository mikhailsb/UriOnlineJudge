using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaDoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;

            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("A={0}", Math.Pow(raio, 2));

            double area =  n * Math.Pow(raio, 2);

            //Console.WriteLine("A={0:N4}", area);

            Console.WriteLine("A={0}", area.ToString("0.0000"));

            Console.ReadLine();
        }
    }
}
