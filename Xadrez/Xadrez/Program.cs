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

            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(3 , 3));
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(7, 3));


            Tela.ImprimirTabuleiro(tabuleiro);
        }
    }
}