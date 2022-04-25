using System;
using System.Globalization;

namespace VendasEComissoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor v = new Vendedor();
            Console.Write("Digite seu ID: ");
            v.Id = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite seu Nome: ");
            v.Nome = (Console.ReadLine());
            Console.Clear();

            Console.WriteLine();
            Console.Write("INFORME A QUANTIDADE DE VENDAS REALIZADAS PARA SER CALCULADO SUA COMISSÃO: ");

            int n = int.Parse(Console.ReadLine());

            double[] vendas = new double[n];
            double totalVenda = 0.0;
            Console.WriteLine("Digite aqui os valores das vendas: ");
            for (int i = 0; i < n; i++)
            {
                vendas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                totalVenda += vendas[i];
            }
            Console.WriteLine(
                $"Vendedor: {v.Nome}, " +
                $"Id: {v.Id}, " +
                $"Total de valor das vendas: {totalVenda.ToString("F2", CultureInfo.InvariantCulture)}");

            if (n <= 5)
            {
                Console.WriteLine($"Sua Comissão será de 0,4%: ${totalVenda * 0.4}");
            }
            else if (n <= 10)
            {
                Console.WriteLine($"Sua comissão será de 1,3%: ${totalVenda * 1.3}");
            }
            else if (n <= 15)
            {
                Console.WriteLine($"Sua comissão será de 3%: ${totalVenda * 3.0}");
            }
            else if (n >= 16)
            {
                Console.WriteLine($"Sua comissão será de 5%: ${totalVenda * 5.0}");
            }
            else
            {
                Console.WriteLine("Não há comissão");
            }

        }

    }

}


