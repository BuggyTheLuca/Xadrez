using System;
using tabuleiro;
using Xadrez;

namespace mecanica
{
    internal class Partida
    {
        public Tabuleiro tabuleiro { private set; get; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public Partida()
        {
            tabuleiro = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            ColocarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = tabuleiro.RetirarPeca(origem);
            peca.IncrementarMovimento();
            Peca pecaCapturada = tabuleiro.RetirarPeca(destino);
            tabuleiro.ColocarPeca(peca, destino);
        }

        private void ColocarPecas()
        {
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new PosicaoXadrez('e', 8).toPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('d', 4).toPosicao());

            ColocarPeoes();
        }

        private void ColocarPeoes()
        {
            for(char i = 'a'; i <= 'h'; i++)
            {
                tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez(i, 2).toPosicao());
                tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez(i, 7).toPosicao());
            }
        }

    }
}
