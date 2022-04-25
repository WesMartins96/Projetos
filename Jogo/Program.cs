using System;

namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool certaResposta = false;
            Random r = new Random();
            int advinhar = r.Next(0, 10);
            Console.WriteLine("BEM VINDO AO: ADVINHE UM NUMERO");
            Console.WriteLine("Dica: o numero está entre 0 e 10");
            Console.WriteLine();

            int contador = 1;
            while (!certaResposta && contador < 6)
            {
                Console.WriteLine("VOCÊ TEM APENAS 5 TENTATIVAS!!!");
                Console.WriteLine($"Tentativa numero: {contador}");
                contador += 1;
                Console.Write("Entre com a sua tentativa: ");
                int tentativa = int.Parse(Console.ReadLine());

                if (tentativa > advinhar)
                {
                    Console.WriteLine("Dica: Seu numero é muito alto");
                    Console.WriteLine();
                }
                else if (tentativa < advinhar)
                {
                    Console.WriteLine("Dica: Seu numero é muito Baixo");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("!!CORRETO!! Parabêns!!");
                    Console.WriteLine("!!!!!!!!!!WINNER!!!!!!!!!!");
                    certaResposta = true;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Numero de Tentativas: {contador-1}");
        }
    }
}
