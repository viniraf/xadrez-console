using tabuleiro;
using System;


namespace xadrez
{
    class Torre : Peca
    {

        // Construtor
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        // Config conversão de objeto para String
        public override string ToString()
        {
            return "T";
        }
    }
}