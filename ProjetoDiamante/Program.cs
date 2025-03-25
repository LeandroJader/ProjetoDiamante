using System;

namespace ProjetoDiamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número ímpar para verificar o desenho do diamante:");

            while (true)
            {
                int tamanhoDiamante;

                if (!int.TryParse(Console.ReadLine(), out tamanhoDiamante))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                    Console.ResetColor();
                    continue;
                }

                if (tamanhoDiamante % 2 == 0)
                {
                    Console.WriteLine("Número inválido, digite um número ímpar.");
                    continue;
                }

                int meio = tamanhoDiamante / 2;

                
                for (int i = 0; i <= meio; i++)
                {
                    int espacos = meio - i;
                    int quantidadeDeX = 2 * i + 1;
                    Console.WriteLine(new string(' ', espacos) + new string('x', quantidadeDeX));
                }

      
                for (int i = meio - 1; i >= 0; i--)
                {
                    int espacos = meio - i;
                    int quantidadeDex = 2 * i + 1;
                    Console.WriteLine(new string(' ', espacos) + new string('x', quantidadeDex));
                }

                Console.ReadLine();
            }
        }
    }
}
