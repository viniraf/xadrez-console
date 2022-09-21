using System;
using tabuleiro;

namespace xadrez {
    class PosicaoXadrez {

        public char coluna { get; set; }
        public int linha { get; set; }


        // Converter posição formato tabuleiro para posição formato matriz interna do sistema
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public PosicaoXadrez (char coluna, int linha) {
            this.coluna = coluna;
            this.linha = linha;
        }

        public override string ToString() {
            return "" + coluna + linha;
        }
    }
}
