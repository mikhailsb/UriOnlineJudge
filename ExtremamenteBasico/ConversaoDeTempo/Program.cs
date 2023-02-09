using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDeTempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada = 556;

            int hora = (int)(entrada / (60 * 60));
            int minuto = (int)((entrada - (hora * 60 * 60)) / 60);
            int segundo = (int)(entrada -(hora * 60 * 60) - (minuto * 60));

            Console.WriteLine(hora +":"+minuto + ":" +segundo);

            Console.ReadLine();
        }
    }
}
