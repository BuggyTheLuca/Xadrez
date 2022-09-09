using tabuleiro;

namespace mecanica
{
    internal class Rei : Peca
    {

        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] wayMat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao posicaoAux = new Posicao(0, 0);

            //acima
            posicaoAux.RedefinirPosicao(Posicao.linha - 1, Posicao.coluna);
            if (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
            {
                wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
            }
            //Acima-Direita
            posicaoAux.RedefinirPosicao(Posicao.linha - 1, Posicao.coluna + 1);
            if (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
            {
                wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
            }
            //Direita
            posicaoAux.RedefinirPosicao(Posicao.linha, Posicao.coluna + 1);
            if (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
            {
                wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
            }
            //Direita-Abaixo
            posicaoAux.RedefinirPosicao(Posicao.linha + 1, Posicao.coluna + 1);
            if (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
            {
                wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
            }
            //Abaixo
            posicaoAux.RedefinirPosicao(Posicao.linha + 1, Posicao.coluna);
            if (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
            {
                wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
            }
            //Abaixo-Esquerda
            posicaoAux.RedefinirPosicao(Posicao.linha + 1, Posicao.coluna - 1);
            if (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
            {
                wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
            }
            //Esquerda
            posicaoAux.RedefinirPosicao(Posicao.linha, Posicao.coluna - 1);
            if (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
            {
                wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
            }
            //Esquerda-Acima
            posicaoAux.RedefinirPosicao(Posicao.linha - 1, Posicao.coluna - 1);
            if (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
            {
                wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
            }
            return wayMat;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
