using tabuleiro;

namespace mecanica
{
    internal class Torre : Peca
    {

        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] wayMat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao posicaoAux = new Posicao(0, 0);

            //acima
            posicaoAux.RedefinirPosicao(Posicao.linha - 1, Posicao.coluna);
            while (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
            {
                wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
                if (tabuleiro.isPeca(posicaoAux) != null && tabuleiro.isPeca(posicaoAux).cor != cor)
                    break;

                posicaoAux.linha -= 1;
            }
            //Direita
            posicaoAux.RedefinirPosicao(Posicao.linha, Posicao.coluna + 1);
            while (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
            {
                wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
                if (tabuleiro.isPeca(posicaoAux) != null && tabuleiro.isPeca(posicaoAux).cor != cor)
                    break;

                posicaoAux.coluna += 1;
            }
            //abaixo
            posicaoAux.RedefinirPosicao(Posicao.linha + 1, Posicao.coluna);
            while (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
            {
                wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
                if (tabuleiro.isPeca(posicaoAux) != null && tabuleiro.isPeca(posicaoAux).cor != cor)
                    break;

                posicaoAux.linha += 1;
            }
            //Esquerda
            posicaoAux.RedefinirPosicao(Posicao.linha, Posicao.coluna - 1);
            while (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
            {
                wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
                if (tabuleiro.isPeca(posicaoAux) != null && tabuleiro.isPeca(posicaoAux).cor != cor)
                    break;

                posicaoAux.coluna -= 1;
            }

            return wayMat;
        }
    }
}