using tabuleiro;

namespace Xadrez
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                for(int j = 0; j < tabuleiro.colunas; j++)
                {
                    if (tabuleiro.isPeca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tabuleiro.isPeca(i,j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
