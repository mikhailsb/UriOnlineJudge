using System;

namespace ProdutoSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = int.Parse(Console.ReadLine());

            int B = int.Parse(Console.ReadLine());

            int PROD = A * B;

            Console.WriteLine("PROD = {0}", PROD);
            Console.ReadLine();

        }
    }
}
