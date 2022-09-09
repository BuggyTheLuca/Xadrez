using System;
using Xadrez.Exceptions;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas,colunas];
        }

        public Peca isPeca(int linha, int coluna)
        {
            return pecas[linha,coluna];
        }

        public Peca isPeca(Posicao posicao)
        {
            return pecas[posicao.linha, posicao.coluna];
        }

        public bool pecaExists(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return isPeca(posicao) != null;
        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if (pecaExists(posicao))
            {
                throw new TabuleiroException($"Já existe uma peça na posição {posicao}.");
            }
            pecas[posicao.linha, posicao.coluna] = peca;
            peca.Posicao = posicao;
        }

        public Peca RetirarPeca(Posicao posicao)
        {
            if (isPeca(posicao) == null)
            {
                return null;
            }
            Peca auxPeca = isPeca(posicao);
            auxPeca.Posicao = null;
            pecas[posicao.linha, posicao.coluna] = null;
            return auxPeca;
        }

        public bool posicaoValida(Posicao posicao)
        {
            if (posicao.linha < 0 || posicao.coluna < 0
                || posicao.linha >= linhas || posicao.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!posicaoValida(posicao))
            {
                throw new TabuleiroException($"Posição {posicao} inválida!");
            }
        }
    }
}
