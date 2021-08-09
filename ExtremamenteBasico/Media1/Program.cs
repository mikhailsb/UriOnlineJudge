using System;

namespace Media1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());

            double B = double.Parse(Console.ReadLine());

            double MEDIA = ((Math.Abs(A) * 3.5) + (Math.Abs(B) * 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", MEDIA.ToString("0.00000"));
            Console.ReadLine();
        }
        
    }
}
