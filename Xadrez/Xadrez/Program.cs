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

            
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(3, 4));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(3, 4));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(1, 1));
            
            
            Tela.ImprimirTabuleiro(tabuleiro);
        }
    }
}