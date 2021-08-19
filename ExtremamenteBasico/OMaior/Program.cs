using System;

namespace OMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();

            string[] valor = entrada.Split();

            int maior = 0;

            if (int.Parse(valor[0]) >= int.Parse(valor[1]))
            {
                if (int.Parse(valor[0]) >= int.Parse(valor[2]))
                {
                    maior = int.Parse(valor[0]);
                } else
                {
                    maior = int.Parse(valor[2]);
                }
            }
            else if (int.Parse(valor[1]) >= int.Parse(valor[2]))
            {
                maior = int.Parse(valor[1]);
            }
            else
            {
                maior = int.Parse(valor[2]);
            }

            Console.WriteLine("{0} eh o maior", maior);

        }
    }
}
