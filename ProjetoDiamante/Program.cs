namespace ProjetoDiamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe um número ímpar para verificar o desenho do diamante ");


            while (true)
            {
                int TamanhoDiamante = Convert.ToInt32(Console.ReadLine());


                if (TamanhoDiamante % 2 == 0)
                {
                    Console.WriteLine("Número inválido, digite um numero ímpar ");
                    continue;
                }

                for (int i=1; i<= TamanhoDiamante; i++)
                {
                    string DesenhoDiamante = new string('x', i);
                    Console.WriteLine(DesenhoDiamante);
                }
                

                Console.ReadLine();
            }


        }
    }
}
