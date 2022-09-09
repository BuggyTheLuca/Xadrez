using System;
using tabuleiro;
using mecanica;
using Xadrez.Exceptions;

namespace Xadrez
{
    public class Program
    {

        public static void Main()
        {
            try
            {
                Partida partida = new Partida();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tabuleiro);

                    Console.WriteLine("-------------------");
                    Console.WriteLine();

                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();


                    bool[,] movimentosPossiveis = partida.tabuleiro.isPeca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tabuleiro, movimentosPossiveis);

                    Console.WriteLine("-------------------");
                    Console.WriteLine();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

                    partida.ExecutarMovimento(origem, destino);
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Error: " + e.Message + " track: " + e.StackTrace);
            }
        }
    }
}