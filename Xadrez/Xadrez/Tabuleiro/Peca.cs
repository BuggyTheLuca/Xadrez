using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantidadeDeMovimentos { get; protected set; } = 0;
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.Posicao = null;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            this.quantidadeDeMovimentos = 0;
        }

        protected bool PodeMover(Posicao posicao)
        {
            Peca peca = tabuleiro.isPeca(posicao);
            return peca == null || peca.cor != cor;
        }

        public void IncrementarMovimento()
        {
            quantidadeDeMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
