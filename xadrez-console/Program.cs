using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program{
        static void Main(string[] args){

            // Teste concatenação posição tabuleiro
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            // Teste converção posição tabuleiro para posição matriz interna do sistema
            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
            
        }
    }
}
