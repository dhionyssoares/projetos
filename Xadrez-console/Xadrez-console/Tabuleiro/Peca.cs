
namespace JogoXadrez
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int quantidadeMovimentos, Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            QuantidadeMovimentos = 0;
            this.tabuleiro = tabuleiro;
        }
    }
}
