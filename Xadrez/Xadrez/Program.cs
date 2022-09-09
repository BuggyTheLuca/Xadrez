using System;
using tabuleiro;

namespace Xadrez
{
    public class Program
    {

        public static void Main()
        {
            Tabuleiro tab = new Tabuleiro(2, 2);
            Posicao posi = new Posicao(1,1);
            Peca peca = new Peca(posi, tab, Cor.Preta);
        }
    }
}