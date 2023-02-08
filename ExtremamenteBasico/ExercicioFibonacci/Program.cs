using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número: ");
            int entrada = Convert.ToInt32(Console.ReadLine());

            int num1 = 0, num2 = 1, aux;
            List<int> listaFibo = new List<int>();
            listaFibo.Add(0);
            listaFibo.Add(1);
            for (int i = 0; num2 < entrada​​​; i++)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;
                listaFibo.Add(num2);
            }

            if (listaFibo.Contains(entrada))
                Console.WriteLine("O número faz parte da sequência de Fibonacci.");
            else
                Console.WriteLine("O número não faz parte da sequência de Fibonacci.");


            Console.ReadLine();

        }
    }
}
