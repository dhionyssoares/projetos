using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoXadrez
{
    internal class Posicao
    {
        public int linha {  get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return $"{linha}, {Coluna}";
        }
    }
}
