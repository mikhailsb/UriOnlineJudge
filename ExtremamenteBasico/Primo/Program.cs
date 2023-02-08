using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primo
{
    class Program
    {
        static void Main(string[] args)
        {
            verificaNumeroPrimo(9);
        }

        private static void verificaNumeroPrimo(int numero)
        {
            for (int i = 2; i <= numero; i++)
            { 
                if (numero == 2){
                    Console.Write("O numero " + numero + " é primo");
                } else if (numero % 2 == 0){
                    Console.Write("O numero " + numero + " não é primo pois foi divisível por 2");
                }
                else if (numero % i == 0){
                    Console.Write("O numero " + numero + " não é primo pois é divisível por " + i);
                }
                else if (numero / i == 0){
                    Console.Write("O numero " + numero + " é primo");
                } 
            }
            Console.ReadLine();
        }
    }
}
