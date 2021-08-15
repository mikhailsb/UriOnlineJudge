using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFunc = int.Parse(Console.ReadLine());

            int horasTrab = int.Parse(Console.ReadLine());

            double valorHora = double.Parse(Console.ReadLine());

            double receber = horasTrab * valorHora;

            //Console.WriteLine("NUMERO = {0}\nSALARY = U$ {1}", numFunc, receber.ToString("0.00"));
            Console.WriteLine("NUMBER = {0}", numFunc);
            Console.WriteLine("SALARY = U$ {0}", receber.ToString("0.00"));

            Console.ReadLine();
        }
    }
}
