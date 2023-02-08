using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFaturamento2Porcentagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Faturamento> faturamento = new List<Faturamento>();
            faturamento.Add(new Faturamento("SP", 67836.43));
            faturamento.Add(new Faturamento("RJ", 36678.66));
            faturamento.Add(new Faturamento("MG", 2922988));
            faturamento.Add(new Faturamento("ES", 27165.48));
            faturamento.Add(new Faturamento("Outros", 19849.53));

            double valorTotal =0;
            //calc total
            foreach (var item in faturamento)
            {
                valorTotal += item.FaturamentoDia;
            }


        }
    }
    class Faturamento
    {
        public Faturamento(string estado, double fatu)
        {
            Estado = estado;
            FaturamentoDia = fatu;
        }
        public string Estado { get; set; }
        public double FaturamentoDia { get; set; }
    }
}
