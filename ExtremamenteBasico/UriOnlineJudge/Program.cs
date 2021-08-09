using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UriOnlineJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, X;

            Console.WriteLine("Digite um número: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            B = int.Parse(Console.ReadLine());

            X = A + B;
            Console.WriteLine("X = " + X);
            Console.ReadLine();
        }
    }
}
