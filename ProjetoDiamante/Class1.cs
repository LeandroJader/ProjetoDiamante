namespace ProjetoDiamante;

    public class FuncoesDiamante
    {
      
        public static int SolicitarEntradaDeDados()
        {
            int tamanhoDiamante;
                Console.WriteLine("Informe um número ímpar para o desenho do diamante:");
     
        while (true)
            {
              

           
                if (!int.TryParse(Console.ReadLine(), out tamanhoDiamante))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                    Console.ResetColor();
                    continue;
                }
                Console.WriteLine();
            
                if (tamanhoDiamante % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número inválido. Digite um número ímpar.");
                    Console.ResetColor();
                    continue;
                }
               Console.WriteLine();
                return tamanhoDiamante;
            }
        }

        public static void DesenharDiamante(int tamanho)
        {
            int meio = tamanho / 2;

            for (int i = 0; i <= meio; i++)
            {
                int espacos = meio - i;
                int quantidadeDeX = 2 * i + 1;
               
                Console.WriteLine(new string(' ', espacos) + new string('x', quantidadeDeX));
            }

            for (int i = meio - 1; i >= 0; i--)
            {
                int espacos = meio - i;
                int quantidadeDeX = 2 * i + 1;
            
                Console.WriteLine(new string(' ', espacos) + new string('x', quantidadeDeX));
            }
            
            
        }
    public static bool Continuar()
    {
        Console.WriteLine();
        Console.WriteLine("você deseja continuar ? S/N");
       string  continuar = Console.ReadLine().ToUpper();

            return continuar == "S";
        
    }
    }