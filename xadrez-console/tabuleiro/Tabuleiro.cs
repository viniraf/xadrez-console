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
        
        // Sobrecarga metodo acessar a peça
        public Peca peca (Posicao pos) {
            return pecas[pos.linha, pos.coluna];
        }

        // Metodo para colocar peça no tabuleiro
        public void colocarPeca(Peca p, Posicao pos) {
            // verificação para não ser possivel colocar peça aonde já tem
            if (existePeca(pos)) {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }

            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        // Metodo para retirar peça
        public Peca retirarPeca(Posicao pos) {
            if (peca(pos) == null) {
                return null;
            } else {
                Peca aux = peca(pos);
                aux.posicao = null;
                pecas[pos.linha, pos.coluna] = null;
                return aux;
            }
        }

        // Metodo para verificar se existe uma peça numa determinada posição
        public bool existePeca(Posicao pos) {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        // Metodo para testar se posição é valida
        public bool posicaoValida (Posicao pos) {
            if (pos.linha <0 || pos.linha>=linhas || pos.coluna<0 || pos.coluna >= colunas) {
                return false;
            } else {
                return true;
            }
        }

        // Exceção
        public void validarPosicao(Posicao pos) {
            if (!posicaoValida(pos)) {
                throw new TabuleiroException("Posição inválida");
            }
        }
    }
}
