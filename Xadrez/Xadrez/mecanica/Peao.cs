using Xadrez.Exceptions;
using tabuleiro;

namespace mecanica
{
    internal class Peao : Peca
    {
        public Peao(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "P";
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] wayMat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao posicaoAux = new Posicao(0, 0);


            if (cor == Cor.Branca)
            {
                posicaoAux.RedefinirPosicao(Posicao.linha - 1, Posicao.coluna);
                if (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
                {
                    if (tabuleiro.isPeca(posicaoAux) != null && tabuleiro.isPeca(posicaoAux).cor != cor)
                    {
                        wayMat[posicaoAux.linha, posicaoAux.coluna] = false;
                    }
                    else
                    {
                        wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
                        if (quantidadeDeMovimentos == 0)
                        {
                            wayMat[posicaoAux.linha - 1, posicaoAux.coluna] = true;
                        }
                    }
                }
                posicaoAux.RedefinirPosicao(Posicao.linha - 1, Posicao.coluna-1);
                if (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
                {
                    if (tabuleiro.isPeca(posicaoAux) != null && tabuleiro.isPeca(posicaoAux).cor != cor)
                    {
                        wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
                    }
                    else
                    {
                        wayMat[posicaoAux.linha, posicaoAux.coluna] = false;
                    }
                }
                posicaoAux.RedefinirPosicao(Posicao.linha - 1, Posicao.coluna + 1);
                if (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
                {
                    if (tabuleiro.isPeca(posicaoAux) != null && tabuleiro.isPeca(posicaoAux).cor != cor)
                    {
                        wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
                    }
                    else
                    {
                        wayMat[posicaoAux.linha, posicaoAux.coluna] = false;
                    }
                }
            }
            else
            {
                posicaoAux.RedefinirPosicao(Posicao.linha + 1, Posicao.coluna);
                if (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
                {
                    if (tabuleiro.isPeca(posicaoAux) != null && tabuleiro.isPeca(posicaoAux).cor != cor)
                    {
                        wayMat[posicaoAux.linha, posicaoAux.coluna] = false;
                    }
                    else
                    {
                        wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
                        if (quantidadeDeMovimentos == 0)
                        {
                            wayMat[posicaoAux.linha + 1, posicaoAux.coluna] = true;
                        }
                    }

                }
                posicaoAux.RedefinirPosicao(Posicao.linha + 1, Posicao.coluna - 1);
                if (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
                {
                    if (tabuleiro.isPeca(posicaoAux) != null && tabuleiro.isPeca(posicaoAux).cor != cor)
                    {
                        wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
                    }
                    else
                    {
                        wayMat[posicaoAux.linha, posicaoAux.coluna] = false;
                    }
                }
                posicaoAux.RedefinirPosicao(Posicao.linha + 1, Posicao.coluna + 1);
                if (tabuleiro.posicaoValida(posicaoAux) && PodeMover(posicaoAux))
                {
                    if (tabuleiro.isPeca(posicaoAux) != null && tabuleiro.isPeca(posicaoAux).cor != cor)
                    {
                        wayMat[posicaoAux.linha, posicaoAux.coluna] = true;
                    }
                    else
                    {
                        wayMat[posicaoAux.linha, posicaoAux.coluna] = false;
                    }
                }
            }
            return wayMat;
        }
    }
}
