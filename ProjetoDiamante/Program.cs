using ProjetoDiamante;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
   
            int tamanhoDiamante = FuncoesDiamante.SolicitarEntradaDeDados();
        
            FuncoesDiamante.DesenharDiamante(tamanhoDiamante);

            if (!FuncoesDiamante.Continuar())
            {
                break;
            }

            
        }
    }
}
