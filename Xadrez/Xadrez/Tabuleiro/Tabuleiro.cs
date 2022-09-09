using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            pecas[posicao.linha, posicao.coluna] = peca;
            peca.posicao = posicao;
        }
    }
}
