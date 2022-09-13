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
    }
}
