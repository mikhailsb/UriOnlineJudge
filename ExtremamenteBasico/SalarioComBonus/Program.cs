using System;

namespace SalarioComBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();

            double salario = double.Parse(Console.ReadLine());

            double totalVendas = double.Parse(Console.ReadLine());

            double total = salario + ((totalVendas / 100) * 15);

            Console.WriteLine("TOTAL = R$ {0}", total.ToString("0.00"));

            Console.ReadLine();
        }
    }
}
