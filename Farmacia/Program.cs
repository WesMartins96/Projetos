using System;
using System.Collections.Generic;

namespace Farmacia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lista de Remedios Disponiveis");
            List<string> list = new List<string>{ "Tylenol", "Paracetamol", "Dorflex", "Torcilax", "Rivotril"
            , "Maracujina", "Lufital", "Ritalina", "Expec", "Dramin"};

            foreach (string l in list)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine($"Numero de marcas Disponiveis: {list.Count}");
            Console.WriteLine("Precione <ENTER> para continuar");
            Console.ReadKey();
            Console.Clear();

            //Encontrar primeiro da lista pela primeira letra
            Console.Write("Procure por uma letra: ");
            string procuraEstoque = list.Find(x => x[0] == char.Parse(Console.ReadLine().ToLower().ToUpper().ToString()));
            Console.WriteLine($"Primeiro remedio com a letra digitada foi: {procuraEstoque}");
            Console.WriteLine();

            Console.Write("Digite a posição: ");
            int posicaoEstoque = list.FindIndex(x => x[0] == int.Parse(Console.ReadLine().ToString()));
            Console.WriteLine($"Posição do remedio: {posicaoEstoque}");


            Console.Write("Procure por numero de letras: ");
            List<string> list2 = list.FindAll(x => x.Length == int.Parse(Console.ReadLine().ToString()));
            Console.WriteLine();
            foreach (string l in list2)
            {
                Console.WriteLine(l);
            }

        }
    }
}
