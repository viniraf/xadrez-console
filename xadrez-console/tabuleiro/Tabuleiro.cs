namespace tabuleiro {
    class Tabuleiro {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        // Construtor
        public Tabuleiro(int linhas, int colunas){
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];

        }
        
        // Metodo para acessar a peça em outra classe
        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }

        // Metodo para colocar peça no tabuleiro
        public void colocarPeca(Peca p, Posicao pos) {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

    }
}
