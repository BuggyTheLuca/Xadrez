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
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            PosicaoXadrez posicaoXadrez = new PosicaoXadrez('d', 3);
            Console.WriteLine(posicaoXadrez);
            Console.WriteLine(posicaoXadrez.toPosicao());
        }
    }
}