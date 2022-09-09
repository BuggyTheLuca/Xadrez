using System;
using tabuleiro;
using Xadrez;
using Xadrez.Exceptions;

namespace mecanica
{
    internal class Partida
    {
        public Tabuleiro tabuleiro { private set; get; }
        public int turno { private set; get; }
        public Cor jogadorAtual { private set; get; }
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

        public void RealizarJogada(Posicao origem, Posicao destino)
        {
            ExecutarMovimento(origem, destino);
            turno++;
            MudarJogador();

        }

        public void validarOrigem(Posicao posicao)
        {
            if (tabuleiro.isPeca(posicao) == null)
            {
                throw new TabuleiroException("Não existe peça nesta posição!");
            }
            if (jogadorAtual != tabuleiro.isPeca(posicao).cor)
            {
                throw new TabuleiroException("Peça escolhida com cor errada!");
            }
            if (!tabuleiro.isPeca(posicao).ExisteMovimento())
            {
                throw new TabuleiroException("Não existem movimentos possiveis para esta peça!");
            }
        }

        private void MudarJogador()
        {
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
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
