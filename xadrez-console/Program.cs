using System;
using tabuleiro;

namespace xadrez_console
{
    class Program{
        static void Main(string[] args){

            // Teste criação objeto
            Posicao P;
            P = new Posicao(3, 4);

            // Teste to string
            Console.WriteLine("Posição: " + P);
            Console.ReadLine();
        }
    }
}
