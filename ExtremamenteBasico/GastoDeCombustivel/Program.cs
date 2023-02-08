using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastoDeCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());
            decimal consumoGasolina = 12;

            int totalKm = velocidade * tempo;

            decimal totalGasolina = totalKm /consumoGasolina;

            Console.WriteLine(totalGasolina.ToString("0.000"));

            Console.ReadLine();

        }
    }
}
