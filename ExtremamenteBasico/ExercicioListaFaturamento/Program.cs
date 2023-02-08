using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaFaturamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Faturamento> faturamento = new List<Faturamento>();
            faturamento.Add(new Faturamento("Seg", 1500));
            faturamento.Add(new Faturamento("Ter", 10));
            faturamento.Add(new Faturamento("Qua", 50));
            faturamento.Add(new Faturamento("Qui", 15));
            faturamento.Add(new Faturamento("Sex", 3560));
            faturamento.Add(new Faturamento("Sab", 0));
            faturamento.Add(new Faturamento("Dom", 0));
            faturamento.Add(new Faturamento("Seg", 4058));
            faturamento.Add(new Faturamento("Ter", 2350));
            faturamento.Add(new Faturamento("Qua", 487));
            faturamento.Add(new Faturamento("Qui", 150));

            decimal MenorValor = 0;
            decimal MaiorValor = 0;
            decimal valor = 0;

            for (int i = 0; i < faturamento.Count; i++)
            {
                if (faturamento[i].DiaSemana == "Sab" || faturamento[i].DiaSemana == "Dom")
                    continue;

                valor += faturamento[i].FaturamentoDia;
                if (i == 0)
                {
                    MenorValor = faturamento[i].FaturamentoDia;
                    MaiorValor = faturamento[i].FaturamentoDia;
                }

                //Obtem menor valor
                if (MenorValor > faturamento[i].FaturamentoDia)
                {
                    MenorValor = faturamento[i].FaturamentoDia;
                }
                //obtem maior valor
                if (MaiorValor < faturamento[i].FaturamentoDia)
                {
                    MaiorValor = faturamento[i].FaturamentoDia;
                }


            }

            decimal media = valor / faturamento.Count;

            int dias = 0;
            foreach (var item in faturamento)
                if (item.FaturamentoDia > media)
                    dias++;

            Console.WriteLine($"Menor valor: {MenorValor}");
            Console.WriteLine($"Maior valor: {MaiorValor}");
            Console.WriteLine($"Dias com valor superior a média: {dias}");

            Console.ReadLine();

        }
    }

    class Faturamento
    {
        public Faturamento(string dia, decimal fatu)
        {
            DiaSemana = dia;
            FaturamentoDia = fatu;
        }
        public string DiaSemana { get; set; }
        public decimal FaturamentoDia { get; set; }
    }
}
