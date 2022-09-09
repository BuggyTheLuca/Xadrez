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
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.tabuleiro);

                        Console.WriteLine("-------------------");
                        Console.WriteLine($"Turno: {partida.turno}");
                        Console.WriteLine();
                        Console.WriteLine($"Jogador atual: {partida.jogadorAtual}");
                        Console.WriteLine("-------------------");
                        Console.WriteLine();

                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                        partida.validarOrigem(origem);


                        bool[,] movimentosPossiveis = partida.tabuleiro.isPeca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.tabuleiro, movimentosPossiveis);

                        Console.WriteLine("-------------------");
                        Console.WriteLine($"Turno: {partida.turno}");
                        Console.WriteLine();
                        Console.WriteLine($"Jogador atual: {partida.jogadorAtual}");
                        Console.WriteLine("-------------------");
                        Console.WriteLine();

                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

                        partida.RealizarJogada(origem, destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine("---------------");
                        Console.WriteLine(e.Message);
                        Console.WriteLine("---------------");
                        Console.WriteLine("Pressione enter.");
                        Console.ReadLine();
                    }
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Error: " + e.Message);

            }
        }
    }
}