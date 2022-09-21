using tabuleiro;
using System;


namespace xadrez {
    class Rei: Peca {

        // Construtor
        public Rei (Tabuleiro tab, Cor cor): base (tab, cor) {

        }

        // Config conversão de objeto para String
        public override string ToString() {
            return "R";
        }
    }
}
