namespace tabuleiro
{
    class Posicao{
        public int linha { get; set; }
        public int coluna { get; set; }

        // Construtor
        public Posicao (int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }

        // Config conversão de objeto para String
        public override string ToString(){
            return linha
                + ", "
                + coluna;
        }


    }
}
