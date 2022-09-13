namespace tabuleiro {
    class Peca {

        // Atributos
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        // Construtor
        public Peca (Posicao posicao, Tabuleiro tab, Cor cor) {
            this.posicao = posicao;
            this.tab = tab;
            this.qteMovimentos = 0;
        }
    }
}
